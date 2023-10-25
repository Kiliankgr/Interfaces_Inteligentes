using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prct3_Ej5_cubo : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow)) {   
            transform.Translate(Vector3.up* Input.GetAxis("Vertical") * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)) {
            transform.Translate(Vector3.right* Input.GetAxis("Horizontal") * Time.deltaTime);
        }
        
    }
}