using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using mypo;

namespace myzapo {
    public class mano {
        
        public mano() {
            }

        /// <summary>
        /// 
        /// Модификация от 16 декабря 2014 года
        /// Заложен 16 декабря 2014 года
        /// </summary>
        /// <param name="filein"></param>
        /// <param name="fileout"></param>
        public void ConvertVanFile(string filein, string fileout) {
            PgnUtil worka = new PgnUtil();
            List<vanparty> partyset = worka.FillListBoxWithDesc(PgnUtil.OpenInpFile(filein));
            StreamWriter wiw = new StreamWriter(fileout, false, Encoding.UTF8);
            foreach (vanparty aa in partyset) {
                aa.RussianRegExpSymbols();
                foreach (string bb in aa.Abzatz) {
                    wiw.WriteLine(bb);
                    }
                }
            wiw.Close();
            }

        /// <summary>
        ///
        /// Модификация от 16 декабря 2014 года
        /// Заложен 16 декабря 2014 года
        /// </summary>
        /// <param name="dirin"></param>
        /// <param name="dirout"></param>
        public void ConvertAllDirectory(string dirin, string dirout) {
            DirectoryInfo dd = new DirectoryInfo(dirin);

            foreach (FileInfo aa in dd.GetFiles("*.pgn")) {
                string filoin = aa.FullName;
                string shorto = aa.Name;
                string filoout = Path.Combine(dirout, shorto);
                this.ConvertVanFile(filoin, filoout);
                }
            }

        }
    }
