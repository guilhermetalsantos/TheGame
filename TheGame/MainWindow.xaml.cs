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

namespace TheGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void SetUpGame()
        {
            List<string> animalEmoji = new List<string>()
            {
                "🦍","🦍",
                "🐡","🐡",
                "🐘","🐘",
                "🐋","🐋",
                "🐪","🐪",
                "🦔","🦔",
                "🦖","🦖",
                "🦘","🦘",
            };

            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                Random random = new Random();

                int index = random.Next(animalEmoji.Count); // Count é uma propriedade da lista animalEmoji que retorna o numero total de itens presentes na lista.
                string nextEmoji = animalEmoji[index]; // animalEmoji[index] Acessa o elemento na posição index da lista animalEmoji.
                textBlock.Text = nextEmoji; // Define o texto do TextBlock atual para o emoji selecionado.
                animalEmoji.RemoveAt(index); // Remove o emoji da lista para garantir que cada emoji serja usado apenas uma vez.
            }
        }
    }
}