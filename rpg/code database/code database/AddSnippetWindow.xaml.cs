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

namespace code_database
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    
        public partial class AddSnippetWindow : Window
        {
            public AddSnippetWindow()
            {
                InitializeComponent();
            }

            private void SaveSnippet_Click(object sender, RoutedEventArgs e)
            {
                string title = TitleBox.Text;
                string language = LanguageBox.Text;
                string code = CodeBox.Text;

                if (!string.IsNullOrWhiteSpace(title) && !string.IsNullOrWhiteSpace(language) && !string.IsNullOrWhiteSpace(code))
                {
                    DatabaseHelper.AddSnippet(title, language, code);
                    MessageBox.Show("Snippet added successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please fill all fields.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }
    }

    
