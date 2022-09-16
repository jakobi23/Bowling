using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    Vector3 starting = new Vector3((float) -0.334,(float) 4.796, (float) -23.03);
    public GameObject BowlingBall;
    // Start is called before the first frame update
    void Start()
    {
        BowlingBall = Instantiate(BowlingBall, starting, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
