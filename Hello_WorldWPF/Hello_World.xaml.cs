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
using System.Windows.Shapes;

namespace Hello_WorldWPF
{
    /// <summary>
    /// Interaction logic for Hello_World.xaml
    /// </summary>
    public partial class Hello_World : Window
    {
        public Hello_World()
        {
            InitializeComponent();
        }

        private void Add_Task_Click(object sender, RoutedEventArgs e)
        {
            listbox1.Items.Add(textbox1.Text);
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int index1 = listbox1.Items.IndexOf(listbox1.SelectedItem);
            listbox1.Items.RemoveAt(index1);
            
        }
    }
}
