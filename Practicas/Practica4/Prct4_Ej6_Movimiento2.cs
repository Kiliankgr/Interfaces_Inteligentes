using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prct4_Ej6_Movimiento2 : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotationspeed = 2;
    float speed = 10.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float rotation  = Input.GetAxis("Horizontal") * rotationspeed;
        
        if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow)) {   
            
            this.transform.Translate(transform.forward * Time.deltaTime * Input.GetAxis("Vertical") * speed, Space.World);
        }
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)) {
            
            transform.Rotate(0,rotation,0);
        }
    }
}
