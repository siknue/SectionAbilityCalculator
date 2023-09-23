using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcSectionAbility
{
    class Section
    {
        public double ix { get; set; }
        public double iy { get; set; }
        public double zx { get; set; }
        public double zy { get; set; }
        public double j { get; set; }
        public double Iw { get; set; }
        public double lb { get; set; }
        public double area { get; set; }
        public double e { get; set; }
        public double g { get; set; }
        public double f { get; set; }
        public double sr { get; set; }
        public double lsr { get; set; }
        public double ft { get; set; }
        public double fs { get; set; }
        public double fc { get; set; }
        public double fb { get; set; }

        public Section()
        {
            this.ix = 0;
            this.iy = 0;
            this.zx = 0;
            this.zy = 0;
            this.j = 0;
            this.Iw = 0;
            this.lb = 0;
            this.area = 0;
            this.e = 0;
            this.g = 0;
            this.f = 0;
            this.sr = 0;
            this.lsr = 0;
            this.ft = 0;
            this.fs = 0;
            this.fc = 0;
            this.fb = 0;
        }
        public void CalcSR()
        {
            double i_w = Math.Min(this.ix, this.iy);
            double i = Math.Pow((i_w / this.area), 0.5);
            double sr = this.lb / i;
            this.sr = sr;
        }

        public void CalcLSR()
        {
            double lsr = Math.PI * Math.Pow((this.e / 0.6 / this.f), 0.5);

            this.lsr = lsr;
        }

        public void CalcShear()
        {
            this.fs = this.f / 1.5 / Math.Sqrt(3);
        }

        public void CalcBacklingCompression()
        {
            double fc;
            var v = 1.5 + 2.0 / 3.0 * (Math.Pow(this.sr / this.lsr, 2));
            if (this.sr <= this.lsr)
            {
                fc = 1.0 / v * (1.0 - 0.4 * Math.Pow(this.sr / this.lsr, 2)) * this.f;
            }
            else
            {
                fc = 0.277 * (Math.Pow(this.lsr / this.sr, 2)) * this.f;
            }
            this.fc = fc;
        }

        public void CalcBacklingBend()
        {
            double i_w = Math.Min(ix, iy);
            double z_s = Math.Max(zx, zy);
            double C = 1.0;
            double PLB = 0.3;
            double ELB = 1.29;

            double My = this.f * z_s;
            double Me = C * Math.Pow(((Math.Pow(Math.PI, 4)) * (Math.Pow(this.e, 2) * i_w * this.Iw) / Math.Pow(this.lb, 4) + Math.Pow(Math.PI, 2) * this.e * i_w * this.g * this.j / Math.Pow(this.lb, 2)), 0.5); //弾性横座屈モーメント
            double LambdaB = Math.Pow((My / Me), 0.5);
            double v = 1.5 + 2.0 / 3.0 * Math.Pow(LambdaB / ELB, 2);

            double fb;

            if (LambdaB < PLB)
            {
                fb = this.f / v;
            }
            else if (LambdaB <= ELB && PLB < LambdaB)
            {
                fb = (((1.0 - 0.4 * (LambdaB - PLB) / (ELB - PLB)) * this.f) / v);
            }
            else
            {
                fb = 1 / Math.Pow(LambdaB, 2) * this.f / 2.17;
            }


            this.fb = fb;
        }
    }


    class PipeSection : Section
    {
        public double height;
        public double width;
        public double th;
        public double tw;

        public PipeSection(double height, double width, double th, double tw, double lb, double e, double g, double f)
        {
            this.height = height;
            this.width = width;
            this.th = th;
            this.tw = tw;
            this.lb = lb;
            this.e = e;
            this.g = g;
            this.f = f;
            this.CalcArea();
            this.CalcAbility();
            this.CalcSR();
            this.CalcLSR();
            this.CalcTorsionalConstant();
            this.CalcAllowance();

        }

        private void CalcArea()
        {
            var height = this.height;
            var width = this.width;
            var th = this.th;
            var tw = this.tw;
            double area = height * width - (height - th * 2) * (width - tw * 2);
            this.area = area;
        }

        private void CalcAbility()
        {
            double i_s = (this.width * Math.Pow(this.height, 3) - (this.width - this.tw * 2) * Math.Pow((this.height - this.th * 2), 3)) / 12.0;
            double i_w = (Math.Pow(this.width, 3) * this.height - Math.Pow(this.width - this.tw * 2, 3) * (this.height - this.th * 2)) / 12.0;
            double z_s = i_s / (this.height / 2.0);
            double z_w = i_w / (this.width / 2.0);
            this.ix = i_s;
            this.iy = i_w;
            this.zx = z_s;
            this.zy = z_w;
        }

        private void CalcTorsionalConstant()
        {
            double j = (2 * this.tw * this.th * Math.Pow((this.height - this.th), 2) * Math.Pow((this.width - this.tw), 2)) / (this.width * this.tw + this.height * this.th - Math.Pow(this.th, 2) - Math.Pow(this.th, 2));
            this.j = j;
        }

        private void CalcAllowance()
        {
            this.ft = this.f;
            this.fs = this.f / 1.5;
            this.CalcShear();
            this.CalcBacklingBend();
            this.CalcBacklingCompression();
        }

    }
}
