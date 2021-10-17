using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    interface IFactory
    {
         IFactory GetInstance();
        bool GetFileDetails(string detailstr, string path);
        string RemoveSpecialCharFromString(string str);
    }
}
