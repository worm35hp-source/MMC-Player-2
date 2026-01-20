using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace MMC_Player_2
{
    public class Files : IComparable<Files>
    {
        String _FolderName;
        String _FolderPath;
        String _Artist;
        String _Title;

        public Files(String FolderName, String FolderPath)
        {
            this._FolderName = FolderName;
            this._FolderPath = FolderPath;
        }

        public String FolderName
        {
            get { return _FolderName; }
        }

        public String FolderPath
        {
            get { return _FolderPath; }
        }

        public Files(String FolderName, String FolderPath, String Artist, String Title)
        {
            this._FolderName = FolderName;
            this._FolderPath = FolderPath;
            this._Artist = Artist;
            this._Title = Title;
        }

        public String Artist
        {
            get { return _Artist; }
        }

        public String Title
        {
            get { return _Title; }
        }

        public int CompareTo(Files _FolderName)
        {
            return _FolderName == null ? 1 : FolderName.CompareTo(_FolderName.FolderName);
        }
    }
}
