using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Namespace1
{
    public class Variables
    {
        
        static public int experiencia = 0;
        static public int experienciaSlime = 120;
        static public int vida = 100;

        static public int Cubo(int numero)
        {
            int valor = numero * numero * numero;

            return valor;

        }

        //static public void sumarExperiencia()
        //{
        //   experiencia += experienciaSlime;


        //}
        // No se puede concatenar tipos de void en este caso

        static public int sumarExperiencia(int numero1)
        {
            int valor = numero1 + experienciaSlime;

            experiencia += valor;

            return valor;


        }

    }




}
