using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Prct4_Ej3_Cubo : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    GameObject [] esferas1;
    GameObject [] esferas2;
    Vector3 ultimaPosicion;
    // Start is called before the first frame update
    void Start()
    {
        esferas1 = GameObject.FindGameObjectsWithTag("GrpEsf1");
        esferas2 = GameObject.FindGameObjectsWithTag("GrpEsf2");
        ultimaPosicion = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //posicion del cilindro
        Vector3 posCilindro = GameObject.Find("Cylinder").transform.position;
        //obtenemos la distancia a la que estaba antes y la comparamos con la de ahora

        float distanciaVieja = Vector3.Distance(ultimaPosicion, posCilindro);
        float distanciaActual = Vector3.Distance(this.gameObject.transform.position, posCilindro);
        if(distanciaVieja > distanciaActual) {
            
            //esf1 cambian de color y saltan
            foreach (GameObject esf in esferas1)
            {
                Material m = esf.GetComponent<Renderer>().material;
            
                //rgba
                m.color = new Color(Random.Range(0.0f,1.0f), Random.Range(0.0f,1.0f), Random.Range(0.0f,1.0f), 1.0f);
                m_Rigidbody = esf.GetComponent<Rigidbody>();
                m_Rigidbody.AddForce(Vector3.up * 5);
            }
            //Hacemos que las sf2 miren al cilindro
            foreach (GameObject esf in esferas1)
            {
               esf.transform.LookAt(GameObject.Find("Cylinder").transform);
            }
        }
        

        

        ultimaPosicion = this.gameObject.transform.position;
    }
    void fixedUpdate() {
        Debug.Log("holi");
    }
}
