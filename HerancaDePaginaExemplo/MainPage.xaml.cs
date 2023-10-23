using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x416

namespace HerancaDePaginaExemplo
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class MainPage : CountValueBasePage
    {
        private int countValue;

        public int CountValue
        {
            get
            {
                return countValue;
            }
            set
            {
                countValue = value;
                OnPropertyChanged(nameof(CountValue));
            }
        }

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void CountValue_Button_Click(object sender, RoutedEventArgs e)
        {
            CountValue = CountOneValue(CountValue);
        }
        
    }
}
