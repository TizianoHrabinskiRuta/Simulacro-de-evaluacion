using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej1 : MonoBehaviour
{
    //Crea un programa que permita ingrtesar por inspector dos valores enteros y repsonda si son iguales o no lo son.

    public int Num1;
    public int Num2;

    // Start is called before the first frame update
    void Start()
    {
        if (Num1 == Num2) Debug.Log("Son iguales");
        else Debug.Log("No son iguales");        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
