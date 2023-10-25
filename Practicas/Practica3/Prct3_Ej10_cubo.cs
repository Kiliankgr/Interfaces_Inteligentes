using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prct3_Ej10_cubo : MonoBehaviour
{
    public float rotationspeed = 2;
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
            // Si QUISIERAMOS que la rotacion fuese más suave, añadiriamos Slerp, o, Lerp
            transform.Rotate(0,rotation,0);
        }
    }
}
