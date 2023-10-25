using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Ej1Cubo : MonoBehaviour
{
    Vector3 posiciones = new Vector3();
    float rangoMin = 0;
    float rangoMax = 25;
    // Start is called before the first frame update
    void Start()
    {
        //Inicializamos con valores aleatorios
        for (int i = 0; i <= 2; i++) {
            posiciones[i] = UnityEngine.Random.Range(rangoMin, rangoMax);
            if(posiciones[i] >= 15) {
                Debug.Log("Valor del eje del Cubo: " + posiciones[i]);
            }
        }
        this.transform.position = posiciones;
    }

    // Update is called once per frame
    void Update()
    {
        //Elegir uno de los ejes de manera aletaoria
        int eje = UnityEngine.Random.Range(0,3);

        
        posiciones[eje] = UnityEngine.Random.Range(rangoMin, rangoMax);
        if(posiciones[eje] >= 15) {
            Debug.Log("Valor del eje del Cubo" + posiciones[eje]);
        }
        this.transform.position = posiciones;
        
        
    }
}
