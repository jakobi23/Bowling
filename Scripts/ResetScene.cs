using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int count =0;
        if(ResetBall.turnCount = 2){
            if(count == 200){
            SceneManager.LoadScene("SampleScene");
            }
            else{
                count++;
            }
        }
    }
}
