using System;
//Morghan Kiverago Hangman summitive 23/04/2019
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

namespace Unit_3_summitive
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random Random = new Random(1);
        string name = "";
        int randomNumber = 0;
        string letterGuessed = " ";
        bool GameOver = false;
        

        
        
        public MainWindow()
        {
            InitializeComponent();
     
        }

        private void Click_Click(object sender, RoutedEventArgs e)
        {
          
            randomNumber = Random.Next(1, 11);//selects random number is selected between 1 and 10
            System.IO.StreamReader streamreader = new System.IO.StreamReader("Words.txt"); //reads from the txt file
            int count = 1;
            while (count != randomNumber)
            {
                string temp = streamreader.ReadLine();
                count++;
                temp = name;
            }
            string HiddenWord = "_";
            for (int i = 0; i < name.Length; i++)
            {
                HiddenWord += "_";
                lblOutput.Content = (i.ToString());
            }

        }

        private void LetterInput_Click(object sender, RoutedEventArgs e)
        {
            int Letter;
            int HiddenLetter;
            int.TryParse(txtLetter.Text, out HiddenLetter);
            if(HiddenLetter = Letter)
            {
                lblOutput.Content = Letter;
            }
            else
            {
                MessageBox.Show("WrongLetter!");
            }//this will see if the letter that was taken from the textbox is the same as any of letters in the hidden word
            //I need to figure out how to break the word up into seprate letters and be able to tell
        }
    }
   

}


;