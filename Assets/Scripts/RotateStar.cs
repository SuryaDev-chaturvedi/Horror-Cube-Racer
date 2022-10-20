using UnityEngine;

public class RotateStar : MonoBehaviour
{
    public float speed = 10f;


    void Update()
    {
        transform.Rotate(Vector3.forward * speed*Time.deltaTime);
    }
}
