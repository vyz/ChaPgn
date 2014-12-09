using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using mypo;

namespace myzapo
{
    public class Program
    {
        static void Main(string[] args)
        {
            string failo = Properties.Settings.Default.FiloIn;
            PgnUtil worka = new PgnUtil();
            List<vanparty> partyset = worka.FillListBoxWithDesc(PgnUtil.OpenInpFile(failo));
            failo = Properties.Settings.Default.FiloOut;
            StreamWriter wiw = new StreamWriter(failo, false, Encoding.UTF8);
            foreach (vanparty aa in partyset)
            {
                aa.RussianRegExpSymbols();
                foreach (string bb in aa.Abzatz)
                {
                    wiw.WriteLine(bb);
                }
            }
            wiw.Close();
        }
    }
}
