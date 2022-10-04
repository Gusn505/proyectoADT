using proyectoADT;

internal class Program
{
    private static void Main(string[] args)
    {
        //Carrros 
        Car che = new Car();
        che.year = new DateOnly(2017, 10, 13);
        che.brand = "Chevrolet";
        che.wheels = "The very weel";
        che.color = "Blue";
        che.description = "Lo mejor del mercado";
        che.type = "A";

        Car ELgrandre = new Car();
        ELgrandre.year = new DateOnly(2016, 07, 29);
        ELgrandre.brand = "Fate";
        ELgrandre.wheels = "The very well";
        ELgrandre.color = "Yellow";
        ELgrandre.description = "Autobus";
        ELgrandre.type = "C";

        Car TSuru = new Car();
        TSuru.year = new DateOnly(2006, 02, 04);
        TSuru.brand = "Ford";
        TSuru.wheels = "IDK";
        TSuru.color = "Blue";
        TSuru.description = "Un carro simple para muchas personas ";
        TSuru.type = "A";

        Car ferrary = new Car();
        ferrary.year = new DateOnly(2019, 05, 14);
        ferrary.brand = "Ferrary";
        ferrary.wheels = "Ferrary wheels";
        ferrary.color = "Gray";
        ferrary.description = "un carro de la mejor calidad!!!";
        ferrary.type = "A";

        Car Toyota = new Car();
        Toyota.year = new DateOnly(2021, 03, 23);
        Toyota.brand = "Toyota";
        Toyota.wheels = "Michelin";
        Toyota.color = "Red";
        Toyota.description = "Especial para las Chicas";
        Toyota.type = "A";

        Car Italika = new Car();
        Italika.year = new DateOnly(2022, 07, 24);
        Italika.brand = "Italika";
        Italika.wheels = "MOTO wheels";
        Italika.color = "Red";
        Italika.description = "La moto ideal para abram";
        Italika.type = "B";

        Car Tuneado = new Car();
        Tuneado.year = new DateOnly(2005, 07, 29);
        Tuneado.brand = "Ford";
        Tuneado.wheels = "the more cool";
        Tuneado.color = "Yellow";
        Tuneado.description = "Antigua pero poderosa";
        Tuneado.type = "A";



        //Personas 

        Person person = new Person();
        Person user1 = person.createPerson(001, "Juan", "Valenzuela", 19, "Boy");

        Person user2 = person.createPerson(002, "carlos", "manuel", 18, "boy");

        // Person user2 = person.createPerson(002,"Mora","Carlos",21,"Boy");

        // Person user3 = person.createPerson(003,"Clara","Sanchez",22,"Girl");

        // Person user4 = person.createPerson(004,"Toño","Ramirez",92,"Boy");

        // Person user5 = person.createPerson(005,"mario","Damian",18,"Boy");

        //  Person user6 = person.createPerson(006, "Vic", "Rodriges", 30, "Girl");




        //Lincensias

        License license = new License();
        License tipoAVE = license.createLicense("A", new DateOnly(2021, 05, 06), new DateOnly(2022, 05, 06));

        License TipoAVA = license.createLicense("A", new DateOnly(2021, 12, 02), new DateOnly(2022, 12, 02));

        // License B17 = license.createLicense("B", new DateOnly(2018, 12, 25), new DateOnly(2019, 12, 25));

        License C10 = license.createLicense("B", new DateOnly(2022, 08, 30), new DateOnly(2023, 12, 25));

        //Datos
        // user2.giveCar(che);
        // user6.giveCar(Toyota);
        // user6.giveCar(Italika);
        // user6.giveCar(Toyota);
        // user6.giveCar(ferrary);
        user2.giveCar(Toyota);
        user2.giveLicense(TipoAVA);


        user2.cancelCar(Toyota);

        user1.giveLicense(tipoAVE);
        user1.giveLicense(TipoAVA);
        // user4.giveLicense(A09);
        // user3.giveLicense(A14);
        // user2.giveLicense(A09);
        // user2.giveLicense(A14);
        // user6.giveLicense(C10);


        //Propiedades 
        //User 1
        Console.WriteLine("User 1");
        person.printUserData(user1);
        user1.printLicenses();
        user1.printCars();
        // Console.WriteLine("User 2");
        // person.printUserData(user2);
        // user2.printLicenses();
        // user2.printCars();
        // Console.WriteLine("User 3");
        // person.printUserData(user3);
        // user3.printLicenses();
        // user4.printCars();
        // Console.WriteLine("User 4");
        // person.printUserData(user4);
        // user4.printLicenses();
        // user4.printCars();
        // Console.WriteLine("User 5");
        // person.printUserData(user5);
        // user5.printLicenses();
        // user5.printCars();
        // Console.WriteLine("User 6");
        // person.printUserData(user6);
        // user6.printLicenses();
        // user6.printCars();

        user1.cancelCar(TSuru);

        user1.printCars();
    }
}