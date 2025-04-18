using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
    
{
   
    float h;
    float v;
    Rigidbody2D rigid;

    void Awake() 
    { 
        rigid = GetComponent<Rigidbody2D>(); 
    }

    void Update() 
    {
        h = Input.GetAxisRaw("Horizontal"); 
        v = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rigid.linearVelocity = new Vector2(h*4, v*4) ;
       
    }
}
