using CalculatorProject.PlanDePensiones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.PensionPlan
{
    class Preguntas
    {
        public static void Preguntar()
        {
            Console.WriteLine("¿Cuál es tu base imponible?");
            float baseImponible = float.Parse(Console.ReadLine());

            Console.WriteLine("¿Cuál es la aportación a tu plan de pensiones de persina físca?");
            float aportacionPersona = float.Parse(Console.ReadLine());

            Console.WriteLine("¿Cuál es la aportación a tu plan de pensiones de empresa?");
            float aportacionEmpresa = float.Parse(Console.ReadLine());

            Console.WriteLine("¿Tu plan de pensiones es en España o Andorra?");
            string pais = Console.ReadLine().ToLower();

            if (pais == "andorra" || pais == "españa")
            {
                //crear objeto DatosDesgravar
                DatosDesgravar datosDesgravar = new DatosDesgravar(baseImponible, aportacionPersona, aportacionEmpresa, pais);
                //llamar a los calculos
                float resultadoIRPF = CalcularDesgravacion.Calcular(datosDesgravar);
                Console.WriteLine("El IRPF a pagar es: " + resultadoIRPF);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Pais desconocido");
            }
        }
    }
}
