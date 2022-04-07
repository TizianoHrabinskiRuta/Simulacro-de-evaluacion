using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Ej2 : MonoBehaviour
{

    //Crear las variables necesarias para ingresar por inspector el precio de 3 productos y un monto de dinero disponible. 
    // Comunicar si la suma de los mismos supera o no el monto de dinero disponible. Luego indicar cuanto dinero sobra o falta. 

    public int Prod1;
    public int Prod2;
    public int Prod3;

    public float Dinero;

    // Start is called before the first frame update
    void Start()
    {
        if (Convert.ToSingle(Prod1 + Prod2 + Prod3) > Dinero)
        {
             float I =  Convert.ToSingle(Prod1 + Prod2 + Prod3) - Dinero;
            Debug.Log("Faltan: $" + I.ToString());
        }
        else
        {
            float J = Dinero - Convert.ToSingle(Prod1 + Prod2 + Prod3) ;
            Debug.Log("Sobra: $" + J.ToString());
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
