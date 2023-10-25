using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej7_Cilindro : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.A)) {
            Material m;
            m = GetComponent<Renderer>().material;
            //rgba
            m.color = new Color(Random.Range(0.0f,1.0f), Random.Range(0.0f,1.0f), Random.Range(0.0f,1.0f), 1.0f);
        }
    }
}
