using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
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
using System.Windows.Threading;

namespace WPF18
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void spasibo_Click(object sender, RoutedEventArgs e)
        {
            player.Pause();
            player.Volume = 0;
            PromptBuilder prompt = new PromptBuilder();
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            prompt.AppendText("Екатерина Сергеевна,");
            prompt.AppendText("спасибо, ", PromptEmphasis.Strong);
            prompt.AppendText("за науку!");
            synthesizer.Speak(prompt);
            player.Play();
            player.Volume = 1;
        }
    }
}
