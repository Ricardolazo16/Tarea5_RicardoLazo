using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5_RicardoLazo
{
    interface IMostrarInformacion
    {
        void MostrarInformacion();
    }

    // Clase base Empleado
    class Empleado : IMostrarInformacion
    {
        public string Nombre { get; set; }
        public decimal Salario { get; set; }

        public Empleado(string nombre, decimal salario)
        {
            Nombre = nombre;
            Salario = salario;
        }

        public decimal CalcularSalarioAnual()
        {
            return Salario * 12;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre},\n Salario: ${Salario}, \nSalario Anual: ${CalcularSalarioAnual()}");
        }
    }
}
