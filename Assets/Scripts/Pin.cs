using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    public string pinOficial = "123456";
    public string pinUsuario = null;
    public bool aceptar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (aceptar)
        {
            print("El pin introducido es: " +  pinUsuario);

            if (pinUsuario == pinOficial)
            {
                print("El pin introducido es correcto!");
            }
            else
            {
                if (pinUsuario.Length < pinOficial.Length || pinUsuario.Length > pinOficial.Length) 
                {
                    print("El tamaño del pin debe ser de: " + pinOficial.Length);
                }
                else
                {
                    int n;
                    if (int.TryParse(pinUsuario, out n))
                    {
                        print("El pin es incorrecto");
                    }
                    else
                    {
                        print("El pin solo debe contener numeros");
                    }

                }
            }

        }
        aceptar = false;

    }
}
