using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace MMC_Player_2
{
    public class Folders
    {
        String title;
        String path;

        public Folders(String Title, String Path)
        {
            this.title = Title;
            this.path = Path;
        }

        public String Title
        {
            get { return title; }
        }

        public String Path
        {
            get { return path; }
        }

        public int CompareTo(Folders _Title)
        {
            return _Title == null ? 1 : Title.CompareTo(_Title.Title);
        }
    }
}
