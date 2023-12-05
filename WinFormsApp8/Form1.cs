using System;

namespace WinFormsApp8
{



    public partial class Form1 : Form
    {
        Panel pn1 = new Panel();
        Panel Pn2 = new Panel();

        Label Num = new Label();
        Label Rat = new Label();
        Label Tax = new Label();

        TextBox input_N = new TextBox();
        TextBox input_R = new TextBox();
        TextBox input_T = new TextBox();

        Button Wage = new Button();
        Button salary = new Button();

        Label W = new Label();
        Label S = new Label();
        //  Label result_W= new Label();
        // Label result_S= new Label();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(459, 489);
            this.Text = "Employee salary";
            this.Controls.Add(Num);
            this.Controls.Add(Rat);
            this.Controls.Add(Tax);
            this.Controls.Add(input_N);
            this.Controls.Add(input_R);
            this.Controls.Add(input_T);

            this.Controls.Add(pn1);
            this.Controls.Add(Pn2);

            this.Controls.Add(W);
            this.Controls.Add(S);

            this.Controls.Add(salary);
            this.Controls.Add(Wage);


           
            input_N.Location = new Point(231, 35);
            input_N.Size = new Size(157, 23);

            input_R.Location = new Point(231, 80);
            input_R.Size = new Size(157, 23);

            input_T.Location = new Point(231, 110);
            input_T.Size = new Size(157, 23);

            Num.Location = new Point(49, 35);
            Num.Text = "Number of hours";
            Num.Size = new Size(100, 15);

            Rat.Location = new Point(49, 80);
            Rat.Text = "Rate of hour";
            Rat.Size = new Size(100, 15);

            Tax.Location = new Point(49, 123);
            Tax.Text = "Tax";
            Tax.Size = new Size(38, 15);

            W.Location = new System.Drawing.Point(55, 242);
            W.AutoSize= true;
            W.Text = "Wage = ";


            S.Location = new System.Drawing.Point(55, 298);
            S.AutoSize = true;
            S.Text = "Salary = ";

            Wage.Location = new System.Drawing.Point(82, 381);
            Wage.Size = new System.Drawing.Size(75, 34);
            Wage.Text = "Wage";
            Wage.Click += new EventHandler(fun1);

            salary.Location = new System.Drawing.Point(243, 381);
            salary.Size = new System.Drawing.Size(75, 34);
            salary.Text = "Salary";
            salary.Click += new EventHandler(fun2);




        }
        private void fun1(object sender, EventArgs e)
        {
            int n = int.Parse(input_N.Text);
            int r = int.Parse(input_R.Text);
            int t = int.Parse(input_T.Text);
            int output;

            if (n <= 40)
            {
                output = (n * r) - t;
                W.Text = "Wage = " + output.ToString();
            }
             
            else
            {
                int yn = n - 40;
                int ny = yn * r * 2;
                output = ny + (40 * r)-t;
                W.Text = "Wage is = " + output.ToString();
                return;
            }
            
           


        }
        void fun2(object sender, EventArgs e)
        {

            int n = int.Parse(input_N.Text);
            int r = int.Parse(input_R.Text);
            int t = int.Parse(input_T.Text);
            int output;

            if (n <= 160)
            {
                output = (n * r) - t;
                S.Text = "Salary is = " + output.ToString();
            }

            else
            {
                int yn = n - 160;
                int ny = yn * r * 2;
                output = ny + (160 * r) - t;
                S.Text = "Salary is = " + output.ToString();

            }
        }
    }
}
