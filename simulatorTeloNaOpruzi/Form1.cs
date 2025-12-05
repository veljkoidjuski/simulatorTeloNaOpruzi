using System.Diagnostics;
using System.Drawing.Text;
using System.Windows.Markup;

namespace simulatorTeloNaOpruzi
{
    public partial class Form1 : Form
    {

        public const int MASA = 1;
        public const int X = 0;
        public const int Y = 0;

        private TackastaMasa teg;
        private Opruga nit;
        private bool simulacijaUToku;
        private int razmer;

        private int cx = 175;
        private int cy = 175;
        class TackastaMasa
        {
            private double m;
            private double x;
            private double y;
            private double theta;
            private double thetaTacka = 0;
            private double w;
            private double wTacka = 0;

            public double Masa { get { return m; } set { m = value; } }
            public double X { get { return x; } set { x = value; } }
            public double Y { get { return y; } set { y = value; } }
            public double Theta { get { return theta; } set { theta = value; } }
            public double ThetaTacka { get { return thetaTacka; } set { thetaTacka = value; } }
            public double W { get { return w; } set { w = value; } }
            public double WTacka { get { return wTacka; } set { wTacka = value; } }

            public TackastaMasa(double Masa, double X, double Y)
            {
                this.Masa = Masa;
                this.X = X;
                this.Y = Y;
            }
        }

        class Opruga
        {
            private double l;
            private double x;
            private double y;
            private double dL;
            private double dLTacka = 0;
            private double v = 0;
            private double vTacka;
            private double k;
            private double c;
            public double Duzina { get { return l; } set { l = value; } }
            public double X { get { return x; } set { x = value; } }
            public double Y { get { return y; } set { y = value; } }

            public double DL { get { return dL; } set { dL = value; } }

            public double DLTacka { get { return dLTacka; } set { dLTacka = value; } }
            public double V { get { return v; } set { v = value; } }
            public double VTacka { get { return vTacka; } set { vTacka = value; } }
            public double K { get { return k; } set { k = value; } }
            public double C { get { return k; } set { k = value; } }

            public Opruga(double Duzina, double X, double Y, double K, double C)
            {
                this.Duzina = Duzina;
                this.X = X;
                this.Y = Y;
                this.K = K;
                this.C = C;
            }
        }

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;

            teg = new TackastaMasa(MASA, X, Y);
            nit = new Opruga(1, X, Y, 1, 0.1);
            simulacijaUToku = false;
            razmer = 400;
            pivot.Location = new Point(pictureBox1.Location.X + 171, pictureBox1.Location.Y + 171);
            pivot.BackColor = Color.Red;
            pivot.FlatAppearance.MouseOverBackColor = Color.Red;
            pivot.FlatAppearance.MouseDownBackColor = Color.Red;
            pivot.FlatAppearance.BorderSize = 0;

            cx = pivot.Location.X - pictureBox1.Location.X + 2;
            cy = pivot.Location.Y - pictureBox1.Location.Y + 2;
        }

        private void azuriraj(double h)
        { 
            teg.W += h * ((-2 * teg.ThetaTacka * nit.DLTacka - 9.81 * Math.Sin(teg.Theta)) / (nit.Duzina + nit.DL));
            teg.Theta += h * teg.W;
            nit.V += h * (((teg.Masa * teg.ThetaTacka * teg.ThetaTacka * (nit.Duzina + nit.DL) - (nit.K * nit.DL) + (teg.Masa * 9.81 * Math.Cos(teg.Theta))) / teg.Masa));
            nit.DL += h * nit.V;

            teg.X = (nit.Duzina + nit.DL) * Math.Sin(teg.Theta);
            teg.Y = (nit.Duzina + nit.DL) * Math.Cos(teg.Theta);

            nit.X = teg.X;
            nit.Y = teg.Y;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;

            gfx.DrawEllipse(new Pen(Color.Black, 5), (float)(cx + teg.X * razmer - 10), (float)(cy + teg.Y * razmer - 10), 20, 20);
            gfx.DrawLine(new Pen(Color.Black, 5), new Point(cx, cy), new Point(cx + (int)(nit.X * razmer), cy + (int)(nit.Y * razmer)));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
            Refresh();

            if (simulacijaUToku)
            {
                for (int i = 0; i < 100; i++) azuriraj(0.0005);
            }

            if(pivot.Capture)
            {
                int mX = MousePosition.X - Location.X;
                int mY = MousePosition.Y - Location.Y - SystemInformation.CaptionHeight;
                int xLok = (mX > (pictureBox1.Location.X + 330) ? (pictureBox1.Location.X + 330) : (mX < pictureBox1.Location.X + 10 ? pictureBox1.Location.X + 10 : mX));
                int yLok = (mY > (pictureBox1.Location.Y + 330) ? (pictureBox1.Location.Y + 330) : (mY < pictureBox1.Location.Y + 10 ? pictureBox1.Location.Y + 10 : mY));
                pivot.Location = new Point(xLok, yLok);
                cx = pivot.Location.X - pictureBox1.Location.X + 2;
                cy = pivot.Location.Y - pictureBox1.Location.Y + 2;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            teg.Masa = (double)masaBox.Value;
            teg.X = (double)(xBox.Value);
            teg.Y = (double)(yBox.Value);
            nit.X = teg.X;
            nit.Y = teg.Y;
            nit.Duzina = (double)(duzinaBox.Value);
            nit.K = (double)kBox.Value;
            //nit.C = (double)(cBox.Value);

            teg.Theta = Math.Atan2(teg.X, teg.Y);
            nit.DL = Math.Sqrt(teg.X * teg.X + teg.Y * teg.Y) - nit.Duzina;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            simulacijaUToku = !simulacijaUToku;
            if (!simulacijaUToku)
            {
                teg.ThetaTacka = 0;
                teg.W = 0;
                nit.DLTacka = 0;
                nit.V = 0;
            }

            

            button2.Text = simulacijaUToku ? "Заустави" : "Започни";
            button1.Enabled = simulacijaUToku ? false : true;


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioCentim_CheckedChanged(object sender, EventArgs e)
        {
            radioMetar.Checked = !radioCentim.Checked;
            razmer = 100 * (radioCentim.Checked ? 4 : 1);
        }

        private void radioMetar_CheckedChanged(object sender, EventArgs e)
        {
            radioCentim.Checked = !radioMetar.Checked;
            razmer = 100 * (radioCentim.Checked ? 4 : 1);
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void kBox_ValueChanged(object sender, EventArgs e)
        {

        }
    }


}
