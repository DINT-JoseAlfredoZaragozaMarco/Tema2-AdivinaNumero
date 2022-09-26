﻿using System;
using System.Collections.Generic;
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

namespace Tema2_AdivinaNumero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int Random;
        public MainWindow()
        {
            InitializeComponent();
            this.Random = GeneraNumero();
        }

        public int GeneraNumero()
        {
            Random seed = new Random();
            int numero = seed.Next(0, 101);
            return numero;
        }

        private void ComprobarNumero(object sender, RoutedEventArgs e)
        {
            if(int.Parse(valorIntroducido.Text) == this.Random){
                respuesta.Text = "Has acertado el número secreto";
            } else if(int.Parse(valorIntroducido.Text) < this.Random){
                respuesta.Text = "Te has quedado corto";
            } else {
                respuesta.Text = "Te has pasado";
            }
        }

        private void ReiniciaNumero(object sender, RoutedEventArgs e)
        {
            this.Random = GeneraNumero();
            valorIntroducido.Text = "";
            respuesta.Text =  "";
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
