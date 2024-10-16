namespace KostkiApp
{
    public partial class MainPage : ContentPage
    {
        private int gameScore = 0;
        private Random random = new Random();

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnRollDiceClicked(object sender, EventArgs e) // wyniki (sum, update) + obrazki
        {
            int[] results = new int[5];
            int rollSum = 0;

            // rand
            for (int i = 0; i < 5; i++)
            {
                int result = random.Next(1, 7); // 1 - 6
                results[i] = result;
                rollSum += result;
            }

            dice1.Source = $"ks{results[0]}.jpg";
            dice2.Source = $"ks{results[1]}.jpg";
            dice3.Source = $"ks{results[2]}.jpg";
            dice4.Source = $"ks{results[3]}.jpg";
            dice5.Source = $"ks{results[4]}.jpg";

            rollResultLabel.Text = $"Wynik tego losowania: {rollSum}";
            gameScore += rollSum;
            gameResultLabel.Text = $"Wynik gry: {gameScore}";
        }

        private void OnResetClicked(object sender, EventArgs e)
        {
            dice1.Source = "question.jpg";
            dice2.Source = "question.jpg";
            dice3.Source = "question.jpg";
            dice4.Source = "question.jpg";
            dice5.Source = "question.jpg";

            gameScore = 0;
            rollResultLabel.Text = "Wynik tego losowania: 0";
            gameResultLabel.Text = "Wynik gry: 0";
        }
    }
}
