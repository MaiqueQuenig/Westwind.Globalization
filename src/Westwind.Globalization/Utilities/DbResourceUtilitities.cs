﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Westwind.Globalization.Utilities
{
    public class DbResourceUtils
    {
        /// <summary>
        /// Normalizes a file path to the operating system default
        /// slashes.
        /// </summary>
        /// <param name="path"></param>
        public static string NormalizePath(string path)
        {
            char slash = System.IO.Path.DirectorySeparatorChar;
            path = path.Replace('/', slash).Replace('\\', slash);
            return path;
        }
    }
}