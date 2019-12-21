using ListBindingExample.Model;
using System;
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

namespace ListBindingExample
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private NameCardList NameCardList {
            get => Resources["MyList"] as NameCardList;
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string inputName, inputTag;
            int inputAge;

            inputName = NameTextBox.Text;
            inputTag = TagTextBox.Text;
            try
            {
                inputAge = Convert.ToInt32(AgeTextBox.Text);
            }
            catch
            {
                inputAge = 30;
            }

            NameCardList?.Add(new Model.NameCard(inputName, inputAge, inputTag));

            NameTextBox.Text = AgeTextBox.Text = TagTextBox.Text = "";
            NameTextBox.Focus();
        }
    }
}
