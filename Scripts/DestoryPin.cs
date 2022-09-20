using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryPin : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        bool upRight= false;
        int count = 0;
        if(count == 100){
            if(rb.transform.rotation.eulerAngles.y > 0.001 && rb.transform.rotation.eulerAngles.y < 0.01){
                upRight = false;
            }
            else(rb.transform.rotation.eulerAngles.y < 0.001 || rb.transform.rotation.eulerAngles.y > 0.01){
                upRight = true;
            }
            if(upRight = true){
                Destroy(rb);
            }

        }
        else{
            count++; 
        }
    }
}
