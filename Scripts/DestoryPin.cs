using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryPin : MonoBehaviour
{
    Rigidbody rb;
     Vector3 pos;

     int count = 0;

    GameObject pin;

    Vector3 newPos;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        pin = GetComponent<GameObject>();
        pos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        
    }

    // Update is called once per frame
    void Update()
    {
        bool upRight = true;
        
        if(count == 100){
            Debug.Log(count);

            newPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            if(/*rb.transform.rotation.eulerAngles.x > 0.001 && rb.transform.rotation.eulerAngles.x < 0.01 && rb.transform.rotation.eulerAngles.z > 0.001 && rb.transform.rotation.eulerAngles.z < 0.01*/ pos != newPos){
                upRight = false;
                Debug.Log(upRight);
            }
            /*else if (pos != newPos){
                upRight = false;
            }*/
            
                
            
            if(upRight == false){
                Destroy(pin);
            }
            count = 0;
        }
        else{
            Debug.Log(count);
            count = count + 1; 
        }
    }
}
