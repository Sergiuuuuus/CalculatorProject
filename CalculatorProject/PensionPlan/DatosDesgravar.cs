using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.PensionPlan
{
    class DatosDesgravar
    {
        public float BaseImponible { get; set; }
        public float AportacionPersona { get; set; }
        public float AportacionEmpresa { get; set; }
        public string Pais { get; set; }
        public DatosDesgravar(float baseImponible, float aportacionPersona, float aportacionEmpresa, string pais)
        {
            BaseImponible = baseImponible;
            AportacionPersona = aportacionPersona;
            AportacionEmpresa = aportacionEmpresa;
            Pais = pais;
        }
    }
}
