using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prct4_Ej1 : MonoBehaviour
{
    GameObject [] esferas1;
    GameObject [] esferas2;
    // Start is called before the first frame update
    void Start()
    {
        esferas1 = GameObject.FindGameObjectsWithTag("GrpEsf1");
        esferas2 = GameObject.FindGameObjectsWithTag("GrpEsf2");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        
        if (other.gameObject.name != "Cube") {
            return;
        }
        //Primer grupo cambiamos el color
        foreach (GameObject esf in esferas1)
        {
             Material m = esf.GetComponent<Renderer>().material;
        
            //rgba
            m.color = new Color(Random.Range(0.0f,1.0f), Random.Range(0.0f,1.0f), Random.Range(0.0f,1.0f), 1.0f);
        }

        //Segundo grupo cambiamos su posicion a la del cilindro
        //Obtenemos el vector que direcciona al cilindro
        Vector3 direccion ;
        
        foreach (GameObject esf in esferas2)
        {
            //esf.gameObject.transform.position = new Vector3 (this.gameObject.transform.position.x, this.gameObject.transform.position.x , this.gameObject.transform.position.z );
            direccion=  this.transform.position - esf.transform.position;
            direccion = direccion.normalized;  
             
            esf.gameObject.transform.Translate(direccion.x *Time.deltaTime *10, direccion.x *Time.deltaTime *10, direccion.z *Time.deltaTime*10, Space.World);
            
        }
    }
}