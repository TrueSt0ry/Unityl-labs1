using UnityEngine;

public class PlatformMoverX : MonoBehaviour
{
    [Header("Настройки движения")]
    public float moveRange = 3f;        // Диапазон движения (влево-вправо)
    public float moveSpeed = 2f;        // Скорость движения
    public float startDelay = 0f;       // Задержка перед стартом

    private Vector3 startPosition;
    private float direction = 1f;       // 1 = вправо, -1 = влево
    private float timer;

    void Start()
    {
        startPosition = transform.position;
        timer = -startDelay;
    }

    void Update()
    {
        if (timer < 0)
        {
            timer += Time.deltaTime;
            return;
        }

        // Двигаем платформу
        float newX = transform.position.x + direction * moveSpeed * Time.deltaTime;

        // Проверяем границы
        if (newX > startPosition.x + moveRange)
        {
            newX = startPosition.x + moveRange;
            direction = -1f;
        }
        else if (newX < startPosition.x - moveRange)
        {
            newX = startPosition.x - moveRange;
            direction = 1f;
        }

        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }
}