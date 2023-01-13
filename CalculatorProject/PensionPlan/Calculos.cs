using CalculatorProject.PensionPlan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.PlanDePensiones
{
    class CalcularDesgravacion
    {
        private static float CalcularEspana(DatosDesgravar datos)
        {
            float result = 0;
            if (datos.BaseImponible < 12450)
            {
                result = datos.BaseImponible * 0.19f;
            }
            else if (datos.BaseImponible < 20200)
            {
                result = datos.BaseImponible * 0.24f;
            }
            else if (datos.BaseImponible < 35200)
            {
                result = datos.BaseImponible * 0.30f;
            }
            else if (datos.BaseImponible < 60000)
            {
                result = datos.BaseImponible * 0.37f;
            }
            else if (datos.BaseImponible < 300000)
            {
                result = datos.BaseImponible * 0.45f;
            }
            else if (datos.BaseImponible >= 300000)
            {
                result = datos.BaseImponible * 0.47f;
            }
            return result;
        }

        private static float CalcularAndorra(DatosDesgravar datos)
        {
            float result = 0;
            if (datos.BaseImponible < 24000)
            {
                result = datos.BaseImponible * 0f;
            }
            else if (datos.BaseImponible < 40000)
            {
                result = datos.BaseImponible * 0.05f;
            }
            else if (datos.BaseImponible >= 20200)
            {
                result = datos.BaseImponible * 0.1f;
            }
            return result;
        }

        public static float Calcular(DatosDesgravar datos)
        {
            float result;

            if (datos.Pais == "andorra")
            {
                result = CalcularAndorra(datos);
            }
            else
            {
                result = CalcularEspana(datos);
            }

            return result;
        }
    }
}
