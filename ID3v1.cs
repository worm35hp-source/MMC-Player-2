using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MMC_Player_2
{
    public class ID3v1
    {
        public string Track;
        public string Title;
        public string Artist;
        public string Album;
        public string Year;
        public string Genre;
        public string Comment;

        public bool GetID3v1Tag(string FileName)
        {
            try
            {
                if (File.Exists(FileName))
                {
                    FileStream fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                    StreamReader st = new StreamReader(fs);

                    if (fs != null)
                    {
                        byte[] mem = new byte[128];
                        fs.Seek(fs.Length - 128, SeekOrigin.Begin);
                        fs.Read(mem, 0, 128);

                        string header = Encoding.UTF8.GetString(mem, 0, 3);
                        if (header == "TAG")
                        {
                            Title = _1251ToUnicode(mem.Skip(3).Take(30).ToArray<byte>());
                            Artist = _1251ToUnicode(mem.Skip(33).Take(30).ToArray<byte>());
                            /*               Album = _1251ToUnicode(mem.Skip(63).Take(30).ToArray<byte>());
                                           Year = _1251ToUnicode(mem.Skip(93).Take(4).ToArray<byte>());
                                           Comment = _1251ToUnicode(mem.Skip(97).Take(28).ToArray<byte>());
                                           Track = Convert.ToByte((mem.Skip(126).Take(1).ToArray<byte>())[0]).ToString();
                                           Genre = genre[Convert.ToByte((mem.Skip(127).Take(1).ToArray<byte>())[0])];*/

                            st.Close();
                            fs.Close();
                            return true;
                        }
                    }
                    st.Close();
                    fs.Close();
                    return false;
                }
                else return false;
            }
            catch { return false; }
        }

        static string CharArrayToString(char[] ar)
        {
            try
            {
                string result = "";
                for (int i = 0; i < ar.Length; i++)
                    result += ar[i];
                return result.Trim();
            }
            catch { return ""; }
        } //CharArrayToString

        static string _1251ToUnicode(byte[] _1251)
        {
            try
            {
                char[] Unicode = new char[_1251.Length];

                for (int i = 0; i < _1251.Length; i++)
                {
                    Unicode[i] = cp1251[(uint)_1251[i]];
                }

            return CharArrayToString(Unicode);
            }
            catch { return ""; }
        }

        static char[] cp1251 =
        {
            Convert.ToChar(0x0000), Convert.ToChar(0x0001), Convert.ToChar(0x0002), Convert.ToChar(0x0003), Convert.ToChar(0x0004), Convert.ToChar(0x0005), Convert.ToChar(0x0006), Convert.ToChar(0x0007), Convert.ToChar(0x0008), Convert.ToChar(0x0009), Convert.ToChar(0x000A), Convert.ToChar(0x000B), Convert.ToChar(0x000C), Convert.ToChar(0x000D), Convert.ToChar(0x000E), Convert.ToChar(0x000F),
            Convert.ToChar(0x0010), Convert.ToChar(0x0011), Convert.ToChar(0x0012), Convert.ToChar(0x0013), Convert.ToChar(0x0014), Convert.ToChar(0x0015), Convert.ToChar(0x0016), Convert.ToChar(0x0017), Convert.ToChar(0x0018), Convert.ToChar(0x0019), Convert.ToChar(0x001A), Convert.ToChar(0x001B), Convert.ToChar(0x001C), Convert.ToChar(0x001D), Convert.ToChar(0x001E), Convert.ToChar(0x001F),
            Convert.ToChar(0x0020), Convert.ToChar(0x0021), Convert.ToChar(0x0022), Convert.ToChar(0x0023), Convert.ToChar(0x0024), Convert.ToChar(0x0025), Convert.ToChar(0x0026), Convert.ToChar(0x0027), Convert.ToChar(0x0028), Convert.ToChar(0x0029), Convert.ToChar(0x002A), Convert.ToChar(0x002B), Convert.ToChar(0x002C), Convert.ToChar(0x002D), Convert.ToChar(0x002E), Convert.ToChar(0x002F),
            Convert.ToChar(0x0030), Convert.ToChar(0x0031), Convert.ToChar(0x0032), Convert.ToChar(0x0033), Convert.ToChar(0x0034), Convert.ToChar(0x0035), Convert.ToChar(0x0036), Convert.ToChar(0x0037), Convert.ToChar(0x0038), Convert.ToChar(0x0039), Convert.ToChar(0x003A), Convert.ToChar(0x003B), Convert.ToChar(0x003C), Convert.ToChar(0x003D), Convert.ToChar(0x003E), Convert.ToChar(0x003F),
            Convert.ToChar(0x0040), Convert.ToChar(0x0041), Convert.ToChar(0x0042), Convert.ToChar(0x0043), Convert.ToChar(0x0044), Convert.ToChar(0x0045), Convert.ToChar(0x0046), Convert.ToChar(0x0047), Convert.ToChar(0x0048), Convert.ToChar(0x0049), Convert.ToChar(0x004A), Convert.ToChar(0x004B), Convert.ToChar(0x004C), Convert.ToChar(0x004D), Convert.ToChar(0x004E), Convert.ToChar(0x004F),
            Convert.ToChar(0x0050), Convert.ToChar(0x0051), Convert.ToChar(0x0052), Convert.ToChar(0x0053), Convert.ToChar(0x0054), Convert.ToChar(0x0055), Convert.ToChar(0x0056), Convert.ToChar(0x0057), Convert.ToChar(0x0058), Convert.ToChar(0x0059), Convert.ToChar(0x005A), Convert.ToChar(0x005B), Convert.ToChar(0x005C), Convert.ToChar(0x005D), Convert.ToChar(0x005E), Convert.ToChar(0x005F),
            Convert.ToChar(0x0060), Convert.ToChar(0x0061), Convert.ToChar(0x0062), Convert.ToChar(0x0063), Convert.ToChar(0x0064), Convert.ToChar(0x0065), Convert.ToChar(0x0066), Convert.ToChar(0x0067), Convert.ToChar(0x0068), Convert.ToChar(0x0069), Convert.ToChar(0x006A), Convert.ToChar(0x006B), Convert.ToChar(0x006C), Convert.ToChar(0x006D), Convert.ToChar(0x006E), Convert.ToChar(0x006F),
            Convert.ToChar(0x0070), Convert.ToChar(0x0071), Convert.ToChar(0x0072), Convert.ToChar(0x0073), Convert.ToChar(0x0074), Convert.ToChar(0x0075), Convert.ToChar(0x0076), Convert.ToChar(0x0077), Convert.ToChar(0x0078), Convert.ToChar(0x0079), Convert.ToChar(0x007A), Convert.ToChar(0x007B), Convert.ToChar(0x007C), Convert.ToChar(0x007D), Convert.ToChar(0x007E), Convert.ToChar(0x007F),

            Convert.ToChar(0x0402), Convert.ToChar(0x0403), Convert.ToChar(0x201A), Convert.ToChar(0x0453), Convert.ToChar(0x201E), Convert.ToChar(0x2026), Convert.ToChar(0x2020), Convert.ToChar(0x2021), Convert.ToChar(0x20AC), Convert.ToChar(0x2030), Convert.ToChar(0x0409), Convert.ToChar(0x2039), Convert.ToChar(0x040A), Convert.ToChar(0x040C), Convert.ToChar(0x040B), Convert.ToChar(0x040F),
            Convert.ToChar(0x0452), Convert.ToChar(0x2018), Convert.ToChar(0x2019), Convert.ToChar(0x201C), Convert.ToChar(0x201D), Convert.ToChar(0x2022), Convert.ToChar(0x2013), Convert.ToChar(0x2014), Convert.ToChar(0x0098), Convert.ToChar(0x2122), Convert.ToChar(0x0459), Convert.ToChar(0x203A), Convert.ToChar(0x045A), Convert.ToChar(0x045C), Convert.ToChar(0x045B), Convert.ToChar(0x045F),
            Convert.ToChar(0x00A0), Convert.ToChar(0x040E), Convert.ToChar(0x045E), Convert.ToChar(0x0408), Convert.ToChar(0x00A4), Convert.ToChar(0x0490), Convert.ToChar(0x00A6), Convert.ToChar(0x00A7), Convert.ToChar(0x0401), Convert.ToChar(0x00A9), Convert.ToChar(0x0404), Convert.ToChar(0x00AB), Convert.ToChar(0x00AC), Convert.ToChar(0x00AD), Convert.ToChar(0x00AE), Convert.ToChar(0x0407),
            Convert.ToChar(0x00B0), Convert.ToChar(0x00B1), Convert.ToChar(0x0406), Convert.ToChar(0x0456), Convert.ToChar(0x0491), Convert.ToChar(0x00B5), Convert.ToChar(0x00B6), Convert.ToChar(0x00B7), Convert.ToChar(0x0451), Convert.ToChar(0x2116), Convert.ToChar(0x0454), Convert.ToChar(0x00BB), Convert.ToChar(0x0458), Convert.ToChar(0x0405), Convert.ToChar(0x0455), Convert.ToChar(0x0457),
            Convert.ToChar(0x0410), Convert.ToChar(0x0411), Convert.ToChar(0x0412), Convert.ToChar(0x0413), Convert.ToChar(0x0414), Convert.ToChar(0x0415), Convert.ToChar(0x0416), Convert.ToChar(0x0417), Convert.ToChar(0x0418), Convert.ToChar(0x0419), Convert.ToChar(0x041A), Convert.ToChar(0x041B), Convert.ToChar(0x041C), Convert.ToChar(0x041D), Convert.ToChar(0x041E), Convert.ToChar(0x041F),
            Convert.ToChar(0x0420), Convert.ToChar(0x0421), Convert.ToChar(0x0422), Convert.ToChar(0x0423), Convert.ToChar(0x0424), Convert.ToChar(0x0425), Convert.ToChar(0x0426), Convert.ToChar(0x0427), Convert.ToChar(0x0428), Convert.ToChar(0x0429), Convert.ToChar(0x042A), Convert.ToChar(0x042B), Convert.ToChar(0x042C), Convert.ToChar(0x042D), Convert.ToChar(0x042E), Convert.ToChar(0x042F),
            Convert.ToChar(0x0430), Convert.ToChar(0x0431), Convert.ToChar(0x0432), Convert.ToChar(0x0433), Convert.ToChar(0x0434), Convert.ToChar(0x0435), Convert.ToChar(0x0436), Convert.ToChar(0x0437), Convert.ToChar(0x0438), Convert.ToChar(0x0439), Convert.ToChar(0x043A), Convert.ToChar(0x043B), Convert.ToChar(0x043C), Convert.ToChar(0x043D), Convert.ToChar(0x043E), Convert.ToChar(0x043F),
            Convert.ToChar(0x0440), Convert.ToChar(0x0441), Convert.ToChar(0x0442), Convert.ToChar(0x0443), Convert.ToChar(0x0444), Convert.ToChar(0x0445), Convert.ToChar(0x0446), Convert.ToChar(0x0447), Convert.ToChar(0x0448), Convert.ToChar(0x0449), Convert.ToChar(0x044A), Convert.ToChar(0x044B), Convert.ToChar(0x044C), Convert.ToChar(0x044D), Convert.ToChar(0x044E), Convert.ToChar(0x044F)
        }; // cp1251

        static string[] genre = 
        {
        "Blues",
        "Classic Rock",
        "Country",
        "Dance",
        "Disco",
        "Funk",
        "Grunge",
        "Hip-Hop",
        "Jazz",
        "Metal",
        "New Age",
        "Oldies",
        "Other",
        "Pop",
        "R&B",
        "Rap",
        "Reggae",
        "Rock",
        "Techno",
        "Industrial",
        "Alternative",
        "Ska",
        "Death Metal",
        "Pranks",
        "Soundtrack",
        "Euro-Techno",
        "Ambient",
        "Trip-Hop",
        "Vocal",
        "Jazz+Funk",
        "Fusion",
        "Trance",
        "Classical",
        "Instrumental",
        "Acid",
        "House",
        "Game",
        "Sound Clip",
        "Gospel",
        "Noise",
        "AlternRock",
        "Bass",
        "Soul",
        "Punk",
        "Space",
        "Meditative",
        "Instrumental Pop",
        "Instrumental Rock",
        "Ethnic",
        "Gothic",
        "Darkwave",
        "Techno-Industrial",
        "Electronic",
        "Pop-Folk",
        "Eurodance",
        "Dream",
        "Southern Rock",
        "Comedy",
        "Cult",
        "Gangsta",
        "Top 40",
        "Christian Rap",
        "Pop/Funk",
        "Jungle",
        "Native American",
        "Cabaret",
        "New Wave",
        "Psychedelic",
        "Rave",
        "Showtunes",
        "Trailer",
        "Lo-Fi",
        "Tribal",
        "Acid Punk",
        "Acid Jazz",
        "Polka",
        "Retro",
        "Musical",
        "Rock & Roll",
        "Hard Rock",
        "Folk",
        "Folk/Rock",
        "National Folk",
        "Swing",
        "Fast Fusion",
        "Bebob",
        "Latin",
        "Revival",
        "Celtic",
        "Bluegrass",
        "Avantgarde",
        "Gothic Rock",
        "Progressive Rock",
        "Psychedelic Rock",
        "Symphonic Rock",
        "Slow Rock",
        "Big Band",
        "Chorus",
        "Easy Listening",
        "Acoustic",
        "Humour",
        "Speech",
        "Chanson",
        "Opera",
        "Chamber Music",
        "Sonata",
        "Symphony",
        "Booty Bass",
        "Primus",
        "Porn Groove",
        "Satire",
        "Slow Jam",
        "Club",
        "Tango",
        "Samba",
        "Folklore",
        "Ballad",
        "Power Ballad",
        "Rhythmic Soul",
        "Freestyle",
        "Duet",
        "Punk Rock",
        "Drum Solo",
        "Acapella",
        "Euro-House",
        "Dance Hall",
        "Goa",
        "Drum & Bass",
        "Club-House",
        "Hardcore",
        "Terror",
        "Indie",
        "BritPop",
        "Negerpunk",
        "Polsk Punk",
        "Beat",
        "Christian Gangs",
        "Heavy Metal",
        "Black Metal",
        "Crossover",
        "Contemporary Ch?",
        "Cristian Rock",
        "Merengue",
        "Salsa",
        "Thrash Metal",
        "Anime",
        "JPop",
        "Synthpop"
        };
    }
}
