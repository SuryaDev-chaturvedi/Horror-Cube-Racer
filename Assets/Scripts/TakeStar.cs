using UnityEngine;

public class TakeStar : MonoBehaviour
{
   

    private void OnTriggerEnter2D(Collider2D target)
    {
        
            Destroy(gameObject);
            Debug.Log("Collision");
        
    }

}
