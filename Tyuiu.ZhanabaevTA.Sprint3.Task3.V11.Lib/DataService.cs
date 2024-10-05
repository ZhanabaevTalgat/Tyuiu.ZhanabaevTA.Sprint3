using tyuiu.cources.programming.interfaces.Sprint3;
using Tyuiu.ZhanabaevTA.Sprint3.Task3.V11.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint3.Task3.V11.Lib
{
    public class DataService : ISprint3Task3V11
    {
        public string ReplaceCharOnNum(string value, char replaceable, char replacement)
        {
            foreach (char c in value)
            {
                if (c == replaceable)
                {
                    value = value.Replace(replaceable, replacement);
                }    
            }

            return value;
        }
    }
}
