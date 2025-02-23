using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CadenaString : MonoBehaviour
{
    public string Cadena = "Casa:400€*Coche:250€*Comida:180€*Gasolina:90€*GastosVarios:120€*SeguroAño:500€*Total:1440€";
   

    // Start is called before the first frame update
    void Start()
    {

        //for (int i = 0; i < Cadena.Length; i++)
        //{

        //    print(Cadena[i]);

        //}

        print("La comida es: " + encuentraDato(Cadena));
        print("El Total es: " + encuentraDato1(Cadena));


    }
    float encuentraDato(string DatoEntrante)
    {
        string DatoRecuperado = string.Empty;
        string Consigna = "Comida:";
        int indiceComida = 0;

        if (DatoEntrante.Contains(Consigna))
        {
            indiceComida = DatoEntrante.IndexOf(Consigna) + Consigna.Length;

            print("Si contiene Comida");

            for (int i = indiceComida; i < DatoEntrante.Length; i++)
            {
                if (DatoEntrante[i] == '*')
                {
                    break;
                }
                else
                {
                    DatoRecuperado += DatoEntrante[i];
                }


            }

            DatoRecuperado = DatoRecuperado.Replace("€", "");

            float DatoDevuelto = float.Parse(DatoRecuperado);
            //print(DatoDevuelto);

            return DatoDevuelto;

        }
        else
        {
            print("No contiene Comida");

            return 0;
        }
    }

    float encuentraDato1(string DatoEntrante)
    {
            string DatoRecuperado = string.Empty;
            string Consigna = "Total:";
            int indiceTotal = 0;

            if (DatoEntrante.Contains(Consigna))
            {
                indiceTotal = DatoEntrante.IndexOf(Consigna) + Consigna.Length;
                print("Si contiene Total");

                for (int i = indiceTotal; i < DatoEntrante.Length; i++)
                {
                    if (DatoEntrante[i] == '€')
                    {
                        break;
                    }
                    else
                    {
                        DatoRecuperado += DatoEntrante[i];
                    }


                }

                

                float DatoDevuelto = float.Parse(DatoRecuperado);
                //print(DatoDevuelto);

                return DatoDevuelto;

            }
            else
            {
                print("No contiene Total");

                return 0;
            }


    }

  
}
