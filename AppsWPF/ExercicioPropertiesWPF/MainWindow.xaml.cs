using ExercicioPropertiesWPF.Models;
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
using System.Collections.ObjectModel;

namespace ExercicioPropertiesWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public ObservableCollection<Produto> Produtos { get; set; } = new();

        public MainWindow()
        {
            InitializeComponent();

            Produtos = new ObservableCollection<Produto>
            {
                new Produto(1) { Nome = "Notebook", Preco = 5600.00m, Quantidade = 6},
                new Produto(2) { Nome = "Teclado", Preco = 369.99m, Quantidade = 3}
            };

            DataContext = this;

        }

        private void btnAdicionarProduto_Click(object sender, RoutedEventArgs e)
        {

            if (!int.TryParse(txtCodigo.Text, out int codigo))
            {
                MessageBox.Show("Código inválido.");
                return;
            }
            
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("informe um produto.");
                return;
            }

            if (!decimal.TryParse(txtPreco.Text, out decimal preco))
            {
                MessageBox.Show("Preço inválido.");
                return;
            }

            if (!int.TryParse(txtQuantidade.Text, out int quantidade))
            {
                MessageBox.Show("Quantidade inválida.");
                return;
            }

            Produtos.Add(new Produto(codigo)
            {
                Nome = txtNome.Text.Trim(),
                Preco = preco,
                Quantidade = quantidade
            });

            btnLimparCampos_Click(sender, e);
        }

        private void btnLimparCampos_Click(object sender, RoutedEventArgs e)
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtPreco.Clear();
            txtQuantidade.Clear();
        }

        private void btnDeletarItem_Click(object sender, RoutedEventArgs e)
        {
            if (dgProdutos.SelectedItem == null)
            {
                MessageBox.Show("Selecione o produto que deseja excluir.");
                return;
            }

            Produto produtoSelecionado = (Produto)dgProdutos.SelectedItem;

            Produtos.Remove(produtoSelecionado);
        }

    }
}