using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
public class Prct4_Ej5_cubo : MonoBehaviour
{
    GameObject [] esferas1;
    GameObject [] esferas2;
    int valor;
    public TMP_Text puntuacion;
    // Start is called before the first frame update
    void Start()
    {
        valor = 0;
        puntuacion.text = "Puntuación: 0";
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
            valor += 5;
            puntuacion.text = "Puntuación:" + valor;

        } else if (col.gameObject.tag == "GrpEsf2") {
            valor += 10;
            puntuacion.text = "Puntuación:" + valor;
        }
    }

}
