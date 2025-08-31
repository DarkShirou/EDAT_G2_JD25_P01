using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosAleatorios
{
    public class Empleado
    {
        
        private int _intNumero;
        private string _strNombre;
        private DateTime _dtmFechaNacimiento;
        private string _strSexo;
        private char _chrGrupo;
        private double _dblSueldo;
        private bool _blnSeguroMedico;

        
        public int Numero
        {
            get { return _intNumero; }
            set { _intNumero = value; }
        }

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return _dtmFechaNacimiento; }
            set { _dtmFechaNacimiento = value; }
        }

        public string Sexo
        {
            get { return _strSexo; }
            set { _strSexo = value; }
        }

        public char Grupo
        {
            get { return _chrGrupo; }
            set { _chrGrupo = value; }
        }

        public double Sueldo
        {
            get { return _dblSueldo; }
            set { _dblSueldo = value; }
        }

        public bool SeguroMedico
        {
            get { return _blnSeguroMedico; }
            set { _blnSeguroMedico = value; }
        }

        
        public Empleado()
        {
            _intNumero = 0;
            _strNombre = "";
            _dtmFechaNacimiento = DateTime.Now;
            _strSexo = "Masculino";
            _chrGrupo = 'A';
            _dblSueldo = 0.0;
            _blnSeguroMedico = false;
        }

        
        public Empleado(int numero, string nombre, DateTime fechaNacimiento,
                       string sexo, char grupo, double sueldo, bool seguroMedico)
        {
            _intNumero = numero;
            _strNombre = nombre;
            _dtmFechaNacimiento = fechaNacimiento;
            _strSexo = sexo;
            _chrGrupo = grupo;
            _dblSueldo = sueldo;
            _blnSeguroMedico = seguroMedico;
        }

        
        public override string ToString()
        {
            return $"Empleado #{_intNumero}: {_strNombre}, {_strSexo}, " +
                   $"Nacido: {_dtmFechaNacimiento.ToShortDateString()}, " +
                   $"Grupo: {_chrGrupo}, Sueldo: ${_dblSueldo:F2}, " +
                   $"Seguro Médico: {(_blnSeguroMedico ? "Sí" : "No")}";
        }
    }
}
