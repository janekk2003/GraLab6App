using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraLab6App
{
    public partial class Start : Form
    {
        private int gridX;
        private int gridY;
        private int timeLeft;
        private Timer gameTimer;
        private TileType[,] board;
        private int foundDydelfs = 0;
        private int dydelfCount;
        private int krokodylCount;
        private int krokodyle;
        private bool gameOver = false;
        private int liczbaSzopow;

        public enum TileType
        {
            Empty,
            Dydelf,
            Szop,
            Krokodyl
        }

        public Start(int x, int y, int czas, int dydelfCount, int liczbaSzopow, int krokodyle)
        {
            InitializeComponent();
            gridX = x;
            gridY = y;
            timeLeft = czas;
            this.dydelfCount = dydelfCount;
            this.liczbaSzopow = liczbaSzopow; // inicjalizuj nowy parametr
            this.krokodylCount = krokodyle;
            board = new TileType[gridY, gridX];
            GenerateGrid();
            StartTimer();
        }

        private void GenerateGrid()
        {
            // Usuwamy wcześniej istniejące przyciski
            this.Controls.Clear();
            int buttonSize = 50;

            for (int row = 0; row < gridY; row++)
            {
                for (int col = 0; col < gridX; col++)
                {
                    Button button = new Button();
                    button.Size = new Size(buttonSize, buttonSize);
                    button.Location = new Point(col * buttonSize, row * buttonSize);
                    button.BackColor = Color.Gray;
                    button.Tag = new Point(row, col);
                    button.Click += Btn_Click;
                    this.Controls.Add(button);
                }
            }
            RandomizeAnimals();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if (gameOver) return;

            Button clickedButton = (Button)sender;
            Point position = (Point)clickedButton.Tag;
            TileType tile = board[position.X, position.Y];

            switch (tile)
            {
                case TileType.Dydelf:
                    clickedButton.BackColor = Color.Blue;
                    clickedButton.Text = "Dydelf";
                    foundDydelfs++;
                    break;
                case TileType.Szop:
                    clickedButton.BackColor = Color.Red;
                    clickedButton.Text = "Szop";
                    HandleSzop(clickedButton, position);
                    break;
                case TileType.Krokodyl:
                    {
                        clickedButton.BackColor = Color.Brown;
                        clickedButton.Text = "Krokodyl";
                        bool krokodylClickedAgain = false;

                        Timer krokodylTimer = new Timer();
                        krokodylTimer.Interval = 2000;
                        krokodylTimer.Tick += (s, ev) =>
                        {
                            if (!krokodylClickedAgain)
                            {
                                gameOver = true;
                                gameTimer.Stop();
                                MessageBox.Show("Gra zakończona porażką! Nie zareagowałeś wystarczająco szybko.");
                            }
                            ((Timer)s).Stop();
                        };

                        clickedButton.Click += (s, ev) =>
                        {
                            krokodylClickedAgain = true;
                            clickedButton.BackColor = Color.Gray;
                            clickedButton.Text = "";
                            krokodylTimer.Stop();
                        };

                        krokodylTimer.Start();
                        break;
                    }
                default:
                    clickedButton.BackColor = Color.Green;
                    clickedButton.Text = "Klikniety";
                    break;
            }

            // Sprawdzamy, czy gra zakończyła się sukcesem
            if (foundDydelfs == dydelfCount)
            {
                gameOver = true;
                gameTimer.Stop();
                MessageBox.Show("Gratulacje! Znalazles wszystkie dydelfy!");
            }
        }

        private void RandomizeAnimals()
        {
            Random rand = new Random();

            // Najpierw wyczyść planszę
            for (int row = 0; row < gridY; row++)
                for (int col = 0; col < gridX; col++)
                    board[row, col] = TileType.Empty;

            // Umieść Dydelfy
            int placed = 0;
            while (placed < dydelfCount)
            {
                int row = rand.Next(0, gridY);
                int col = rand.Next(0, gridX);
                if (board[row, col] == TileType.Empty)
                {
                    board[row, col] = TileType.Dydelf;
                    placed++;
                }
            }

            // Umieść Szopy (teraz używając poprawnej zmiennej liczbaSzopow)
            placed = 0;
            while (placed < liczbaSzopow)
            {
                int row = rand.Next(0, gridY);
                int col = rand.Next(0, gridX);
                if (board[row, col] == TileType.Empty)
                {
                    board[row, col] = TileType.Szop;
                    placed++;
                }
            }

            // Umieść Krokodyle
            placed = 0;
            while (placed < krokodylCount)
            {
                int row = rand.Next(0, gridY);
                int col = rand.Next(0, gridX);
                if (board[row, col] == TileType.Empty)
                {
                    board[row, col] = TileType.Krokodyl;
                    placed++;
                }
            }
        }


        private void StartTimer()
        {
            gameTimer = new Timer();
            gameTimer.Interval = 1000;
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
            }
            else
            {
                gameTimer.Stop();
                gameOver = true;
                MessageBox.Show("Czas uplynal! Przegrales!");
                Application.Exit();

            }
        }
        private async void HandleSzop(Button szopButton, Point position)
        {
            await Task.Delay(2000);

            int[] dx = { -1, 0, 1 };
            int[] dy = { -1, 0, 1 };

            foreach (int i in dx)
            {
                foreach (int j in dy)
                {
                    int newX = position.X + i;
                    int newY = position.Y + j;

                    if (newX >= 0 && newX < gridY && newY >= 0 && newY < gridX)
                    {
                        foreach (Control ctrl in this.Controls)
                        {
                            if (ctrl is Button btn && btn.Tag is Point pt && pt.X == newX && pt.Y == newY)
                            {
                                btn.Enabled = false;
                                btn.Text = "";
                                btn.BackColor = Color.DarkGray;
                            }
                        }
                        board[newX, newY] = TileType.Empty;
                    }
                }
            }
        }

    }
}
