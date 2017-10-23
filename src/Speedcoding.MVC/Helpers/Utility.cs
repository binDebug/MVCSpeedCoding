using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Speedcoding.MVC.Helpers
{
    public static class Utility
    {
        public static string GetImagePath(string path)
        {
            return string.Concat("images/", path);
        }
        public static string GetPropertyImagePath(string path)
        {
            return string.Concat("images/property/", path);
        }
    }
}