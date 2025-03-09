using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_database
{
    public class DatabaseHelper
    {
     /*using System;
using System.Data.SQLite;

class Program
{
    static void Main()
    {
        string dbPath = "Data Source=code_manager.db;Version=3;";
        using (SQLiteConnection conn = new SQLiteConnection(dbPath))
        {
            conn.Open();
            string insertQuery = "INSERT INTO snippets (title, language, code) VALUES (@title, @language, @code)";
            
            using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn))
            {
                cmd.Parameters.AddWithValue("@title", "New Snippet");
                cmd.Parameters.AddWithValue("@language", "C#");
                cmd.Parameters.AddWithValue("@code", "Console.WriteLine(\"Hello from C#\");");
                cmd.ExecuteNonQuery();
            }

            Console.WriteLine("New snippet added.");
        }
    }
}
*/
    

        private static string dbPath = "Data Source=code_manager.db;Version=3;";

        public static List<CodeSnippet> GetSnippets()
        {
            List<CodeSnippet> snippets = new List<CodeSnippet>();

            using (SQLiteConnection conn = new SQLiteConnection(dbPath))
            {
                conn.Open();
                string query = "SELECT id, title, language, code FROM snippets";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            snippets.Add(new CodeSnippet
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Title = reader["title"].ToString(),
                                Language = reader["language"].ToString(),
                                Code = reader["code"].ToString()
                            });
                        }
                    }
                }
            }
            return snippets;
        }

        public static void AddSnippet(string title, string language, string code)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbPath))
            {
                conn.Open();
                string query = "INSERT INTO snippets (title, language, code) VALUES (@title, @language, @code)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@language", language);
                    cmd.Parameters.AddWithValue("@code", code);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }

    public class CodeSnippet
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }
        public string Code { get; set; }
    }

}
                

