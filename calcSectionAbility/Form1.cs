using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcSectionAbility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double height = double.Parse(in_height.Text);
            double width = double.Parse(in_width.Text);
            double th = double.Parse(in_th.Text);
            double tw = double.Parse(in_tw.Text);
            double lb = double.Parse(in_lb.Text);
            double F = double.Parse(in_f.Text);
            double E = double.Parse(in_e.Text);
            double G = double.Parse(in_g.Text);
            //double m1 = double.Parse(in_m1.Text);
            //double m2 = double.Parse(in_m2.Text);
            //bool doublecurve = bool.Parse(in_doublecurved.Text);
            var sec = new PipeSection(height, width, th, tw, lb, E, G, F);
            out_lt.Text = Math.Round(sec.ft,2).ToString();
            out_lc.Text = Math.Round(sec.fc,2).ToString();
            out_ls.Text = Math.Round(sec.fs,2).ToString();
            out_lb.Text = Math.Round(sec.fb,2).ToString();
            out_st.Text = Math.Round(sec.ft*1.5, 2).ToString();
            out_sc.Text = Math.Round(sec.fc*1.5, 2).ToString();
            out_ss.Text = Math.Round(sec.fs*1.5, 2).ToString();
            out_sb.Text = Math.Round(sec.fb*1.5, 2).ToString();
            out_area.Text = Math.Round(sec.area,2).ToString();
            out_j.Text = Math.Round(sec.j,2).ToString();
            out_ix.Text = Math.Round(sec.ix,2).ToString();
            out_iy.Text = Math.Round(sec.iy,2).ToString();
            out_zx.Text = Math.Round(sec.zx,2).ToString();
            out_zy.Text = Math.Round(sec.zy,2).ToString();


        }


    }
}
