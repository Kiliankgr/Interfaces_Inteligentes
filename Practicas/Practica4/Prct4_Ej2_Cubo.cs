using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prct4_Ej2_Cubo : MonoBehaviour
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
    void OnCollisionEnter(Collision col) {
        
        //Comprobamos si ha chocado con las sferas 1
        if(col.gameObject.tag == "GrpEsf1") {
            //aumentamos el tamaño de las esferas del grupo 2
        foreach (GameObject esf in esferas2) {
            
            esf.gameObject.transform.localScale += new Vector3(1,1,1);
             
            
        }
        } else {
            Vector3 direccion ;
            foreach (GameObject esf in esferas1) {
                
                direccion = GameObject.Find("Cylinder").transform.position - esf.transform.position;
                
                direccion = direccion.normalized;  
                
                esf.gameObject.transform.Translate(direccion.x *Time.deltaTime *10, direccion.x *Time.deltaTime *10, direccion.z *Time.deltaTime*10, Space.World);
                
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        //Por lo visto al ser el cilindro un ontriguer no responde bien al oncollision
        Vector3 direccion ;
        foreach (GameObject esf in esferas1) {
            
            direccion = GameObject.Find("Cylinder").transform.position - esf.transform.position;
            
            direccion = direccion.normalized;  
                
            esf.gameObject.transform.Translate(direccion.x *Time.deltaTime *10, direccion.x *Time.deltaTime *10, direccion.z *Time.deltaTime*10, Space.World);
            
        }
}

}
