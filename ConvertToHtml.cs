using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJacob
{
    //Yhis class just converts plain text to html
    public class ConvertToHtml: IConverter
    {
        public string Convert(string plainText)
        {
            return "" + plainText + "";
        }


    }
}
