using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public ChallengeController challengeControllerSpeed;

    private void OnCollisionEnter(Collision GameObject)
    {
        Debug.Log("OnCollisionEnter");
        if(GameObject.collider.tag == "Hurdle")
        {
            GameOver();
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("OnCollisionExit");
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("OnCollisionStay");

    }
    public void GameOver()
    {
        challengeControllerSpeed.speed = 0f;
    }
}
