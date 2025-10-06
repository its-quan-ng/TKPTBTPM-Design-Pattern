using System.Collections.Generic;

namespace DPM225461_NguyenThiBichQuan_Real03_Page
{
    abstract class Document
    {
        private List<Page> _pages = new List<Page>();

        public Document() 
        {
            this.CreatePages();
        }

        public abstract void CreatePages();

        public List<Page> Pages
        {
            get { return _pages; }
        }
    }
}
