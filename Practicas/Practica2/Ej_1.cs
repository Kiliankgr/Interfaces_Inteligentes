using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej_1 : MonoBehaviour
{
    public float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)) {
            Debug.Log("Flecha arriba: " + (Input.GetAxis("Vertical")*velocidad));
        }
        if(Input.GetKey(KeyCode.DownArrow)) {
            Debug.Log("Flecha Abajo: " + (Input.GetAxis("Vertical")*velocidad));
        }
        if(Input.GetKey(KeyCode.LeftArrow)) {
            Debug.Log("Flecha Izquierda: " + (Input.GetAxis("Horizontal")*velocidad));
        }
        if(Input.GetKey(KeyCode.RightArrow)) {
            Debug.Log("Flecha Derecha: " + (Input.GetAxis("Horizontal")*velocidad));
        }

    }
}
