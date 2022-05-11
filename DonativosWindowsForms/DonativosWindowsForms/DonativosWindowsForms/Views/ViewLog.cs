using DonativosWindowsForms.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonativosWindowsForms.Views
{
    public class ViewLog
    {
        private FormularioLog formularioLog;
        public void ActivarInterface()
        {
            formularioLog = new FormularioLog();
            formularioLog.View = this;
            formularioLog.Show();
        }
    }
}
