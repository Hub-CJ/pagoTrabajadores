using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class CEmpleado
    {
        private string nombres;
        private string categoria;
        private int tardanza;
        private int atencion;

        public string Nombres { get => nombres; set => nombres = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public int Tardanza { get => tardanza; set => tardanza = value; }
        public int Atencion { get => atencion; set => atencion = value; }
        
        public double calcularSueldo()
        {
            double sueldo = 0;
            switch (Categoria)
            {
                case "A": sueldo = 2500;break;
                case "B": sueldo = 1500;break;
                case "C": sueldo = 1000;break;
                case "D": sueldo = 900;break;
            }
            return sueldo;
        }
        public double calcularPago()
        {
            if (Tardanza > 0 || Atencion > 0)
                return calcularSueldo() - (Tardanza * 5 + Atencion * 10);
            else
                return calcularSueldo() * 1.15;
        }
    }
}
