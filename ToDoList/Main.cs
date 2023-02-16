using System.Text.Json;
using ToDoList.Methods;
using ToDoList.Models;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            string Accion;
            ListFunctions Funciones = new ListFunctions();
            ListaCompra Modelo = new ListaCompra();
            StreamWriter writer = new StreamWriter(@"..\..\..\listaCompra.json");
           
            //string texto = File.ReadAllText(@"C:\Users\Aaron\source\repos\ToDoList\listaCompra.json");
            //var comprita = JsonSerializer.Deserialize<ListaCompra>(texto);
            //Console.WriteLine(texto);

            do
            {
                Funciones.MostrarMensaje();
                Accion = Console.ReadLine();
                
                switch (Accion)
                {
                    case "NuevoAlimento":
                        String NuevoAlimento;
                        Console.WriteLine("\nIntroduzca el nuevo alimento");
                        NuevoAlimento = Console.ReadLine();
                        Funciones.AddItem(Modelo, NuevoAlimento);
                        break;

                    case "EliminarAlimento":
                        String AlimentoEliminado;
                        Console.WriteLine("\nIntroduzca el alimento que quiere borrar");
                        AlimentoEliminado = Console.ReadLine();
                        Funciones.RemoveItem(Modelo, AlimentoEliminado);
                        break;

                    case "Mostrar":
                        Funciones.ShowList(Modelo);
                        break;

                    case "Salir":
                        var listaJson = JsonSerializer.Serialize(Modelo);
                        writer.WriteLine(listaJson);
                        writer.Close();
                        Funciones.ExitList();
                        break;

                    default:
                        Console.WriteLine("\nOpción incorrecta.\nPor favor seleccione un comando válido");
                        break;
                }
            } while (true);
        }
    }

}
