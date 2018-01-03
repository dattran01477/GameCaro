using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
    
    class Player
    {
        string name;
        TextBox txtName;
        Button btn;
        Image img;
        //public Player(Image _img)
        //{
           

        
        //    this.Img = _img;

        //}

        public string Name { get => name; set => name = value; }
        public TextBox TxtName { get => txtName; set => txtName = value; }
        public Button Btn { get => btn; set => btn = value; }
        public Image Img { get => img; set => img = value; }

        public void Play(Button _btn)
        {
            this.btn = _btn;
            Btn.BackgroundImage = Img;
          
        }
    }
}
