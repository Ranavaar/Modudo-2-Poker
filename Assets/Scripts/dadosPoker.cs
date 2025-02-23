using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dadosPoker : MonoBehaviour
{  
    char[] valorDados = { '7', '8', 'J', 'Q', 'K', 'A' };
    char[] dados = new char[6];
    public int tiradas = 0;

    public bool[] seleccionDados = new bool[6];
    public bool tiraDados;
    public bool reset;


    string tiradaDados = null;




    // Start is called before the first frame update
    void Start()
    {
        tiradas = 0;
        seleccionDados = new bool[] {true, true, true, true, true, true};
        print("A jugar! Tira tus dados");
    }

    // Update is called once per frame
    void Update()
    {
        if(reset)
        {
            tiradas = 0;
            seleccionDados = new bool[] { true, true, true, true, true, true };

            reset = false;
            print("Inicie turno!");

        }
        if (tiraDados)
        {
           
            tiradas++;
            tiradaDados = null;

            for (int i = 0; i < seleccionDados.Length; i++)
            {
                if (seleccionDados[i])
                {
                    dados[i] = valorDados[Random.Range(0,5)];
                    

                }
                if(i < seleccionDados.Length - 1)
                {
                    tiradaDados += dados[i] + ",";
                }
                else
                {
                    tiradaDados += dados[i];
                }


               
            }
            print("La tirada " + tiradas + " es: " + tiradaDados);


            tiraDados = false;
        }
    }
}
