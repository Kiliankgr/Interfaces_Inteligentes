using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script que debera rotar el cubo hacia la esfera
public class Prct3_Ej8 : MonoBehaviour
{
    public float rotationspeed = 10;
    public float speed = 5f;
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
            
            transform.Rotate(0,rotation,0);
        }
    }
}
