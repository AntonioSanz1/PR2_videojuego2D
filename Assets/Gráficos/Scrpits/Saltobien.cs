using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saltobien : MonoBehaviour
{
    public int miEdad = 27;
    public float miAltura = 4.1f;

    public string miNombre = "Antoño Ñánz";

    public bool tengoMelena = false;

    public GameObject miCubo;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    
    void Update()
    {
                Debug.Log("Hola. Mi nombre es "+miNombre+". Y tengo "+miEdad+" años"); 

    }
}
