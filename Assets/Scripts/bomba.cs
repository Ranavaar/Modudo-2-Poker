using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomba : MonoBehaviour
{
    // Start is called before the first frame update

    public int tiempoCuenta = 0;
    float segundoActual = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        segundoActual += Time.deltaTime;
         if (segundoActual >= 1)
         {
            
            tiempoCuenta--;
            print("Tiempo restante: " +  tiempoCuenta);

            if(tiempoCuenta <= 0)
            {
                explota();

                Destroy(gameObject);
            }
            if (tiempoCuenta >= 1)
            {
                print("tic");
            }

            segundoActual = 0;

           

         }
        
    }
    void explota()
    {
        print("Boooom");

    }
}
