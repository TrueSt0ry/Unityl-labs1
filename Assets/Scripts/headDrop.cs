using UnityEngine;

public class headDrop : MonoBehaviour
{
    private Rigidbody rb;
    private float y = 100f;  // Added 'private float' and 'f' suffix

    void Start()  // Changed from Update to Start to apply force once
    {
        rb = GetComponent<Rigidbody>();  // Initialize the Rigidbody reference
        rb.AddForce(-100f, y, 0f, ForceMode.Impulse);
    }

    void Update()
    {
        y = y * 0.9f;  // Added 'f' suffix
    }
}