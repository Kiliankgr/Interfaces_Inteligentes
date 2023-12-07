using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
/*
Script encargado de obtener y mostrar los valores de
Velocidad angular, Aceleración, Altitud y gravedad, Longitud y Latitud.
*/

public class ShowValues : MonoBehaviour
{


    //public TextMeshPro resultText;
    public TextMeshProUGUI resultsText;
    
    public TextMeshProUGUI resultsText2;
    public GameObject samuraiObject;
    public float velocidadRotacion = 0.5f;

    public float velocidadAdelante = 0.1f;
    float latitudReferencia = -1, longitudReferencia = -1;

    float rangoRadio = 0.00005f;
    // Start is called before the first frame update
    void Start()
    {
        //Activamos localización del dispositivo
        resultsText.text= "Velocidad angular: \nAceleración: \nAltitud: \nTrueHeading: \nLongitud: \nLatitud:";
        Input.gyro.enabled = true;
        Input.compass.enabled = true;
        Input.location.Start(5,5);   
        
    }

    // Update is called once per frame
    void Update()
    {        
        
         if (Input.location.status == LocationServiceStatus.Running) {
            //cogemos por primera vez la geolocalizacion de referencia
            if (latitudReferencia == -1) {
                latitudReferencia = Input.location.lastData.latitude;
                longitudReferencia = Input.location.lastData.longitude;
                resultsText2.text = "ZonaLimite\nRadio: "+ rangoRadio+"\nLatitud: "+ latitudReferencia.ToString("00.00000")+ "\nLongitud: "+ longitudReferencia.ToString("00.00000");
            }

            resultsText.text= "Velocidad angular: "+Input.gyro.rotationRate+
                "\nAceleración: "+Input.acceleration+ 
                "\nAltitud: "+Input.location.lastData.altitude+
                "\nTrueHeading: "+Input.compass.trueHeading+ 
                "\nLongitud: "+Input.location.lastData.longitude+
                "\nLatitud:"+Input.location.lastData.latitude;

            //Nos encargamos del samurai

            //Hacemos que avance para adelante según el grado de inclinación del movil eje z siempre que no se pase de cierto rango de latitud longitud
            
            if(latitudReferencia+rangoRadio >= Input.location.lastData.latitude && latitudReferencia-rangoRadio <= Input.location.lastData.latitude && longitudReferencia+rangoRadio >= Input.location.lastData.longitude && longitudReferencia-rangoRadio <= Input.location.lastData.longitude) {
                samuraiObject.transform.Translate(Vector3.forward * (-Input.acceleration.z) * Time.deltaTime * velocidadAdelante ,Space.Self);
            }

            //Hacemos que siempre mire al norte

            samuraiObject.transform.rotation = Quaternion.Slerp(samuraiObject.transform.rotation, Quaternion.Euler(0,-Input.compass.trueHeading,0), 0.3f); 

            
            /*Quaternion attitude = Input.gyro.attitude;
            
            rotator.rotation = attitude;
            rotator.Rotate(0f, 0f, 180f, Space.Self);
            rotator.Rotate(90f, 180f, 0f, Space.World);

            samuraiObject.transform.rotation = Quaternion.Slerp(samuraiObject.transform.rotation, rotator.rotation, velocidadRotacion);*/
        }
        
    }
}
