using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using BindingDemo.Annotations;
using Kit.Model;
using Xamarin.Forms;

namespace BindingDemo
{
    public class MainPageViewModel : ModelBase
    {
        private ObservableCollection<Persona> _Lista;
        public ObservableCollection<Persona> Lista
        {
            get => _Lista;
            set
            {
                _Lista = value;
                Raise(() => Lista);
            }
        }

        private Persona _Editando;

        public Persona Editando
        {
            get => _Editando;
            set
            {
                _Editando = value;
                Raise(() => Editando);
            }
        }
        public ICommand Editar { get; set; }
        public MainPageViewModel()
        {
            Lista = new ObservableCollection<Persona>();
            this.Editando = new Persona();
            this.Editar = new Command<Persona>(EditarPersona);
        }

        private void EditarPersona(Persona persona)
        {
            this.Editando = persona;
        }
    }
}
