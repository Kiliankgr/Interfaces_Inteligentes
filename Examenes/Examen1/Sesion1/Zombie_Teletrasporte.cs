using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie_Teletrasporte : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //Modificaremos la posición ignorando el eje y para poder visualizarlo más sencillo, el movimiento le pondremos un rango
    void Update()
    {
        if(Input.GetKey(KeyCode.T)) {
            this.transform.position = new Vector3(UnityEngine.Random.Range(-50f,50f),this.transform.position.y, UnityEngine.Random.Range(-50f,50f));
        }

        
    }
}
