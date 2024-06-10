using OnlineShop.Data;
using OnlineShop.Interfaces;
using OnlineShop.Models;
using System.Text;
using System.Text.RegularExpressions;

namespace OnlineShop.Service
{
    public class Service : IService
    {

        public Service()
        {
        }

        public void Print()
        {

        }

        public  string ToUrlFriendlyString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }
            
            // Замена русских букв на английские
            Dictionary<char, string> ruTranslitMap = new Dictionary<char, string>
        {
            {'а', "a"}, {'б', "b"}, {'в', "v"}, {'г', "g"}, {'д', "d"},
            {'е', "e"}, {'ё', "yo"}, {'ж', "zh"}, {'з', "z"}, {'и', "i"},
            {'й', "y"}, {'к', "k"}, {'л', "l"}, {'м', "m"}, {'н', "n"},
            {'о', "o"}, {'п', "p"}, {'р', "r"}, {'с', "s"}, {'т', "t"},
            {'у', "u"}, {'ф', "f"}, {'х', "h"}, {'ц', "ts"}, {'ч', "ch"},
            {'ш', "sh"}, {'щ', "sch"}, {'ъ', ""}, {'ы', "y"}, {'ь', ""},
            {'э', "e"}, {'ю', "yu"}, {'я', "ya"}
        };

            // Замена украинских букв на английские
            Dictionary<char, string> uaTranslitMap = new Dictionary<char, string>
        {
            {'а', "a"}, {'б', "b"}, {'в', "v"}, {'г', "h"}, {'ґ', "g"},
            {'д', "d"}, {'е', "e"}, {'є', "ye"}, {'ж', "zh"}, {'з', "z"},
            {'и', "y"}, {'і', "i"}, {'ї', "yi"}, {'й', "y"}, {'к', "k"},
            {'л', "l"}, {'м', "m"}, {'н', "n"}, {'о', "o"}, {'п', "p"},
            {'р', "r"}, {'с', "s"}, {'т', "t"}, {'у', "u"}, {'ф', "f"},
            {'х', "kh"}, {'ц', "ts"}, {'ч', "ch"}, {'ш', "sh"}, {'щ', "sch"},
            {'ь', ""}, {'ю', "yu"}, {'я', "ya"}
        };

            StringBuilder builder = new StringBuilder();

            foreach (char c in input)
            {
                // Проверка на наличие символа в таблице транслитерации
                if (ruTranslitMap.ContainsKey(c))
                {
                    builder.Append(ruTranslitMap[c]);
                }
                else if (uaTranslitMap.ContainsKey(c))
                {
                    builder.Append(uaTranslitMap[c]);
                }
                else if (char.IsLetterOrDigit(c) || c == '-' || c == '_')
                {
                    builder.Append(c); // Добавление английских букв, цифр и символов подчёркивания и дефиса без изменений
                }
                else if (char.IsWhiteSpace(c))
                {
                    builder.Append('-'); // Замена пробелов на дефисы
                }
            }

            return builder.ToString();
        }
    }
}

