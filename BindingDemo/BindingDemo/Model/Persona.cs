using System;
using System.Collections.Generic;
using System.Text;
using Kit.Model;

namespace BindingDemo
{
    public class Persona:ModelBase
    {
        //Variable protegida/backing field
        private string _Nombre;
        public string Nombre
        {
            get => _Nombre;
            set
            {
                this._Nombre = value;
                Raise(() => Nombre);
            }
        }

        private DateTime _FecDateTime;
        public DateTime FecNacDateTime
        {
            get => _FecDateTime;
            set
            {
                //if (value.Year <= 2003)
                //{
                    _FecDateTime = value;
                //}
                Raise(() => FecNacDateTime);
            }
        }

        public Persona()
        {
            this.FecNacDateTime=DateTime.Now;
            this.Nombre = "";
        }
    }
}
