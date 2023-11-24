using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5_RicardoLazo
{
    class Gerente : Empleado, IMostrarInformacion
    {
        public string Departamento { get; set; }

        public Gerente(string nombre, decimal salario, string departamento) : base(nombre, salario)
        {
            Departamento = departamento;
        }

        public new void MostrarInformacion()
        {
            // Llamada al método de la clase base para reutilizar código
            base.MostrarInformacion();
            Console.WriteLine($"Departamento: {Departamento}");
        }
    }
}
