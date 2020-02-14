using System;
using System.Windows;
using LearningMVVM.Models;
using System.Linq;

namespace LearningMVVM
{
    /// <summary>
    /// Lógica interna para FuncionárioWindow.xaml
    /// </summary>
    public partial class FuncionárioWindow : Window
    {
        public FuncionárioWindow()
        {
            InitializeComponent();
            SexoComboBox.ItemsSource = Enum.GetValues(typeof(Sexo)).Cast<Sexo>();
            EstadoCivilComboBox.ItemsSource = Enum.GetValues(typeof(EstadoCivil)).Cast<EstadoCivil>();
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
