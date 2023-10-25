using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prct3_Ej3 : MonoBehaviour
{
    public Vector3 moveDirection;
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
        if(speed <= 1) {
            speed = 2;
        }
        this.gameObject.transform.position = new Vector3 (this.gameObject.transform.position.x, 0 , this.gameObject.transform.position.z );

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition;
        
        Debug.Log(moveDirection.ToString());
        newPosition = moveDirection * speed;
        
        newPosition *= Time.deltaTime;
        
        this.transform.Translate(newPosition, Space.World);
        
    }
}