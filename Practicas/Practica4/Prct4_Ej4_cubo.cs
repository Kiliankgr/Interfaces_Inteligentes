using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Prct4_Ej4_cubo : MonoBehaviour
{
    GameObject [] esferas1;
    GameObject [] esferas2;
    int puntuacion;
    // Start is called before the first frame update
    void Start()
    {
        puntuacion = 0;
        esferas1 = GameObject.FindGameObjectsWithTag("GrpEsf1");
        esferas2 = GameObject.FindGameObjectsWithTag("GrpEsf2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col) {
        /*if(col.IsUnityNull()) {
            return;
        }*/
        //Debug.Log(col);
        if(col.gameObject.tag == "GrpEsf1") {
            puntuacion += 5;
            Debug.Log("Puntuación: " + puntuacion);

        } else if (col.gameObject.tag == "GrpEsf2") {
            puntuacion +=10;
            Debug.Log("Puntuación: " + puntuacion);
        }
    }

}
