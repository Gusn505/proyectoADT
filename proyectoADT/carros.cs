using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace proyectoADT
{
    internal class Car
    {
        //atributos de carros
        public DateOnly year { get; set; }
        public string brand { get; set; }
        public string description { get; set; }
        public string wheels { get; set; }
        public string color { get; set; }
        public string type { get; set; }

        public Car createCar(DateOnly date, string brandParameter, string wheelsParameter, string color, string descriptionParameter, string typeParameter)
        {
            Car carTuned = new Car();
            carTuned.year = date;
            carTuned.brand = brandParameter;
            carTuned.wheels = wheelsParameter;
            carTuned.color = color;
            carTuned.description = descriptionParameter;
            carTuned.type = typeParameter;

            return carTuned;
        }
        public void cancelCar()
        {

        }
    }
}
