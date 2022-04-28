using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableController : MonoBehaviour
{
    // Start is called before the first frame update
    //    一回だけ
    void Start()
    {
        
    }

    // Update is called once per frame
    //    ずっと
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow)){
            this.transform.Rotate(0,0,1.0f);
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            this.transform.Rotate(0,0,-1.0f);
        }
        if(Input.GetKey(KeyCode.UpArrow)){
            this.transform.Rotate(1.0f,0,0);
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            this.transform.Rotate(-1.0f,0,0);
        }
    }
}
