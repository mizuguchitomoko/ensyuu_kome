using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ensyuu_kome
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 9; i++)//*が増えるループを9回
            {
                string str = new string('*', i);//文字列*をi回繰り返す
                Console.WriteLine(str.ToString());//変数strを出力
            }
        }
    }
}
