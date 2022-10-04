using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoADT
{
    internal class License

    {
        //Atribtos Licencia

        public int Code { get; set; }
        public string tipo { get; set; }
        public DateOnly FechaInicio { get; set; }
        public DateOnly FechaFinal { get; set; }
        public bool estado = false;

        //Dia
        public DateOnly Dia = new DateOnly(2022, 09, 14);

        public License createLicense(string typeParameter, DateOnly initialDateParameter, DateOnly expirationDateParameter)
        {
            License licenseTuned = new License();
            licenseTuned.tipo = typeParameter;
            licenseTuned.FechaInicio = initialDateParameter;
            licenseTuned.FechaFinal = expirationDateParameter;
            if (licenseTuned.FechaFinal >= Dia)
            {
                licenseTuned.estado = true;
            }

            return licenseTuned;
        }
        public bool validA(License lic)
        {
            if (lic.FechaFinal > Dia)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
