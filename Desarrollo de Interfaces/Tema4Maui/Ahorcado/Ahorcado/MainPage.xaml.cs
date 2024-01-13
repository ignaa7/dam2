namespace Ahorcado
{
    public partial class MainPage : ContentPage
    {
        private ItemViewModel _itemViewModel;
        private readonly List<char> _letters = new() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        private readonly List<string> _words = new() { "patata", "investigar", "otorrinolaringologo", "elefante", "sol", "impresionante", "ordenador", "juego", "algo", "nada" };
        private string _word;
        private List<char> _guessedLetters = new();
        private int _errorsNumber;


        public MainPage()
        {
            InitializeComponent();

            _itemViewModel = new ItemViewModel();
            _itemViewModel.Letters = _letters;

            BindingContext = _itemViewModel;

            startGame();
        }

        private void startGame()
        {
            _itemViewModel.ImageUrl = "img0.png";
            _itemViewModel.Word = "";
            _itemViewModel.Message = "";
            _itemViewModel.ButtonsEnabled = true;
            _errorsNumber = 0;
            _guessedLetters.Clear();

            foreach (var child in flexLayout.Children)
            {
                if (child is Button button)
                {
                    button.IsEnabled = true;
                }
            }

            _word = _words[new Random().Next(0, _words.Count)];

            foreach (char letter in _word)
            {
                _itemViewModel.Word += "_ ";
            }
        }

        private void letterButtonPressed(object sender, EventArgs e)
        {
            Button pressedButton = (Button)sender;
            char selectedLetter = Convert.ToChar(pressedButton.Text);
            pressedButton.IsEnabled = false;

            if (_word.Contains(selectedLetter))
            {
                _guessedLetters.Add(selectedLetter);
                _itemViewModel.Word = "";

                foreach (char letter in _word)
                {
                    if (_guessedLetters.Contains(letter))
                    {
                        _itemViewModel.Word += $"{letter} ";
                    }
                    else
                    {
                        _itemViewModel.Word += "_ ";
                    }
                }

                if (!_itemViewModel.Word.Contains('_'))
                {
                    _itemViewModel.Message = "¡Has ganado!";
                    disableButtons();
                }
            }
            else
            {
                _errorsNumber++;
                _itemViewModel.ImageUrl = $"img{_errorsNumber}.png";

                if (_errorsNumber == 6)
                {
                    _itemViewModel.Message = "¡Has perdido!";
                    disableButtons();
                }
            }
        }

        private void disableButtons()
        {
            foreach (var child in flexLayout.Children)
            {
                if (child is Button button)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void resetButtonPressed(object sender, EventArgs e)
        {
            startGame();
        }
    }
}