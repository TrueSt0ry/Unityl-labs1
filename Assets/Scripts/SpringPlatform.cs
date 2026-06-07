using UnityEngine;

public class SpringPlatform : MonoBehaviour
{
    [Header("Настройки пружины")]
    public float springForce = 15f;          // Сила отталкивания
    public float compressionDistance = 0.2f; // На сколько сжимается платформа
    public float compressionSpeed = 10f;     // Скорость сжатия/возврата

    private Vector3 originalPos;
    private bool isCompressed = false;

    void Start()
    {
        originalPos = transform.localPosition;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            // Сжимаем платформу
            Vector3 compressedPos = originalPos;
            compressedPos.y -= compressionDistance;
            transform.localPosition = compressedPos;
            isCompressed = true;

            // Отталкиваем шар
            Rigidbody ballRb = collision.gameObject.GetComponent<Rigidbody>();
            if (ballRb != null)
            {
                // Сила только вверх (Y)
                Vector3 force = Vector3.up * springForce;
                ballRb.AddForce(force, ForceMode.Impulse);
            }

            // Запускаем возврат платформы
            Invoke(nameof(ReturnPlatform), 0.05f);
        }
    }

    void ReturnPlatform()
    {
        transform.localPosition = originalPos;
        isCompressed = false;
    }
}