using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCubeSize : MonoBehaviour
{
    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BigCube()
    {
        cube.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
    }
    public void SmallCube()
    {
        cube.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }
    public void MiddleCube()
    {
        cube.transform.localScale = new Vector3(1f, 0.3f, 2f);
    }
}
