using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forwhile : MonoBehaviour
{
    // Start is called before the first frame update

    public int NumeroFibonacci;
    string SerieCompletaFibonacci = string.Empty;

    void Start()
    {
        CalculaNumeroFibonacci();

        //CalculaNumeroFibonacciWhile();
    }

    void CalculaNumeroFibonacciWhile()
    {
        int x1 = 0;
        int x2 = 1;
        int x3 = 0;

        int i = 0;

        while (i < NumeroFibonacci)
        {
            SerieCompletaFibonacci += x3.ToString() + ",";

            x3 = x1 + x2;
            x1 = x2;
            x2 = x3;

            i++;


        }
        print("Funcion con While: ");
        print(SerieCompletaFibonacci);

    }


    void CalculaNumeroFibonacci()
    {
        int x1 = 0;
        int x2 = 1;
        int x3 = 0;

        SerieCompletaFibonacci = "";
        
        for(int i = 0; i < NumeroFibonacci; i++)
        {
            x3 = x1 + x2;
            x1 = x2;
            x2 = x3;

            SerieCompletaFibonacci += x3.ToString() + ",";

        }
        print("Funcion con For: ");
        print(SerieCompletaFibonacci);
    }

}
