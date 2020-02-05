using System;
using System.Collections.Generic;
using System.Text;

namespace AreYouHappy.Models
{
    public enum MenuItemType
    {
        Introduction,
        Browse,
        About,
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
