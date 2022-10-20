using UnityEngine;

public class Accelaration : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, 0f, Input.acceleration.x * 10 * Time.smoothDeltaTime);        
    }
}
