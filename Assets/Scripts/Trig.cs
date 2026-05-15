using UnityEngine;

public class Trig : MonoBehaviour
{
    private float speed = 2f;

    //Moves this GameObject 2 units a second in the forward direction
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }

    //Upon collision with another GameObject, this GameObject will reverse direction
    private void OnTriggerEnter(Collider other)
    {
        speed = speed * -10;
    }
}