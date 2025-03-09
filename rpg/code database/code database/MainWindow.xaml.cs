using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO.Packaging;
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

namespace code_database
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
   
        public partial class MainWindow : Window
        {
            public MainWindow()
            {
                InitializeComponent();
                LoadSnippets();
            }

            private void LoadSnippets()
            {
                List<CodeSnippet> snippets = DatabaseHelper.GetSnippets();
                SnippetsList.ItemsSource = snippets;
            }

            private void AddSnippet_Click(object sender, RoutedEventArgs e)
            {
                AddSnippetWindow addWindow = new AddSnippetWindow();
                addWindow.ShowDialog();
                LoadSnippets(); // Refresh list after adding
            }
        }
    }


        
   

