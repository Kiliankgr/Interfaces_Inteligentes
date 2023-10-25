using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prct3_Ej4_esfera : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)) {   
            transform.Translate(Vector3.up* Input.GetAxis("Vertical") * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)) {
            transform.Translate(Vector3.right* Input.GetAxis("Horizontal") * Time.deltaTime);
        }
        //NOTA:: Al usar get axis si este resulta que se esta llamando en otro script cogera el valor del otro escript, es decir si en otro script pulsas "A" para la derecha y luego a la vez pulsas "<-" para ir a la izquierda este irá a la derecha
        
    }
}