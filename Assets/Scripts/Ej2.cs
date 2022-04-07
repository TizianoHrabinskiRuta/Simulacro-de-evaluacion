using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Ej2 : MonoBehaviour
{

    //Crear las variables necesarias para ingresar por inspector el precio de 3 productos y un monto de dinero disponible. 
    // Comunicar si la suma de los mismos supera o no el monto de dinero disponible. Luego indicar cuanto dinero sobra o falta. 

    public int Producto1;
    public int Producto2;
    public int Producto3;

    public float Dinero;

    // Start is called before the first frame update
    void Start()
    {
        if (Convert.ToSingle(Producto1 + Producto2 + Producto3) > Dinero)
        {
             float I =  Convert.ToSingle(Producto1 + Producto2 + Producto3) - Dinero;
            Debug.Log("Faltan: $" + I.ToString());
        }
        else
        {
            float J = Dinero - Convert.ToSingle(Producto1 + Producto2 + Producto3) ;
            Debug.Log("Sobra: $" + J.ToString());
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
