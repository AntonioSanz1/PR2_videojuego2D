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

    public int numero1 = 10;
    public int numero2 = 80;

    public Vector3 posinicial;

    public Color miColor;

    
    public float velocidad = 0.1f;


    // Start is called before the first frame update
    void Start()
    {

        this.GetComponent<Transform>().position = posinicial;

        Vector3 posiniticonfutura = new Vector3(100,10,0);

        bool tum = true;

        tum = this.GetComponent<SpriteRenderer>().flipX;
        
        //this.GetComponent<SpriteRenderer>().color = miColor;


        

    }
    
     
    
    
        int Sumar(int numero1, int numero2)
        {
       
            int resultado = numero1+numero2;
            return resultado;
        

        }
       

    
        


    // Update is called once per frame
    
    void Update()
    {
        Debug.Log("Hola. Mi nombre es "+miNombre+". Y tengo "+miEdad+" años"); 

        /*float positionActual = this.GetComponent<Transform>().position.x; //x,y,z
        transform.position = new Vector3(1+0.1f,0,0)*/

        //transform.Translate(0,1+0.1f,0);

        //transform.Translate(velocidad,0,0);
        
        //Debug.Log(transform.rotation); quaterniones
        // euler = leer en grados 
        //Debug.Log(transform.eulerAngles);

        //transform.Rotate(0,0,velocidad);

       // transform.localScale = new Vector3(2,1,2);

        if(Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(velocidad* -1,0,0);

        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(velocidad,0,0);
        }
  

    }
    /*void OnGUI()
    {
         Debug.Log(Event.current.type.ToString());

         if(Event.current.isMouse && Event.current.button == 0)
         {
            Debug.LogFormat(Event.current.type.ToString());

         }
    }*/


}