using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
    public enum Command
    {
        Button,
        Undo,
        NewGame,
    }
    class SocKetData
    {
        Command command;
        string mess;
        Button btn;

        public string Mess { get => mess; set => mess = value; }    
        public Button Btn { get => btn; set => btn = value; }
        internal Command Command { get => command; set => command = value; }

        
    }
}
