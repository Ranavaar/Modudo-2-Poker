using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrays : MonoBehaviour
{
    // Start is called before the first frame update

    double[] array1 = {1.1,1.2,1.3,1.4,1.5,1.6,1.7,1.8,1.9};
    
    string cadenaArray = string.Empty;

    void Start()
    {
        /*
        for (int i = 0; i < array1.Length; i++)
        {
            cadenaArray += array1[i] + "/ ";
            //print(array1[i]);

        }
        */

        foreach (double valor in array1)
        {
            cadenaArray += valor + "/ ";
        }

        print("El array es: " +  cadenaArray);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
