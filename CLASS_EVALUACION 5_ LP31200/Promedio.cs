using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS_EVALUACION_5__LP31200
{
    public class Promedio
    {
        private string nombre;
        private int numero_cuenta;
        private int nota1;
        private int nota2;
        private int nota3;
        private int nota4;
       

        public string Nombre { get; set; }

        public long Numero_Cuenta { get; set; }

        public int Nota1 { get; set; }

        public int Nota2 { get; set; }
        public int Nota3 { get; set; }

        public int Nota4 { get; set; }
        


        public Promedio() { }
        public Promedio(string _nombre , int _numero_cuenta)
        {
            Nombre = _nombre;
            Numero_Cuenta = _numero_cuenta;


        }
        public Promedio(string _nombre, int _numero_cuenta,int _nota1, int _nota2, int _nota3, int _nota4)
        {
            Nombre = _nombre;
            Numero_Cuenta = _numero_cuenta;
            Nota1 = _nota1;
            Nota2 = _nota2;
            Nota3 = _nota3;
            Nota4 = _nota4;
            

        }


        public String CalcularPromedio()
        {
            int resultado;
           
           
            resultado =(Nota1 + Nota2 + Nota3 + Nota4) / 4;

            return "Nombre del Estudiante : " +"" + Nombre+ ""+ ""+ "Su Promedio Final es :"+ Convert.ToInt32(resultado) ;
        }


        public string Observacion()
        {
            string obs;
            int resultado;
            resultado = (Nota1 + Nota2 + Nota3 + Nota4) / 4;
            if (resultado >= 70)
            {
                obs = "ASIGNATURA APROBADO";
            }
            else
            {
                obs = "ASIGNATURA REPROBADA";
            }
            return "OBSERVACION:" + obs;

        }

       
    }
}
