using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leerNamespace : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {

        print("La vida es: " + Namespace1.Variables.vida + " / " + "El cubo de 3 es: " + Namespace1.Variables.Cubo(3));       

        print("Tu experiencia es: " + Namespace1.Variables.experiencia + " / " +
         "Has matado un Slime. " + " / " +
         "Ahora tu experiencia es: " + Namespace1.Variables.sumarExperiencia(0));
        //Aunque en el script he cambiado los renglones, cuando este se imprime sale todo en la misma linea    
    }

  
}
