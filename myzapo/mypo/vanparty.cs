using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mypo
{
    public class vanparty {
        private string pgnDecs;
        private List<string> allset;
        private int iStartGameStoka;

        public vanparty() { }

        public vanparty(string opis, List<string> pset, int istart) {
            pgnDecs = opis;
            allset = pset;
            iStartGameStoka = istart;
            }

        public void RussianRegExpSymbols() {
            const string v1s = "o^";
            const string v1t = "ю";
            const string v2s = "~~";
            const string v2t = "ч";
            const string v3s = "><";
            const string v3t = "Ч";
            for (int i = iStartGameStoka; i < allset.Count; i++) {
                string tt = allset[i].Replace(v1s, v1t);
                tt = tt.Replace(v2s, v2t);
                allset[i] = tt.Replace(v3s, v3t);
                }
            }

        public List<string> Abzatz { get { return allset; } }
        }
}
