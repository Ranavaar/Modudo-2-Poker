using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrayslist : MonoBehaviour
{
    ArrayList jornal = new ArrayList();



    // Start is called before the first frame update
    void Start()
    {
        jornal.Add("Ernesto: " + 1200);       
        jornal.Add("Federico: "+ 980);
        jornal.Add("Marcos: " + 1320);
        jornal.Add("Ana: " + 1260);
        jornal.Add("Maria: " + 1422.30);
        jornal.Add("Jorge: " + 1100);
        jornal.Add("Julio: " + 690);
        jornal.Add("Abraham: " + 1215.95);

        print("El tamaño es: " + jornal.Count);

        foreach (var dato in jornal)
        {

            print(dato);

        }
        if (jornal.Contains("Julio: " + 690)) // Al poner solo Julio no reconocio que estubiera en la lista, hay que poner todo los datos añadidos a la lista
        {

            print("En la lista de jornales esta Julio");

        }
        else
        {
            print("En la lista de jornales no esta Julio");
        }
 

    }

  
}
