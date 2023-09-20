using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace backpackwpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string FilePath;
        int W;
        int N;
        int[] wi;
        int[] ci;
        int[,] T;
        public MainWindow()
        {
            InitializeComponent();
        }
        public void AddingFile(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult) FilesList.Items.Add(openFileDialog.FileName);
            FilesList.Items.Add(openFileDialog.FileName);
            FilePath = openFileDialog.FileName;
        }
     
                private void LoadFileClick(object sender, RoutedEventArgs e)
        {
            using StreamReader reader = new StreamReader(FilesList.SelectedItem.ToString());
            BackpackTxt.Text = reader.ReadToEnd();
            
        }
        private void ReadFile()
        {
            string[] lines = File.ReadAllLines(FilePath);
            string[] separatedLine = lines[0].Split(' ');

            W = Convert.ToInt32(separatedLine[0]);

            N = Convert.ToInt32(separatedLine[1]);

            wi = new int[N + 1];

            ci = new int[N + 1];

            for (int i = 1; i < lines.Length; i++)
            {
                separatedLine = lines[i].Split(' ');

                wi[i] = Convert.ToInt32(separatedLine[0]);
                ci[i] = Convert.ToInt32(separatedLine[1]);
            }
        }
      
        private void GetMatrix()
        {
            T = new int[N + 1, W + 1];

            for (int i = 0; i <= N; i++)
            {
                for (int j = 0; j <= W; j++)
                {
                    if (i == 0 && j >= 1)
                    {
                        T[i, j] = 0;
                    }
                    if (i >= 1 && j == 0)
                    {
                        T[i, j] = 1;
                    }
                }
            }
            for (int i = 1; i <= N; i++)
            {
                for (int j = 0; j <= W; j++)
                {
                    if (j < wi[i])
                    {
                        T[i, j] = T[i - 1, j];
                    }
                    else if (j >= wi[i])
                    {
                        T[i, j] = Math.Max(T[i - 1, j], T[i - 1, j - wi[i]] + ci[i]);
                    }
                }
            }
        }
        private void PrintMatrix()
        {
            var grid = new Grid();
            for (int i = 0; i <= N; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition());
            }
            for (int j = 0; j <= W; j++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition());
            }
            var textBox1 = new TextBox();
            textBox1.BorderBrush = Brushes.Gray;
            textBox1.Background = Brushes.LightGray;
            textBox1.BorderThickness = new Thickness(1);
            textBox1.TextAlignment = TextAlignment.Center;
            Grid.SetRow(textBox1, 0);
            Grid.SetColumn(textBox1, 0);
            textBox1.Text = "i/j";
            grid.Children.Add(textBox1);
            for (int i = 1; i <= N; i++)
            {
                var textBox = new TextBox();
                textBox.BorderBrush = Brushes.Gray;
                textBox.Background = Brushes.LightGray;
                textBox.BorderThickness = new Thickness(1);
                textBox.TextAlignment = TextAlignment.Center;
                Grid.SetRow(textBox, i);
                Grid.SetColumn(textBox, 0);
                textBox.Text = i.ToString();
                grid.Children.Add(textBox);
            }
            for (int i = 1; i <= W; i++)
            {
                var textBox = new TextBox();
                textBox.BorderBrush = Brushes.Gray;
                textBox.Background = Brushes.LightGray;
                textBox.BorderThickness = new Thickness(1);
                textBox.TextAlignment = TextAlignment.Center;
                Grid.SetRow(textBox, 0);
                Grid.SetColumn(textBox, i);
                textBox.Text = i.ToString();
                grid.Children.Add(textBox);
            }
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= W; j++)
                {
                    var textBox = new TextBox();
                    textBox.BorderBrush = Brushes.Gray;
                    textBox.BorderThickness = new Thickness(1);
                    textBox.TextAlignment = TextAlignment.Center;
                    Grid.SetRow(textBox, i);
                    Grid.SetColumn(textBox, j);
                    textBox.Text = T[i, j].ToString();
                    grid.Children.Add(textBox);
                }
            }
            Matrix.Content = grid;
        }

        private void CalculateClick(object sender, RoutedEventArgs e)
        {
            ReadFile();
            GetMatrix();
            PrintMatrix();
        }

        private void BackpackTxt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
       

        private void FilesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }





}


