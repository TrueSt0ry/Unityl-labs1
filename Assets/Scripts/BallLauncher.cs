using UnityEngine;

public class BallLauncher : MonoBehaviour
{
    private Rigidbody rb;
    private bool isLaunched = false;

    public float launchForce = 500f;  // Сила запуска (настраивай в Unity)

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMouseDown()
    {
        if (!isLaunched && rb != null)
        {
            isLaunched = true;
            rb.AddForce(0f, launchForce, 0f, ForceMode.Impulse);
        }
    }
}