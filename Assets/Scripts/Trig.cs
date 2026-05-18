using UnityEngine;

public class Trig : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        // Получаем компонент Rigidbody текущего объекта
        rb = GetComponent<Rigidbody>();

        // На всякий случай убедимся, что изначально гравитация выключена
        if (rb != null)
        {
            rb.useGravity = false;
        }
        else
        {
            Debug.LogError("На объекте отсутствует компонент Rigidbody!");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // При первом же столкновении включаем гравитацию
            rb.useGravity = true;
    }
}