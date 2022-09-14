using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw1 : MonoBehaviour
{
    public float speed = 0f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //INCREASES THE POWER OF THE BALL
        if(Input.GetKeyDown(KeyCode.UpArrow)){
        speed =+ 100f;
        //Console.WriteLine(speed);
        if(speed > 1000f){
            speed = 1000f;
        }
       }

       //DECREASES THE POWER OF THE BALL
       if(Input.GetKeyDown(KeyCode.DownArrow)){
        speed =- 100f;
        //Console.WriteLine(speed);
        if(speed<0f){
            speed = 0f;
        }
       }

       //THROWS THE BALL
       if(Input.GetKeyDown(KeyCode.Space)){
            gameObject.GetComponent<Rigidbody>().AddForce(0f, 0f, (speed* 25f));
       }
    }
}
