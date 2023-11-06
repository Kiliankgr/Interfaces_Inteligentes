using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Script que detectará la distancia a la que e encuentra del zombio, si es menor a distanciamin
desplazará todas las macetas aleatoriamente, y las sillas se acercarán cierta distancia
*/

public class Pizarra_Proximidad : MonoBehaviour
{
    public float distanciamin = 30f;
    public float desplazamientoSillas = 20f;
    GameObject [] macetas;
    GameObject [] sillas;
    // Start is called before the first frame update
    void Start()
    {
        macetas = GameObject.FindGameObjectsWithTag("Macetas");
        sillas = GameObject.FindGameObjectsWithTag("Sillas");
        foreach (GameObject silla in sillas) {
                
            Debug.Log("Silla:" + silla.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posZombie = GameObject.Find("Zombie").transform.position;
        float distanciaActual = Vector3.Distance(this.gameObject.transform.position, posZombie);
        if(distanciaActual < distanciamin) {
            //movemos macetas
            foreach (GameObject mac in macetas) {
                mac.transform.position = new Vector3(UnityEngine.Random.Range(-50f,50f),UnityEngine.Random.Range(0f,50f), UnityEngine.Random.Range(-50f,50f));
            }
            Vector3 direccion ;
            //acercamos sillas
            foreach (GameObject silla in sillas) {
                //Obtenemos el vector que direcciona a la silla
                direccion = posZombie - silla.transform.position;
                direccion = direccion.normalized;
                silla.transform.Translate(direccion.x *Time.deltaTime * desplazamientoSillas, 0, direccion.z *Time.deltaTime * desplazamientoSillas, Space.World);
            }
        }
        
    }
}
