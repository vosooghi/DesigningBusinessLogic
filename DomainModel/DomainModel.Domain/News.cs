using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Domain
{
    public class News
    {
        public string Title { get; private set; }
        public News(string title) { }

        public void SetTitle(string title)
        {
            if (string.IsNullOrEmpty(title)) throw new ArgumentNullException("title");
            if (title.Length < 3) throw new ArgumentException("title");
            Title = title;
        }
        public List<Keyword> keywords { get; set; }
        public List<Category> categories { get; set; }

        public void AddKeyword( Keyword keyword)
        {
            if (keywords.Count > 10) throw new ArgumentOutOfRangeException();

            keywords.Add(keyword);
        }

    }
}
