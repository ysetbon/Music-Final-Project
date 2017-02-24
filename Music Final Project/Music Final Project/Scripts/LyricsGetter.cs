using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace Music_Final_Project.Scripts
{
    static class LyricsGetter
    {
        public static string GetLyricsForSong(string i_SongName)
        {
            HtmlWeb web = new HtmlWeb();
            string url = "http://lyrics.wikia.com/wiki/" + Uri.EscapeUriString(i_SongName);
            HtmlDocument htmlDoc = web.Load(url);

            if (htmlDoc.ParseErrors != null && htmlDoc.ParseErrors.Count() > 0)
            {
                // Handle any parse errors as required
            }
            else
            {

                if (htmlDoc.DocumentNode != null)
                {
                    HtmlNode bodyNode = htmlDoc.DocumentNode.SelectSingleNode("//div[contains(@class, 'lyricbox')]");

                    if (bodyNode != null)
                    {
                        string target = HttpUtility.HtmlDecode(bodyNode.InnerHtml);
                        string lyricsWithTags = Regex.Replace(target, @"(<br />|<br/>|</ br>|</br>|<br>)", System.Environment.NewLine, RegexOptions.IgnoreCase);
                        return Regex.Replace(lyricsWithTags, "<.*?>", String.Empty);
                    }
                }
            }

            return "";
        }
    }
}
