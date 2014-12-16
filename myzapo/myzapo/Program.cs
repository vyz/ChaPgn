using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myzapo
{
    public class Program
    {

        /// <summary>
        /// 
        /// Модификация от 16 декабря 2014 года
        /// Заложен 16 декабря 2014 года
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {
            int deystvo = Properties.Settings.Default.Deystvo;
            mano mn = new mano();

            if (deystvo == 1) {
                string failoin = Properties.Settings.Default.FiloIn;
                string failoout = Properties.Settings.Default.FiloOut;
                mn.ConvertVanFile(failoin, failoout);
            } else if (deystvo == 2) {
                string dirin = Properties.Settings.Default.Diroin;
                string dirout = Properties.Settings.Default.Diroout;
                mn.ConvertAllDirectory(dirin, dirout);
                }
            }

        }
    }
