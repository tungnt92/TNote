using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGhiChu.Model
{
    class GhiChu
    {
        [SQLite.PrimaryKey, SQLite.AutoIncrement]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Time { get; set; }
        public bool Complete { get; set; }
        public GhiChu()
        {
            //empty constructor  
        }
        public GhiChu(string title, string content, DateTime time)
        {
            Title = title;
            Content = content;
            Time = time;
        }
    }
}
