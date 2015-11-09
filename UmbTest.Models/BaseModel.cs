using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Models;

namespace UmbTest.Models
{
    public class BaseModel
    {
        public string Title { get; set; }
        public string BodyText { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public IEnumerable<MenuItem> MainNavigation { get; set; }
    }
}
