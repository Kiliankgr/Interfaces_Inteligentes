using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej8 : MonoBehaviour
{
    float[] distancias;
    GameObject[] esferas;
    // Start is called before the first frame update
    void Start()
    {
        
        
        esferas = GameObject.FindGameObjectsWithTag("GrpEsf2");
        distancias = new float[esferas.Length];

        //asignamos distancias al array
        for(int i = 0 ; i < esferas.Length; i++) {

            distancias[i] = Vector3.Distance(esferas[i].transform.position, this.transform.position);
        }

        // subimos la altura de la esfera mas cercana, entendemos que solo se hace una vez
        int posEsferaCercana = 0;
        for(int i = 0 ; i < distancias.Length; i++) {

            if(distancias[posEsferaCercana] > distancias[i]) {
                posEsferaCercana = i;
            }
        }
        //subir 1 unidad
        
        esferas[posEsferaCercana].transform.position = new  Vector3( esferas[posEsferaCercana].transform.position.x, esferas[posEsferaCercana].transform.position.y + 1,esferas[posEsferaCercana].transform.position.z);
        //actualizamos la distancia
        distancias[posEsferaCercana] =  Vector3.Distance(esferas[posEsferaCercana].transform.position, this.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        /*GameObject[] esferas;
        
        int posEsferaCercana = 0;

        esferas = GameObject.FindGameObjectsWithTag("GrpEsf2");
        
        
        for(int i = 0 ; i < esferas.Length; i++) {

            if(Vector3.Distance(esferas[posEsferaCercana].transform.position, this.transform.position) > Vector3.Distance(esferas[i].transform.position, this.transform.position)) {
                posEsferaCercana = i;
            }
        }*/
        
        if ( Input.GetKeyDown(KeyCode.Space)) {
            //Recalculamos distancias(por si acaso)
            for(int i = 0 ; i < esferas.Length; i++) {

                distancias[i] = Vector3.Distance(esferas[i].transform.position, this.transform.position);
            }
            
            //obtenemos la más alejada
            int posMasAlejada= 0;
            for(int i = 0 ; i < distancias.Length; i++) {

                if(distancias[posMasAlejada] < distancias[i]) {
                    posMasAlejada = i;
                }
            }
            //cambiamos el color de la mas alejada
            Material m = esferas[posMasAlejada].GetComponent<Renderer>().material;
            
            //rgba
            m.color = new Color(Random.Range(0.0f,1.0f), Random.Range(0.0f,1.0f), Random.Range(0.0f,1.0f), 1.0f);
        }
    }
}
