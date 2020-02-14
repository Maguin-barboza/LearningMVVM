using LearningMVVM.ViewModel;

namespace LearningMVVM.ViewModel.Commands
{
    public class EditarCommand: BaseCommand
    {
        public override bool CanExecute(object parameter)
        {
            var viewModel = parameter as FuncionáriosViewModel;
            return viewModel != null && viewModel.FuncionárioSelecionado != null;
        }

        public override void Execute(object parameter)
        {
            var viewModel = parameter as FuncionáriosViewModel;
            var cloneFuncionário = viewModel.FuncionárioSelecionado.Clone() as Models.Funcionário;
            var fw = new FuncionárioWindow();
            fw.DataContext = cloneFuncionário;
            fw.ShowDialog();

            if(fw.DialogResult.HasValue && fw.DialogResult.Value)
            {
                viewModel.FuncionárioSelecionado.Nome = cloneFuncionário.Nome;
                viewModel.FuncionárioSelecionado.Sobrenome = cloneFuncionário.Sobrenome;
                viewModel.FuncionárioSelecionado.DataNascimento = cloneFuncionário.DataNascimento;
                viewModel.FuncionárioSelecionado.Sexo = cloneFuncionário.Sexo;
                viewModel.FuncionárioSelecionado.EstadoCivil = cloneFuncionário.EstadoCivil;
                viewModel.FuncionárioSelecionado.DataAdmissão = cloneFuncionário.DataAdmissão;
            }
        }
    }
}
