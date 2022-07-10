using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaibhav_assignment.Classes
{
    public class Exercise1Cls
    {
        public Exercise1Cls()
        {
        }

        public int ParseIntegerbyParseInt(object inputvalue)
        {
            if (inputvalue == null)
                return -1;

            try
            {
                int getvalue = int.Parse(inputvalue.ToString());
                return getvalue;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message.ToString());
                Console.ResetColor();
                return -1;
            }
        }

        public int ParseIntegerbyConvertInt(object inputvalue)
        {
            if (inputvalue == null)
                return -1;

            try
            {
                int getvalue = Convert.ToInt32(inputvalue.ToString());
                return getvalue;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message.ToString());
                Console.ResetColor();
                return -1;
            }
        }

        public int ParseIntegerbyTryParse(object inputvalue)
        {
            if (inputvalue == null)
                return -1;

            try
            {
                int getvalue = -1;
                int.TryParse(inputvalue.ToString(),out getvalue);
                return getvalue;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message.ToString());
                Console.ResetColor();
                return -1;
            }
        }

        public float ParseFloatbyTryParse(object inputvalue)
        {
            if (inputvalue == null)
                return -1;

            try
            {
                float getvalue = -1;
                float.TryParse(inputvalue.ToString(), out getvalue);
                return getvalue;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message.ToString());
                Console.ResetColor();
                return -1;
            }
        }

        public float ParseFloatbyParse(object inputvalue)
        {
            if (inputvalue == null)
                return -1;

            try
            {
                float getvalue = -1;
                getvalue = float.Parse(inputvalue.ToString());
                return getvalue;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message.ToString());
                Console.ResetColor();
                return -1;
            }
        }

        public bool ParseBoolbyParse(object inputvalue)
        {
            if (inputvalue == null)
                return false;

            try
            {
                bool getvalue = false;
                getvalue = bool.Parse(inputvalue.ToString());
                return getvalue;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message.ToString());
                Console.ResetColor();
                return false;
            }
        }

        public bool ParseBoolbyTryParse(object inputvalue)
        {
            if (inputvalue == null)
                return false;

            try
            {
                bool getvalue = false;
                bool.TryParse(inputvalue.ToString(),out getvalue);
                return getvalue;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message.ToString());
                Console.ResetColor();
                return false;
            }
        }

        public bool ParseBoolbyConvert(object inputvalue)
        {
            if (inputvalue == null)
                return false;

            try
            {
                bool getvalue = false;
                getvalue = Convert.ToBoolean(inputvalue.ToString());
                return getvalue;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message.ToString());
                Console.ResetColor();
                return false;
            }
        }

    }
}
