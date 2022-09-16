using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBall : MonoBehaviour
{
    Rigidbody rb;

    public int turnCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float yPos = transform.position.y;
        if(yPos <=-9.14){
            //DestroyGameObject(BowlingBall);
            turnCount++;
            //Create(gameObject);
        }
    }
}
