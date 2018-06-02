using Hastane.Entity;
using Hastane.WFA.BaseForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane.WFA.HastaForms
{
    public partial class HastaListeleFormIntermediate : ListeleBaseForm<Hasta>
    {
        public HastaListeleFormIntermediate()
        {
            InitializeComponent();
            this.BaseClass =new Hasta();
        }
    }
}
