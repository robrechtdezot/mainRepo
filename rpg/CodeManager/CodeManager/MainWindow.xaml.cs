using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows;

namespace CodeManager
{
    public partial class MainWindow : Window
    {
        private CodeFile selectedCodeFile;

        public MainWindow()
        {
            InitializeComponent();
            LoadCodeFiles();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string fileName = FileNameTextBox.Text;
            string codeContent = CodeContentTextBox.Text;
            
            if (!string.IsNullOrEmpty(fileName) && !string.IsNullOrEmpty(codeContent))
            {
                using (var db = new CodeManagerContext())
                {
                    var newCodeFile = new CodeFile
                    {
                        FileName = fileName,
                        CodeContent = codeContent,
                        DateAdded = DateTime.Now
                    };
                    db.CodeFiles.Add(newCodeFile);
                    db.SaveChanges();
                }

                FileNameTextBox.Clear();
                CodeContentTextBox.Clear();
                LoadCodeFiles();
            }
            else
            {
                MessageBox.Show("Please provide both file name and code content.");
            }
        }

        private void LoadCodeFiles()
        {
            using (var db = new CodeManagerContext())
            {
                var codeFiles = db.CodeFiles.OrderByDescending(c => c.DateAdded).ToList();
                CodeFileList.Items.Clear();
                foreach (var file in codeFiles)
                {
                    CodeFileList.Items.Add($"{file.FileName} - {file.DateAdded}");
                }
            }
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string searchTerm = SearchTextBox.Text;

            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Please enter a search term.");
                return;
            }

            try
            {
                using (var db = new CodeManagerContext())
                {
                    // Check if the CodeFiles table exists and is accessible
                    if (db.Database.CanConnect())
                    {
                        // Use LINQ with SQL LIKE for case-insensitive search
                        var result = db.CodeFiles
                            .Where(c => EF.Functions.Like(c.FileName, $"%{searchTerm}%"))
                            .FirstOrDefault(); // Retrieve the first match

                        if (result != null)
                        {
                            // If a match is found, display the file name and content
                            SearchResultTextBlock.Text = $"File: {result.FileName}\nCode:\n{result.CodeContent}";
                        }
                        else
                        {
                            // If no match is found
                            SearchResultTextBlock.Text = "No file found matching the search term.";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Could not connect to the database.", "Database Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Log and display the exception details
                MessageBox.Show($"An error occurred while searching for the file: {ex.Message}\n{ex.StackTrace}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CodeFileList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (CodeFileList.SelectedItem != null)
            {
                var selectedItem = CodeFileList.SelectedItem.ToString();
                string fileName = selectedItem.Split('-')[0].Trim();

                using (var db = new CodeManagerContext())
                {
                    selectedCodeFile = db.CodeFiles
                        .FirstOrDefault(c => c.FileName == fileName);

                    if (selectedCodeFile != null)
                    {
                        DeleteButton.IsEnabled = true; // Enable the delete button
                    }
                }
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (selectedCodeFile != null)
            {
                using (var db = new CodeManagerContext())
                {
                    db.CodeFiles.Remove(selectedCodeFile);
                    db.SaveChanges();
                }

                MessageBox.Show($"File '{selectedCodeFile.FileName}' deleted.");
                selectedCodeFile = null; // Clear the selection
                DeleteButton.IsEnabled = false; // Disable delete button
                LoadCodeFiles(); // Reload the list of files
            }
        }
    }
}
