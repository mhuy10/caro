using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class rule : Form
    {

        private Bitmap bmprule = new Bitmap("..//..//rule.jpg");
        public rule()
        {
            InitializeComponent();
            picRule.Image = bmprule;
        }

        
    }
}
