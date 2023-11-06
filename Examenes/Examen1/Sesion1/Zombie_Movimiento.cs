using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie_Movimiento : MonoBehaviour
{
    public float rotationspeed = 1;
    float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotation  = Input.GetAxis("Horizontal") * rotationspeed;
        
        if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow)) {   
            
            this.transform.Translate(transform.forward * Time.deltaTime * Input.GetAxis("Vertical") * speed, Space.World);
        }
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)) {
            
            
            Transform posArotar = this.transform;
            posArotar.Rotate(0,rotation,0);
            Quaternion rot = posArotar.rotation;
            
            transform.rotation = Quaternion.Slerp(this.transform.rotation, posArotar.rotation, 0.5f * Time.deltaTime);
        }

        ;
    }
}