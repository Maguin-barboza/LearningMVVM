using LearningMVVM.Models;
using System.Linq;
namespace LearningMVVM.ViewModel.Commands
{
    public class NovoCommand : BaseCommand
    {
        public override bool CanExecute(object parameter)
        {
            return parameter is FuncionáriosViewModel;
        }

        public override void Execute(object parameter)
        {
            var viewModel = parameter as FuncionáriosViewModel;
            var funcionário = new Funcionário();
            var maxId = 0;
            var fw = new FuncionárioWindow();

            if(viewModel.Funcionários.Any())
            {
                maxId = viewModel.Funcionários.Max(f => f.Id);
            }

            funcionário.Id = maxId + 1;
            fw.DataContext = funcionário;
            fw.ShowDialog();

            if(fw.DialogResult.HasValue && fw.DialogResult.Value)
            {
                viewModel.Funcionários.Add(funcionário);
                viewModel.FuncionárioSelecionado = funcionário;
            }
        }
    }
}
