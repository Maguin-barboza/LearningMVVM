using LearningMVVM.ViewModel;
using System.Linq;

namespace LearningMVVM.ViewModel.Commands
{
    public class DeletarCommand : BaseCommand
    {
        public override bool CanExecute(object parameter)
        {
            var viewModel = parameter as FuncionáriosViewModel;
            return viewModel != null && viewModel.FuncionárioSelecionado != null;
        }

        public override void Execute(object parameter)
        {
            var viewModel = parameter as FuncionáriosViewModel;
            viewModel.Funcionários.Remove(viewModel.FuncionárioSelecionado);
            viewModel.FuncionárioSelecionado = viewModel.Funcionários.FirstOrDefault();
        }
    }
}
