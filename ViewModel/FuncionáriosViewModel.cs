using System;
using System.Collections.ObjectModel;
using System.Linq;
using LearningMVVM.Models;
using LearningMVVM.ViewModel.Commands;

namespace LearningMVVM.ViewModel
{
    public class FuncionáriosViewModel: BaseNotifyPropertyChanged
    {
        private Funcionário _funcionárioSelecionado;
		public ObservableCollection<Funcionário> Funcionários { get; private set; }
		public DeletarCommand Deletar { get; private set; } = new DeletarCommand();
		public NovoCommand Novo { get; private set; } = new NovoCommand();
		public EditarCommand Editar { get; private set; } = new EditarCommand();

		public Funcionário FuncionárioSelecionado
		{
			get { return _funcionárioSelecionado; }
			set 
			{ 
				SetField(ref _funcionárioSelecionado, value);
				Deletar.RaiseCanExecuteChanged();
				Editar.RaiseCanExecuteChanged();
			}
		}
		

		public FuncionáriosViewModel()
		{
			Funcionários = new ObservableCollection<Funcionário>();
			Funcionários.Add(new Funcionário()
			{
				Id = 1,
				Nome = "João1",
				Sobrenome = "Das Couve",
				DataNascimento = new DateTime(1980, 01, 05),
				Sexo = Sexo.Masculino,
				EstadoCivil = EstadoCivil.Solteiro,
				DataAdmissão = new DateTime(1997, 01, 05)
			});

			FuncionárioSelecionado = Funcionários.FirstOrDefault();
		}
	}
}
