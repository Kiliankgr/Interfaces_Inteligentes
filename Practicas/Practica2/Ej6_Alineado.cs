using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej6_Alineado : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = this.transform.position;

        GameObject.Find("Cylinder").transform.position = new Vector3(pos.x + 5,pos.y,pos.z);
        
        GameObject.Find("Cube").transform.position = new Vector3(pos.x - 5 ,pos.y,pos.z);
    }
}
