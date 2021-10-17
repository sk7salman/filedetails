using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace Utility
{
    public class FileDetailsManager : Factory
    {
        private Factory factory = new Formatter();
        private FileDetails fileDetails = new FileDetails();
        public override string GetFileDetails(string detailstr, string path)
        {
            string result = "";
            try
            {
                var formatter = factory.GetInstance();
                var detail = formatter.RemoveSpecialCharFromString(detailstr);

                if (detail == "v" || detail == "version")
                {
                    result = fileDetails.Version(path);
                }
                if (detail == "s" || detail == "size")
                {
                    result = fileDetails.Size(path).ToString();
                }
            }
            catch (Exception ex)
            {
                result = "";
            }
            return result;

        }

        public override Factory GetInstance()
        {
            return new FileDetailsManager();
        }
    }
}
