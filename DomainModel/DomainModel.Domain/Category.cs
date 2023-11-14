using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Domain
{
    public class Category
    {
        public string Title { get; private set; }
        public List<News> News { get; private set; }
        public Category(string title) { }

        public void SetTitle(string title)
        {
            if (string.IsNullOrEmpty(title)) throw new ArgumentNullException("title");
            if (title.Length < 3) throw new ArgumentException("title");
            Title = title;
        }
    }
}
