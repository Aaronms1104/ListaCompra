using ToDoList.Models;

namespace ToDoList.Methods
{
    internal class ListFunctions
    {
        public void AddItem(ListaCompra listaCompra, String NuevoAlimento)
        {
            listaCompra.Alimentos.Add(NuevoAlimento);
            
        }

        public void RemoveItem(ListaCompra listaCompra, String AlimentoEliminado)
        {
            if (listaCompra.Alimentos.Contains(AlimentoEliminado))
            {
                int index = listaCompra.Alimentos.IndexOf(AlimentoEliminado);
                listaCompra.Alimentos.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("No existe este alimento en la lista");
            }
            
        }

        public void ShowList(ListaCompra listaCompra)
        {
            Console.WriteLine("\n---- LISTA DE LA COMPRA -----");
            listaCompra.Alimentos.ForEach(Console.WriteLine);
        }

        public void ExitList()
        {
            Console.WriteLine("\nEl programa ha finalizado con éxito, un saludo crack");
            Environment.Exit(0);
        }

        public void MostrarMensaje()
        {
            Console.WriteLine("\n¿Qué deseas hacer con tu lista?\nComandos: 'Mostrar', 'NuevoAlimento', 'EliminarAlimento', 'Salir'");
        }
    }
}
