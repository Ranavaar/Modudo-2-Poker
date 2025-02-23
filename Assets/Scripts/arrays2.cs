using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrays2 : MonoBehaviour
{
    // Start is called before the first frame update
    
    int[,] matriz = new int[6,3];

    string filaActual = null;

    void Start()
    {
        int contador = 0;
        print("la matriz vale: ");
        for(int i = 0; i < matriz.GetLength(0); i++)
        {
            filaActual = null;
            for(int j = 0; j < matriz.GetLength(1); j++)
            {
                contador++;
                matriz[i, j] = contador;
                filaActual += contador + ", ";

            }
            print(filaActual);
        }

        
    }

}
