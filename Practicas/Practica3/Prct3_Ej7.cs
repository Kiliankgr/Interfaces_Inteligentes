using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script que debera rotar el cubo hacia la esfera
public class Prct3_Ej7 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Obtenemos el vector que direcciona a la esfera
        
        if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow)) {   
            
            transform.LookAt(GameObject.Find("Sphere").transform);
        }
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)) {
            transform.LookAt(GameObject.Find("Sphere").transform);
        }
    }
}
