using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public abstract class Cinema
    {
        string title;

        public Cinema()
        {

        }
        public Cinema(string title)
        {
            this.Title = title;
        }

        public string Title { get => title; set => title = value; }

        //public abstract int Check(string title);

        public List<string> ShowAnnouncement()
        {
            return null;
        }
    }
}
