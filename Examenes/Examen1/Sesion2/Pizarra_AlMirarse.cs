using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Pizarra_AlMirarse : MonoBehaviour
{
     public float desplazamientoAranas = 100f;
    GameObject [] aranas;
    GameObject [] sillas;
    
    Vector3[] posicionesSillas;

    GameObject zombie;
    

    // Start is called before the first frame update
    void Start()
    {
        aranas = GameObject.FindGameObjectsWithTag("Aranas");
        sillas = GameObject.FindGameObjectsWithTag("Sillas");
        zombie = GameObject.Find("Zombie");
        
        posicionesSillas = new Vector3 [sillas.Length];
        //Cogemos las posiciones iniciales de las sillas
        for ( int i = 0; i < sillas.Length;i++) {
            
            posicionesSillas[i] = sillas[i].transform.position;
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        /// <summary>
    /// This method is called by the Main Camera when it starts gazing at this GameObject.
    /// </summary>
    public void OnPointerEnter()
    {
        Debug.Log("Me miraron");
        Vector3 direccion ;
           //alejamos arañas
        foreach (GameObject arana in aranas) {
            //Obtenemos el vector que direcciona a la silla
            direccion = arana.transform.position - zombie.transform.position ;
            direccion = direccion.normalized;
            arana.transform.Translate(direccion.x *Time.deltaTime * desplazamientoAranas, 0, direccion.z *Time.deltaTime * desplazamientoAranas, Space.World);
        } 

        for ( int i = 0; i < sillas.Length;i++) {
            
            sillas[i].transform.position =posicionesSillas[i] ;
            
        }
    }

    public void OnPointerExit()
    {
        
    }

     public void OnPointerClick()
    {
        
    }
}
