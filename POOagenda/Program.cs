using System;

namespace POOagenda
{
    class MainClass
    {
        // Función Menu()
        static int Menu()
        {
            int opcion = 0;
            DateTime date = new DateTime();
            date = DateTime.Now;
            Console.WriteLine("FECHA\t{0}", date);
            Console.WriteLine("\n----------------------------");
            Console.WriteLine("1. Insertar contacto");
            Console.WriteLine("2. Visualizar agenda");
            Console.WriteLine("3. Salir");
            Console.WriteLine("Escoge una opción");
            opcion = int.Parse(Console.ReadLine());

            return opcion;
        }

        // Función NuevoContacto()
        static Contacto NuevoContacto()
        {
            string nombre, ap1, ap2, telMovil;
            Console.WriteLine("Introduce el nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Introduce el primer apellido");
            ap1 = Console.ReadLine();
            Console.WriteLine("Introduce el segundo apellido");
            ap2 = Console.ReadLine();
            Console.WriteLine("Introduce el teléfono móvil");
            telMovil = Console.ReadLine();
            Contacto nuevo = new Contacto(nombre, ap1, ap2, telMovil);

            return nuevo;
        }

        // Función InsertarContacto()
        static void InsertarContacto(Contacto[] ag, ref int nTotal, Contacto nuevo)
        {
            ag[nTotal] = nuevo; // nuevo es un contacto ya creado
            nTotal++;
        }

        // Función Mostrar()
        static void Mostar(Contacto[] ag, int nTotal)
        {
            for(int i = 0; i < nTotal; i++)
            {
                Console.WriteLine("Nombre\t\tApellido1\t\tApellido2\t\tTeléfono Móvil");
                Console.WriteLine("------------------------------------------------------------------------------\n");
                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", ag[i].GetNombre(), ag[i].GetApellido1(), ag[i].GetApellido2(), ag[i].GetTelMovil());
            }
        }

        public static void Main(string[] args)
        {
            const int TAM_MAXIMO = 100;
            int numElementos = 0;
            int opcion = 0;

            // Creación del array de objetos
            Contacto[] agenda = new Contacto[TAM_MAXIMO];
            do
            {
                Console.Clear();
                opcion = Menu();
                switch (opcion)
                {
                    case 1:
                        Contacto n = NuevoContacto(); // Creación de un nuevo contacto
                        InsertarContacto(agenda, ref numElementos, n);
                        break;

                    case 2:
                        Mostar(agenda, numElementos);
                        break;

                    case 3:
                        Console.WriteLine("El programa ha finalizado.");
                        break;

                    default:
                        Console.WriteLine("Opción escogida incorrecta.");
                        break;
                }
                Console.ReadLine();
            } while (opcion != 3);
        }
    }
}










































