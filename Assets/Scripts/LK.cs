using UnityEngine;

public class LK : MonoBehaviour
{
    public float thrust = 1.0f;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(thrust, 0, 0, ForceMode.Impulse);
    }
}