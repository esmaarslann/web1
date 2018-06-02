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

namespace Hastane.WFA.HemsireForms
{
    public partial class HemsireListeleFormIntermediate : ListeleBaseForm<Hemsire>
    {
        public HemsireListeleFormIntermediate()
        {
            InitializeComponent();
            this.BaseClass = new Hemsire();
        }
    }
}
