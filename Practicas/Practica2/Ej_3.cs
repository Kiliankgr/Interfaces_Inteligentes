using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej_3 : MonoBehaviour
{
    public Vector3 moveDirection;
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        if(speed < 1) {
            speed = 1;
        }
        this.gameObject.transform.position = new Vector3 (this.gameObject.transform.position.x, 0 , this.gameObject.transform.position.z );
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(moveDirection.ToString());
        moveDirection = moveDirection * speed;
        Debug.Log(moveDirection.ToString());
        moveDirection *= Time.deltaTime;
        Debug.Log(moveDirection.ToString());
        this.gameObject.transform.Translate(moveDirection);
    }
}
