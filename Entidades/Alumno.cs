using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EAlumno
    {   public EAlumno()
        {
            //HOLA NO TENGO PARAMETROS
        }
        public EAlumno(string _ayn, string _dni, string _email,DateTime _fechaNac,int _id, decimal _notaAvg,int _edad)
        {
            this.ApeNom = _ayn;
            this.Dni = _dni;
            this.Email = _email;
            this.FechaNac = _fechaNac;
            this.Id = _id;
            this.NotaAvg = _notaAvg;
        }
        public string ApeNom { get; set; }
        private string Dni { get; set; }
        public string Email { get; set; }
        public DateTime FechaNac { get; set; }
        public int Id { get; set; }
        public Decimal NotaAvg { get; set; }
        public int Edad
        {
            get
            {
                DateTime hoy = DateTime.Today;
                int edad = hoy.Year - FechaNac.Year;
                if (hoy < FechaNac.AddYears(edad)) { edad--; } //todavia no los cumplió el marrano
                return edad;
            }
        }


    }
}
