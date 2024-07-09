using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perro2POO.Modelo
{
    internal class ClasePerro
    {
        private string codigo;
        private string nombre;
        private string raza;
        private string color;
        private string amo;
        private bool pulgas;

        public ClasePerro()
        {
        }

        public ClasePerro(string codigo, string nombre, string raza, string color, string amo, bool pulgas)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.raza = raza;
            this.color = color;
            this.amo = amo;
            this.pulgas = pulgas;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Raza { get => raza; set => raza = value; }
        public string Color { get => color; set => color = value; }
        public string Amo { get => amo; set => amo = value; }
        public bool Pulgas { get => pulgas; set => pulgas = value; }
    }
}
