using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptVR : MonoBehaviour
{
    // Start is called before the first frame update
    Material m;
    void Start()
    {
        m = this.GetComponent<Renderer>().material;
            
                //rgba
        m.color = new Color(Random.Range(0.0f,1.0f), Random.Range(0.0f,1.0f), Random.Range(0.0f,1.0f), 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loquesea(){
         m.color = new Color(Random.Range(0.0f,1.0f), Random.Range(0.0f,1.0f), Random.Range(0.0f,1.0f), 1.0f);
    }
}
