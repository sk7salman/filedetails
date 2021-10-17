using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace Utility
{
    public abstract class Factory
    {
        /// <summary>
        /// Its a method returning
        /// instance to child class 
        /// who is inheriting this abstract class
        /// </summary>
        /// <returns></returns>
        public abstract Factory GetInstance();
        /// <summary>
        /// This method is overriden in FileDetailsManager class
        /// </summary>
        /// <param name="detailstr">Coming from command line arguments -v,-s .etc</param>
        /// <param name="path">Coming from command line arguments </param>
        public virtual string GetFileDetails(string detailstr, string path) { return ""; }

        /// <summary>
        /// It will remove any special character for now 
        /// we can do specifically also
        /// </summary>
        /// <param name="str">string to format</param>
        /// <returns></returns>
        public string RemoveSpecialCharFromString(string str)
        {
            return Regex.Replace(str, @"[^0-9a-zA-Z]+", "");
        }


    }
}
