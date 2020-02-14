using System.Windows;
using LearningMVVM.ViewModel;

namespace LearningMVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public FuncionáriosViewModel FuncionáriosViewModel { get; set; } = new FuncionáriosViewModel();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
