using UnityEngine;

public class Trig : MonoBehaviour
{
  //  private float speed = 2f;

    //Moves this GameObject 2 units a second in the forward direction
    void Update()
    {
     //   transform.Translate(Vector3.down * Time.deltaTime * speed);
    }

 
    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody)
            other.attachedRigidbody.useGravity = true;
    }
}