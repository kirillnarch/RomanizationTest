using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomanizationTest
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ГОСТ 7.79-2000/ ИСО 9:1995 - система Б
        ///http://docs.cntd.ru/document/1200113788
        ///Without diacritic signs.
        /// </summary>
        private Dictionary<string, string> _Table_ISO9 = new Dictionary<string, string>()
        {
            {"а","a" },
            {"б","b" },
            {"в","v" },
            {"г","g" },
            {"д","d" },
            {"е","e" },
            {"ё","yo" },
            {"ж","zh" },
            {"з","z" },
            {"и","i" },
            {"й","j" },
            {"к","k" },
            {"л","l" },
            {"м","m" },
            {"н","n" },
            {"о","o" },
            {"п","p" },
            {"р","r" },
            {"с","s" },
            {"т","t" },
            {"у","u" },
            {"ф","f" },
            {"х","x" },
            {"ц","cz" },
            {"ч","ch" },
            {"ш","sh" },
            {"щ","shh" },
            {"ъ","``" },
            {"ы","y" },
            {"ь","`" },
            {"э","e" },
            {"ю","yu" },
            {"я","ya" }

        };


        /// <summary>
        ///  Library of Congress and the American Library Association
        ///https://libraries.indiana.edu/cyrillic-transliteration-guide
        ///https://www.loc.gov/catdir/cpso/romanization/russian.pdf
        ///Without diacritic signs.
        /// </summary>
        private Dictionary<string, string> _Table_ALA_LC = new Dictionary<string, string>()
        {
            {"а","a" },
            {"б","b" },
            {"в","v" },
            {"г","g" },
            {"д","d" },
            {"е","e" },
            {"ё","yo" },
            {"ж","zh" },
            {"з","z" },
            {"и","i" },
            {"й","y" },
            {"к","k" },
            {"л","l" },
            {"м","m" },
            {"н","n" },
            {"о","o" },
            {"п","p" },
            {"р","r" },
            {"с","s" },
            {"т","t" },
            {"у","u" },
            {"ф","f" },
            {"х","kh" },
            {"ц","ts" },
            {"ч","ch" },
            {"ш","sh" },
            {"щ","shch" },
            {"ъ","''" },
            {"ы","y" },
            {"ь","'" },
            {"э","e" },
            {"ю","yu" },
            {"я","ya" }

        };

        /// <summary>
        /// BGN/PCGN (1944)
        ///https://en.wikipedia.org/wiki/BGN/PCGN_romanization_of_Russian
        ///https://libraries.indiana.edu/cyrillic-transliteration-guide
        ///Without diacritic signs and difference between е and ё.
        /// </summary>
        private Dictionary<string, string> _Table_BGNPCGNWithoutYo = new Dictionary<string, string>()
        {
            {"а","a" },
            {"б","b" },
            {"в","v" },
            {"г","g" },
            {"д","d" },
            {"е","e" },
            {"ё","e" },
            {"ж","zh" },
            {"з","z" },
            {"и","i" },
            {"й","y" },
            {"к","k" },
            {"л","l" },
            {"м","m" },
            {"н","n" },
            {"о","o" },
            {"п","p" },
            {"р","r" },
            {"с","s" },
            {"т","t" },
            {"у","u" },
            {"ф","f" },
            {"х","kh" },
            {"ц","ts" },
            {"ч","ch" },
            {"ш","sh" },
            {"щ","shch" },
            {"ъ","''" },
            {"ы","y" },
            {"ь","'" },
            {"э","e" },
            {"ю","yu" },
            {"я","ya" }

        };

        /// <summary>
        /// BGN/PCGN (1944)
        ///https://en.wikipedia.org/wiki/BGN/PCGN_romanization_of_Russian
        ///https://libraries.indiana.edu/cyrillic-transliteration-guide
        ///Without diacritic signs and converting ё into yo.
        /// </summary>
        private Dictionary<string, string> _Table_BGNPCGNYo = new Dictionary<string, string>()
        {
            {"а","a" },
            {"б","b" },
            {"в","v" },
            {"г","g" },
            {"д","d" },
            {"е","e" },
            {"ё","yo" },
            {"ж","zh" },
            {"з","z" },
            {"и","i" },
            {"й","y" },
            {"к","k" },
            {"л","l" },
            {"м","m" },
            {"н","n" },
            {"о","o" },
            {"п","p" },
            {"р","r" },
            {"с","s" },
            {"т","t" },
            {"у","u" },
            {"ф","f" },
            {"х","kh" },
            {"ц","ts" },
            {"ч","ch" },
            {"ш","sh" },
            {"щ","shch" },
            {"ъ","''" },
            {"ы","y" },
            {"ь","'" },
            {"э","e" },
            {"ю","yu" },
            {"я","ya" }

        };


        /// <summary>
        /// ГОСТ 16876-71 - таблица 2
        ///https://files.stroyinf.ru/Data2/1/4294835/4294835719.pdf
        ///Without diacritic signs.
        ///Переиздание январь 1981 г. с изменениями № 1, 2, утвержденными
        ///в декабре 1973 г.и в марте 1980 г. (Пост, № 1267)
        ///(МУС № 12 1973 г., НУС № 5 1980 г.)
        ///© Издательство стандартов, 1981
        /// </summary>
        private Dictionary<string, string> _Table_GOST16876_71 = new Dictionary<string, string>()
        {
            {"а","a" },
            {"б","b" },
            {"в","v" },
            {"г","g" },
            {"д","d" },
            {"е","e" },
            {"ё","jo" },
            {"ж","zh" },
            {"з","z" },
            {"и","i" },
            {"й","j" },
            {"к","k" },
            {"л","l" },
            {"м","m" },
            {"н","n" },
            {"о","o" },
            {"п","p" },
            {"р","r" },
            {"с","s" },
            {"т","t" },
            {"у","u" },
            {"ф","f" },
            {"х","kh" },
            {"ц","c" },
            {"ч","ch" },
            {"ш","sh" },
            {"щ","shh" },
            {"ъ","''" },
            {"ы","y" },
            {"ь","'" },
            {"э","eh" },
            {"ю","ju" },
            {"я","ja" }

        };


         

        /// <summary>
        /// Romanizating russian using BGN/PCGN table with taking care of ё and replacing it to yo
        /// </summary>
        /// <param name="input">Cyrillic string that would be converted</param>
        /// <returns>Converted string</returns>
        public string GetRomanizedByBGNPCGNYo(string input)
        {

            if (string.IsNullOrEmpty(input))
                return string.Empty;

            var charArray = input.ToCharArray();
            //ищем места, где ц может быть перед еийы чтобы заменить на c, в остальных случаях ц превратится в cz
            List<string> result = new List<string>();
            int i = 0;
            char previous = char.MinValue;
            foreach (var item in charArray)
            {
                if (item == 'е')
                {
                    if (i == 0)
                    {


                        result.Add("ye");

                    }
                    else
                    {
                        if ("аяиыуеэоёюйьъ".Contains(previous))
                        {
                            result.Add("ye");
                        }
                        else
                            result.Add("e");
                    }
                }



                if (_Table_BGNPCGNYo.ContainsKey(item.ToString()))
                    result.Add(_Table_BGNPCGNYo[item.ToString()]);

            }

            return String.Join(null, result);
        }


        /// <summary>
        /// Romanizating russian using BGN/PCGN table without taking care of ё and replacing it to e
        /// </summary>
        /// <param name="input">Cyrillic string that would be converted</param>
        /// <returns>Converted string</returns>
        public string GetRomanizedByBGNPCGNWithoutYo(string input)
        {
            //string source = textBox1.Text;
            //foreach (KeyValuePair<string, string> pair in words)
            //{
            //    source = source.Replace(pair.Key, pair.Value);
            //}
            //textBox2.Text = source;

            if (string.IsNullOrEmpty(input))
                return string.Empty;

            var charArray = input.ToCharArray();
            //ищем места, где ц может быть перед еийы чтобы заменить на c, в остальных случаях ц превратится в cz
            List<string> result = new List<string>();
            int i = 0;
            char previous = char.MinValue;
            foreach (var item in charArray)
            {
                if (item == 'е' || item == 'ё')
                {
                    if (i == 0)
                    {


                        result.Add("ye");

                    }
                    else
                    {
                        if ("аяиыуеэоёюйьъ".Contains(previous))
                        {
                            result.Add("ye");
                        }
                        else
                            result.Add("e");
                    }
                }


                if (_Table_BGNPCGNWithoutYo.ContainsKey(item.ToString()))
                    result.Add(_Table_BGNPCGNWithoutYo[item.ToString()]);

            }

            return String.Join(null, result);
        }

        public string GetRomanizedByGOST16876_71(string input)
        {

            foreach (KeyValuePair<string, string> pair in _Table_GOST16876_71)
            {
                input = input.Replace(pair.Key, pair.Value);
            }
            return input;
        }

        public string GetRomanizedByISO9(string input)
        {
            //string source = textBox1.Text;
            //foreach (KeyValuePair<string, string> pair in words)
            //{
            //    source = source.Replace(pair.Key, pair.Value);
            //}
            //textBox2.Text = source;

            if (string.IsNullOrEmpty(input))
                return string.Empty;

            var charArray = input.ToCharArray();
            //ищем места, где ц может быть перед еийы чтобы заменить на c, в остальных случаях ц превратится в cz
            if (input.Contains("ц"))
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == 'ц')
                    {
                        if (i != input.Length - 1)
                        {
                            if ("еиый".Contains(input[i + 1]))
                            {

                                charArray[i] = 'c';
                            }
                        }
                    }
                }

            List<string> result = new List<string>();
            foreach (var item in charArray)
            {
                if (_Table_ISO9.ContainsKey(item.ToString()))
                    result.Add(_Table_ISO9[item.ToString()]);
                else
                    result.Add(item.ToString());
            }

            return String.Join(null, result);
        }


        private Dictionary<char, List<string>> _TableRomanizationAlphabet = new Dictionary<char, List<string>>()
        {
            {'а',new List<string>(){"a"} },
            {'б',new List<string>(){"b" } },
            {'в',new List<string>(){"v"} },
            {'г',new List<string>(){"g" } },
            {'д',new List<string>(){"d" } },
            {'е',new List<string>(){"e","ye","ie","je" }},
            {'ё',new List<string>(){"yo","io", "e", "ye", "ie", "ë","je","jo", "yë" } },
            {'ж',new List<string>(){"zh", "j", "ž" } },
            {'з',new List<string>(){"z" } },
            {'и',new List<string>(){"i", "yi","y" } },
            {'й',new List<string>(){"j","jj","y", "ĭ", "i", "yi" } },
            {'к',new List<string>(){"k"} },
            {'л',new List<string>(){"l"} },
            {'м',new List<string>(){"m" } },
            {'н',new List<string>(){"n" } },
            {'о',new List<string>(){"o" } },
            {'п',new List<string>(){"p" } },
            {'р',new List<string>(){"r" } },
            {'с',new List<string>(){"s" } },
            {'т',new List<string>(){"t" } },
            {'у',new List<string>(){"u" } },
            {'ф',new List<string>(){"f","ph" } },
            {'х',new List<string>(){"ch","x","h","kh" } },
            {'ц',new List<string>(){"c","cz","ts","tc", "t͡s" } },
            {'ч',new List<string>(){"ch", "č" } },
            {'ш',new List<string>(){"š","sh" } },
            {'щ',new List<string>(){"shch","sc","shh", "ŝ", "šč","sch" } },
            {'ъ',new List<string>(){"\"", "″", "``", "'", "ie","" } },
            {'ы',new List<string>(){"y","y`","ui","ȳ","y'","i" }},
            {'ь',new List<string>(){"'", "`", "′","" } },
            {'э',new List<string>(){"eh","e", "è", "e`", "ė" } },
            {'ю',new List<string>(){"ju","yu","iu","u", "û", "i͡u" } },
            {'я',new List<string>(){"ja","ya","ia", "â", "i͡a" } }
        };
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        


        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                List<List<string>> resultList = new List<List<string>>();


                foreach (var item in textBox1.Text)
                {
                    resultList.Add(_TableRomanizationAlphabet[item]);
                }
                var result = Cartesian.CartesianProduct<string>(resultList);
                List<string> variants = new List<string>();
                foreach (var item in result)
                {
                    variants.Add(string.Join("", item));
                }
                listBox1.Items.Clear();
                foreach (var item in variants)
                {
                    listBox1.Items.Add(item);
                }
                
            }
        }
    }
    public static class Cartesian
    {
        public static IEnumerable<IEnumerable<T>> CartesianProduct<T>(this IEnumerable<IEnumerable<T>> sequences)
        {
            IEnumerable<IEnumerable<T>> emptyProduct = new[] { Enumerable.Empty<T>() };
            return sequences.Aggregate(
                emptyProduct,
                (accumulator, sequence) =>
                    from accseq in accumulator
                    from item in sequence
                    select accseq.Concat(new[] { item }));
        }
    }
}
