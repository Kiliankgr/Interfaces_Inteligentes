using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej_Posicion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Distancia entre cubo y cilindro
        Debug.Log("Distancia Cubo-Cilindro" +  Vector3.Distance(GameObject.Find("Cylinder").transform.position, GameObject.Find("Cube").transform.position));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
