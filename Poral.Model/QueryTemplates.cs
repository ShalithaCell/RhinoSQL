using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poral.Model
{
    public class QueryTemplates
    {
        public static string createMSSQLheader(string name)
        {
            return "CREATE PROCEDURE [dbo].[" + name + "]";
        }

        public static string MSSQLcreateParametrs(Tuple<string[], string[], string[], bool[]> paramListTuple)
        {
            string parametrString = string.Empty;

            for(int n = 0; n < paramListTuple.Item1.Length; n++)
            {
                string isOutput = string.Empty;
                string size = string.Empty;

                if (paramListTuple.Item4[n])
                    isOutput = "OUTPUT  ";

                if(paramListTuple.Item3[n] != string.Empty)
                {
                    size = "(" + paramListTuple.Item3[n] + ")";
                }

                if(n == paramListTuple.Item1.Length - 1)
                    parametrString += "@" + paramListTuple.Item1[n] + " " + paramListTuple.Item2 + size + " " + isOutput ;
                else
                    parametrString += "@" + paramListTuple.Item1[n] + " " + paramListTuple.Item2 + size + " " + isOutput + " ," + Environment.NewLine;

            }

            return parametrString;
        }

        public static string createMSSQLcatchPart(string procedureName)
        {
            return "BEGIN CATCH" + Environment.NewLine
                + "SET @result = 0" + Environment.NewLine
                + "declare @error int, @message varchar(4000), @xstate int;" + Environment.NewLine
                + "\tselect @error = ERROR_NUMBER(), @message = ERROR_MESSAGE(), @xstate = XACT_STATE();" + Environment.NewLine
                + "\tif @xstate = -1" + Environment.NewLine
                + "\t\trollback;" + Environment.NewLine
                + "\tif @xstate = 1 and @trancount = 0" + Environment.NewLine
                + "\t\trollback" + Environment.NewLine
                + "\tif @xstate = 1 and @trancount > 0" + Environment.NewLine
                + "\t\trollback transaction " + procedureName + "; " + Environment.NewLine + Environment.NewLine
                + "\traiserror ('" + procedureName + ": % d: %s', 16, 1, @error, @message) ;" + Environment.NewLine
                + "END CATCH" + Environment.NewLine + Environment.NewLine
                + "END";
        }
    }
}
