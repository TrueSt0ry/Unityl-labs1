using UnityEngine;

public class Trig : MonoBehaviour
{
    private Rigidbody rb;
    private bool hasTriggered = false;

    [Header("Параметры отлета меча")]
    public float horizontalForce = 200f;   // Сила по иксу
    public float upwardForce = 100f;        // Небольшая сила вверх

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.useGravity = true;           // Включаем гравитацию
            rb.isKinematic = true;          // До удара не двигается
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (!hasTriggered && rb != null)
        {
            hasTriggered = true;

            // Включаем физику
            rb.isKinematic = false;

            // Очищаем текущую скорость
            rb.linearVelocity = Vector3.zero;

            // Применяем импульс: чуть вверх и в сторону
            rb.AddForce(horizontalForce * -1, upwardForce, 0f, ForceMode.Impulse);
        }
    }
}