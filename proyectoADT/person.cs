using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace proyectoADT
{
    internal class Person
    {
        //Attributos de persona
        public DateOnly Diaaa = new DateOnly(2022, 09, 14);
        public int code { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public string genero { get; set; }
        List<License> ConjuntoLicencia = new List<License>();
        List<Car> conjuntoCarros = new List<Car>();
        public bool supiciousOfFraud = false;

        //Chequeo de licencia 
        public bool firstLicense = true;

        //Ultima licencia
        public DateOnly lastLicense { get; set; }
        //contar V
        private int cont = 0;
        private int coCar = 0;

        //metodos De personas, carros y licencias 
        public void receiveLicense(License licenseMethod)
        {
            ConjuntoLicencia.Add(licenseMethod);
        }
        public void receiveCar(Car carMethod)
        {
            conjuntoCarros.Add(carMethod);
        }
        public bool quitCar(Car cars)
        {
            foreach (Car vehicle in conjuntoCarros)
            {
                if (cars == vehicle)
                {
                    conjuntoCarros.Remove(cars);
                    return true;
                }

            }
            return false;
        }
        public int carCounter()
        {
            coCar = conjuntoCarros.Count;
            return coCar;
        }

        public bool validLicense()
        {
            for (int i = 0; i < ConjuntoLicencia.Count; i++)
            {
                if (Diaaa < ConjuntoLicencia[i].FechaFinal)
                {
                    return true;
                }
            }

            return false;
        }

        public bool licenseGet(string type)
        {
            for (int i = 0; i < ConjuntoLicencia.Count; i++)
            {
                if (ConjuntoLicencia[i].tipo == type)
                {

                    if (true == validLicense())
                    {
                        return true;
                    }
                }
            }
            Console.WriteLine("No tienes una licencia vigente");
            return false;
        }

        public Person createPerson(int keyCodeParameter, string NameParameter, string surNameParameter, int ageParameter, string genderParameter)
        {
            Person personTuned = new Person();
            personTuned.code = keyCodeParameter;
            personTuned.nombre = NameParameter;
            personTuned.apellido = surNameParameter;
            personTuned.edad = ageParameter;
            personTuned.genero = genderParameter;
            return personTuned;
        }


        //Printer functions
        public void printUserData(Person people)
        {
            Console.WriteLine("\n" + "Especificaciones de usurario:" + "\n");
            Console.WriteLine("Code: " + people.code + "\n" +
                "Nombre: " + people.nombre + "\n" +
                "apellido: " + people.apellido + "\n" +
                "edad: " + people.edad + "\n" +
                "Genero: " + people.genero + "\n");
        }
        public void printLicenses()
        {
            Console.WriteLine("Estas son las licencias de " + nombre + "\n");
            cont = 0;
            if (ConjuntoLicencia.Count == 0)
            {
                Console.Write("No tiene una licencia " + "\n" + "\n");
            }
            foreach (License license in ConjuntoLicencia)
            {
                cont++;
                Console.WriteLine("numero de licencia: " + cont + "\n" + "Tipo: " + license.tipo + "\n" + "Fecha de inicio: " + license.FechaInicio + "\n" + "Fecha de expiracion: " + license.FechaFinal + "\n" + "Codigo: " + license.Code + "\n");
            }
        }

        public void printCars()
        {
            Console.WriteLine("los siguientes carros son de: " + nombre + "\n");
            cont = 0;
            if (conjuntoCarros.Count == 0)
            {
                Console.Write("no tiene carros " + "\n" + "\n");
            }
            foreach (Car car in conjuntoCarros)
            {
                cont++;
                Console.WriteLine("numero de carro " + cont + "\n" + "marca: " + car.brand + "\n" + "año :" + car.year + "\n" + "llantas: " + car.wheels + "\n" + "Color: " + car.color + "\n" + "tipo de carro: " + car.type + "\n" + " descripcion: " + car.description + "\n");
            }
        }



        //Funciones
        License date = new License();

        //Dar licencias y carros
        public void giveLicense(License license)
        {
            if (edad >= 90) //verificar edad
            {
                Console.WriteLine("\n" + "No podemos entregarle la licencia por ser mayor " + "\n");
            }
            else
            {
                if (firstLicense == true)
                {
                    receiveLicense(license);
                    license.Code = code; //parametros de licencia
                    firstLicense = false;
                    lastLicense = license.FechaFinal;
                }
                else
                {
                    if (lastLicense > date.Dia) //
                    {
                        Console.WriteLine("\n" + " no puedes activar una licencia si ya la tienes vigente " + "\n");
                    }
                    else
                    {
                        receiveLicense(license);
                        lastLicense = license.FechaFinal;
                    }
                }

            }
        }

        public void giveCar(Car car)
        {
            if (genero == "Girl")
            {
                if (car.color == "Red")
                {
                    receiveCar(car);
                }
                else
                {
                    Console.WriteLine("\n" + " las Chicas no le gustan los carros de otro color que no sea rojo " + "\n");
                }
            }
            else
            {
                if (car.brand == "Ford" || car.brand == "Toyota")
                {
                    receiveCar(car);
                }
                else
                {
                    Console.WriteLine("\n" + " Los hombres prefieren ford o toyota " + "\n");
                }
            }
            if (carCounter() >= 5)
            {
                supiciousOfFraud = true;
            }
        }
        public void cancelCar(Car car)
        {
            if (car.type == "A")
            {
                //verificar si la licencia es del mismo tipo de la del carro
                if (licenseGet("A") == true)
                {
                    if (quitCar(car) == true)
                    {
                        Console.WriteLine("Carro de la marca" + car.brand + " del propietario " + nombre + " tiene que ser retirado");
                    }
                    else
                    {
                        Console.WriteLine("\n" + "el carro de la marca" + car.brand + " a nombre de " + nombre + " Tieene todo correcto" + "\n");
                    }
                }
                else
                {
                    Console.WriteLine("\n" + " no se puede cancelar" + car.brand + " sin una licencia validad" + "\n");
                }
            }
            else if (car.type == "B")
            {
                if (licenseGet("B") == true)
                {
                    if (quitCar(car) == true)
                    {
                        Console.WriteLine("\n" + "Carro de la marca " + car.brand + " del propietario " + nombre + " tiene que ser retirado" + "\n");
                    }
                    else
                    {
                        Console.WriteLine("\n" + "Carro de la marca " + car.brand + " del dueño " + nombre + " tiene todo correcto" + "\n");
                    }
                }
                else
                {
                    Console.WriteLine("\n" + " no se puede cancelar" + car.brand + " sin una licencia valida" + "\n");
                }
            }

            else if (car.type == "C")
            {
                if (licenseGet("C") == true)
                {
                    if (quitCar(car) == true)
                    {
                        Console.WriteLine("\n" + "Carro de la marca " + car.brand + " del propietario " + nombre + " tiene que ser retirado" + "\n");
                    }
                    else
                    {
                        Console.WriteLine("\n" + "Carro de la marca " + car.brand + " a nombre " + nombre + " tiene todo correcto" + "\n");
                    }
                }
                else
                {
                    Console.WriteLine("\n" + "no puedes cancelar " + car.brand + " sin una licencia valida" + "\n");
                }
            }
            else
            {
                Console.WriteLine("\n" + "No tienes un carro , saaaad" + "\n");
            }



        }
    }
}
