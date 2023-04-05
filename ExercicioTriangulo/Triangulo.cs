using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTriangulo
{
    internal class Triangulo
    {
        


        public int lado1;
        public int lado2;
        public int lado3;
        public bool ehtriangulo = true;
        public bool isoceles, equilatero, escaleno;


        public bool VerificarSeehUmTriangulo()
        {

            if (lado1 > lado2 + lado3 || lado2 > lado1 + lado3 || lado3 > lado1 + lado2)
            {
                return false;
                
            }
            else if (lado1 < lado2 + lado3 || lado2 < lado1 + lado3 || lado3 < lado1 + lado2)
            {
                              
                return true;

            }

            return ehtriangulo;
        }

        public bool VerTipoDoTriangulo()
        {

            if (VerificarSeehUmTriangulo())
            {

                if (lado1 == lado2 && lado3 == lado1 && lado2 == lado3)
                {
                    equilatero = true;
                    return equilatero;                  
                }

                else if (lado1 != lado2 && lado2 != lado3)
                {
                    isoceles = true;
                    return isoceles;
                }

                else if (lado1 == lado2 && lado2 != lado3 || lado2 == lado3 && lado2 != lado1 || lado1 == lado3 && lado3 != lado2)
                {
                    escaleno = true;
                    return escaleno;

                }
            }
            return false;
        }
      
    }    

}




       














    

