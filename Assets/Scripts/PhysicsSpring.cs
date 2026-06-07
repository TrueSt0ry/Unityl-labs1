using UnityEngine;

public class PhysicsSpring : MonoBehaviour
{
    public float springForce = 1000f;
    public float damperForce = 10f;
    public float maxDistance = 0.5f;

    private Rigidbody rb;
    private Vector3 anchorPoint;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anchorPoint = transform.position + Vector3.right * 0.3f;
    }

    void FixedUpdate()
    {
        Vector3 direction = anchorPoint - transform.position;
        float distance = direction.magnitude;
        float spring = springForce * distance;
        float damper = damperForce * Vector3.Dot(rb.linearVelocity, direction.normalized);

        rb.AddForce(direction.normalized * (spring - damper));

        // Автоматический выстрел при максимальном натяжении
        if (distance > maxDistance)
        {
            rb.AddForce(Vector3.right * 15f, ForceMode.Impulse);
        }
    }
}