using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeManager
{
        public class CodeFile
        {
            public int Id { get; set; }
            public string FileName { get; set; }
            public string CodeContent { get; set; }
            public DateTime DateAdded { get; set; }
        }

        public class CodeManagerContext : DbContext
        {
            public DbSet<CodeFile> CodeFiles { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlite("Data Source=code_manager.db");
            }
        }
    }

