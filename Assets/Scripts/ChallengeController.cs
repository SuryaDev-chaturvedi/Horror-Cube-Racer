using UnityEngine;

public class ChallengeController : MonoBehaviour
{
    public GameObject[] challenges;
    public float speed = 50f;
    public Transform challengespwanPoint;

    public float counter;

    private void Start()
    {
        GenrateChallenges();
    }

    private void Update()
    {
        if(counter < 0)
        {
            GenrateChallenges();
        }
        else {
            counter -= Time.deltaTime;
        }

        GameObject currentChild;

        for(int i=0; i < transform.childCount; i++)
        {
            currentChild = transform.GetChild(i).gameObject;
            ScrollSpeed(currentChild);

            if(currentChild.transform.position.x > 15f)
            {
                Destroy(currentChild);
            }
        }
    }

    void GenrateChallenges()
    {
     GameObject challenge = Instantiate(challenges[Random.Range(0, challenges.Length)], challengespwanPoint.transform.position, Quaternion.identity);

        challenge.transform.parent = transform;
        counter = 2f;
    }

    void ScrollSpeed(GameObject currentChallenge)
    {
        currentChallenge.transform.position += Vector3.left * -speed * Time.deltaTime;
    }
}
