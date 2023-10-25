using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej2_Nombre : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log(GameObject.Find("Plane").name);
        Debug.Log(GameObject.Find("Cube").name);
        Debug.Log(GameObject.Find("Sphere").name);
        Debug.Log(GameObject.Find("Cylinder").name);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
