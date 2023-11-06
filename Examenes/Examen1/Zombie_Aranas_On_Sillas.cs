using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Zombie_Aranas_On_Sillas : MonoBehaviour
{
    public float desplazamientoAranas = 100f;
    GameObject [] aranas;
    GameObject [] sillas;
    void Start()
    {
        aranas = GameObject.FindGameObjectsWithTag("Aranas");
        sillas = GameObject.FindGameObjectsWithTag("Sillas");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col) {
        //Si entra en contacto con las sillas las arañas se dirigen al zombie
        
        if(col.gameObject.tag == "Sillas") {
            Vector3 direccion ;
           //acercamos arañas
            foreach (GameObject arana in aranas) {
                //Obtenemos el vector que direcciona a la silla
                direccion = this.transform.position - arana.transform.position;
                direccion = direccion.normalized;
                arana.transform.Translate(direccion.x *Time.deltaTime * desplazamientoAranas, 0, direccion.z *Time.deltaTime * desplazamientoAranas, Space.World);
            } 

        }

    }

    void OnCollisionStay(Collision col)
    {
        if(col.gameObject.tag == "Sillas") {
            Vector3 direccion ;
           //acercamos arañas
            foreach (GameObject arana in aranas) {
                //Obtenemos el vector que direcciona a la silla
                direccion = this.transform.position - arana.transform.position;
                direccion = direccion.normalized;
                arana.transform.Translate(direccion.x *Time.deltaTime * desplazamientoAranas, 0, direccion.z *Time.deltaTime * desplazamientoAranas, Space.World);
            } 

        }
    }

   
}
