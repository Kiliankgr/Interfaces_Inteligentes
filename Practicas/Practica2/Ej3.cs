using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej3 : MonoBehaviour
{
    public Vector3 v1 = new Vector3(0,0,0);
    public Vector3 v2 = new Vector3(0,0,0);
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Magnitud (V1): " + v1.magnitude);
        Debug.Log("Magnitud (V2): " + v2.magnitude);
        Debug.Log("Ángulo que forman: " + Vector3.Angle(v1,v2));
        Debug.Log("Distancia entre ambos: " + Vector3.Distance(v1,v2));
        if( v1.y > v2.y) {
            Debug.Log("Vector a mayor altura: V1" );
        } else {
            Debug.Log("Vector a mayor altura: V2" );
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
