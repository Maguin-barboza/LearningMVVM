using System;
using System.Collections.Generic;
using System.Text;

namespace LearningMVVM.Models
{
    public class Funcionário: BaseNotifyPropertyChanged, ICloneable
    {
        private int _Id;
        private string _Nome;
        private string _Sobrenome;
        private DateTime _DataNascimento;
        private Sexo _Sexo;
        private EstadoCivil _EstadoCivil;
        private DateTime _DataAdmissão;

        public int Id 
        { 
            get { return _Id; }
            set { SetField(ref _Id, value); }
        }
        public string Nome 
        {
            get { return _Nome; }
            set { SetField(ref _Nome, value); }
        }
        public string Sobrenome 
        {
            get { return _Sobrenome; }
            set { SetField(ref _Sobrenome, value); }
        }
        public DateTime DataNascimento 
        {
            get { return _DataNascimento; }
            set { SetField(ref _DataNascimento, value); } 
        }
        public Sexo Sexo 
        { 
            get { return _Sexo; } 
            set { SetField(ref _Sexo, value); } 
        }
        public EstadoCivil EstadoCivil 
        {
            get { return _EstadoCivil; }
            set { SetField(ref _EstadoCivil, value); }
        }
        public DateTime DataAdmissão 
        {
            get { return _DataAdmissão; }
            set { SetField(ref _DataAdmissão, value); }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
