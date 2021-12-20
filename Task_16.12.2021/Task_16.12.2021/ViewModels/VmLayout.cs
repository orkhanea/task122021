using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_16._12._2021.Models;


namespace Task_16._12._2021.ViewModels
{
    
    public class VmLayout
    {
        public List<SiteSocial> Socials { get; set; }
        public Setting Setting { get; set; }
        public List<TwitterFeed> TwitterFeeds { get; set; }
        public List<LatestArticle> LatestArticles { get; set; }
    }
}
