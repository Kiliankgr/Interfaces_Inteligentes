using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prct3_Ej10_esfera : MonoBehaviour
{
   
    Rigidbody m_Rigidbody;
    public float speed = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.W))
        {
            //Move the Rigidbody forwards constantly at speed you define (the blue arrow axis in Scene view)
            
            m_Rigidbody.AddForce(speed *Vector3.forward);
            
        }

        if (Input.GetKey(KeyCode.S))
        {
            //Move the Rigidbody backwards constantly at the speed you define (the blue arrow axis in Scene view)
            m_Rigidbody.AddForce(- speed *Vector3.forward);
        }

        if (Input.GetKey(KeyCode.D))
        {
            //Rotate the sprite about the Y axis in the positive direction
            m_Rigidbody.AddForce(speed *Vector3.right);
        }

        if (Input.GetKey(KeyCode.A))
        {
            //Rotate the sprite about the Y axis in the negative direction
            m_Rigidbody.AddForce(- speed *Vector3.right);
        }
    }
}
