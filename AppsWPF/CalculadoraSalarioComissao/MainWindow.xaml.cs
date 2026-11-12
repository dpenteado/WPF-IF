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

namespace CalculadoraSalarioComissao
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

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            decimal salario = decimal.Parse(txtSalario.Text);
            decimal vendas = decimal.Parse(txtVendas.Text);
            decimal taxaComissao = 0.03m;

            if (vendas > 1000000) taxaComissao = 0.05m;

            decimal comissao = vendas * taxaComissao;

            decimal total = salario + comissao;

            txtDetalheSalario.Text = $"{salario:C}";
            txtDetalheComissao.Text = $"Comissão ({taxaComissao * 100:N0}%): {comissao:C}";
            txtTotal.Text = $"{total:C}";
        }

        private void btnLimpar_Click(object sender, RoutedEventArgs e)
        {
            txtSalario.Clear();
            txtVendas.Clear();
            txtTotal.Text = "R$ 0,00";
            txtDetalheSalario.Text = "Salário Fixo: R$ 0,00";
            txtDetalheComissao.Text = "Comissão (0%): R$ 0,00";
        }
    }
}