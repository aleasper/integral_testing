using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicTestsLab
{
    public partial class TableForm : Form
    {
        
        public TableForm(List<double> parabolEsps, List<double> trapecEsp, List<double> monteEsps, double epsT)
        {
            InitializeComponent();
            this.resTable.Columns.Add("pol", "Степень полинома");
            this.resTable.Columns.Add("parabol", "Парабола");
            this.resTable.Columns.Add("trap", "Трапеция");
            this.resTable.Columns.Add("monte", "Монте-Карло");
            for (int i = 0; i != parabolEsps.Count; ++i)
            {
                this.resTable.Rows.Add(i+1, parabolEsps[i], trapecEsp[i], monteEsps[i]);
                this.resTable.Rows[i].Cells[1].Style.BackColor = Color.Green;
                this.resTable.Rows[i].Cells[2].Style.BackColor = Color.Green;
                this.resTable.Rows[i].Cells[3].Style.BackColor = Color.Green;
                if (parabolEsps[i] > epsT) this.resTable.Rows[i].Cells[1].Style.BackColor = Color.Red;
                if (trapecEsp[i] > epsT) this.resTable.Rows[i].Cells[2].Style.BackColor = Color.Red;
                if (monteEsps[i] > epsT) this.resTable.Rows[i].Cells[3].Style.BackColor = Color.Red;
            }
        }
    }
}
