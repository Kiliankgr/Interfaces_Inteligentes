using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script que debera mover el cubo hacia la esfera, sin que modifique la y
public class Prct3_Ej6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Obtenemos el vector que direcciona a la esfera
        Vector3 direccion = GameObject.Find("Sphere").transform.position - this.transform.position;
        direccion = direccion.normalized;
        
        if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow)) {   
            transform.Translate(direccion.x *Time.deltaTime, 0, direccion.z *Time.deltaTime, Space.World);
        }
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)) {
            transform.Translate(direccion.x *Time.deltaTime, 0, direccion.z *Time.deltaTime, Space.World);
        }
    }
}
