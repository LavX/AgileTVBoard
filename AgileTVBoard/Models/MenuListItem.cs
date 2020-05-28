using System;
using System.Collections.Generic;
using System.Text;

namespace AgileTVBoard.Models
{
    class MenuListItem
    {
        public string Title { set; get; }
        public string IconSource { set; get; }
        public Type Target { set; get; }
    }
}
