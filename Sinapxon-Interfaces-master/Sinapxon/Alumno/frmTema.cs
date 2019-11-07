using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinapxon.Alumno
{
    public partial class frmTema : Form
    {

        public frmTema()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            var embed = "<html><head>" +
            "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
            "</head><body>" +
            "<iframe width=\"520\" src=\"{0}\"" +
            "<iframe height=\"260\" src=\"{0}\"" +
            "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
            "</body></html>";
            //var url = "https://www.youtube.com/embed/L6ZgzJKfERM";
            var url = "https://www.youtube.com/embed/mb3GhfFfo_0";
            this.webBrowser2.DocumentText = string.Format(embed, url);
        }
    }
}
