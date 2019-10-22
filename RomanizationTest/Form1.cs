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
