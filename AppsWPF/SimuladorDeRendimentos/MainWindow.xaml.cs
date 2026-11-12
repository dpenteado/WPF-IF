using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SimuladorDeRendimentos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonCalculaRendimento_Click(object sender, RoutedEventArgs e)
        {
            bool v1 = decimal.TryParse(txtCapital.Text, out decimal valor1);
            bool v2 = decimal.TryParse(txtTaxaJuros.Text, out decimal valor2);
            bool v3 = decimal.TryParse(txtTempoInvestimento.Text, out decimal valor3);
            
            if (v1 && v2 && v3)
            {
                decimal rendimento = valor1 * valor2 * valor3;
                decimal montante = rendimento + valor1;
                
                txtRendimento.Text = rendimento.ToString("N2");
                txtMontante.Text = montante.ToString("N2");
            }
        }
    }
}