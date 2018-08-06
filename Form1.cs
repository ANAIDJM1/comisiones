using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comisiones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static double Suma=0;
        private double Suma2 = 0;
        private static double Sum = 0;
        private void baginbox()
        {
            //-----bag in box
            //si esta chekeado tal valor, suma de acuerdo a su comision correspondiente
            if (c1.Checked == true)
            {
                double a = 1;
                if (t1.Text.ToString() != "")
                    a = Convert.ToDouble(t1.Text);              

                Suma = Suma + (1.50 * a);
            }

            //--------------------------------------------------------------------------------------

            if (c2.Checked == true)
            {
                double a = 1;
                if (t2.Text.ToString() != "")
                    a = Convert.ToDouble(t2.Text);
             

                Suma = Suma + (1 * a);
            }
            if (c3.Checked == true)
            {
                double a = 1;
                if (t3.Text.ToString() != "")
                    a = Convert.ToDouble(t3.Text);
               

                Suma = Suma + (0.8 * a);
            }
            if (c4.Checked == true)
            {
                double a = 1;
                if (t4.Text.ToString() != "")
                    a = Convert.ToDouble(t4.Text);
              

                Suma = Suma + (0.70 * a);
            }
        }
        private double baginbox2()
        {
            Suma2 = 0;
            
            if (c1.Checked == true)
            {
                double a = 1;
                if (t1.Text.ToString() != "")
                    a = Convert.ToDouble(t1.Text);

                Suma2 = Suma2 + (1.50 * a);
            }

            //--------------------------------------------------------------------------------------

            if (c2.Checked == true)
            {
                double a = 1;
                if (t2.Text.ToString() != "")
                    a = Convert.ToDouble(t2.Text);


                Suma2 = Suma2 + (1 * a);
            }
            if (c3.Checked == true)
            {
                double a = 1;
                if (t3.Text.ToString() != "")
                    a = Convert.ToDouble(t3.Text);


                Suma2 = Suma2 + (0.8 * a);
            }
            if (c4.Checked == true)
            {
                double a = 1;
                if (t4.Text.ToString() != "")
                    a = Convert.ToDouble(t4.Text);

                Suma2 = Suma2 + (0.70 * a);
            }

            return Suma2;
        }
        private void trescin()
        {
              if (c22.Checked == true)
            {
                double a = 1;
                if (t22.Text.ToString() != "")
                    a = Convert.ToDouble(t22.Text);
              

                Suma = Suma + (1 * a);
            }
            if (c23.Checked == true)
            {
                double a = 1;
                if (t23.Text.ToString() != "")
                    a = Convert.ToDouble(t23.Text);
              

                Suma = Suma + (0.80 * a);
            }
        }
        private double trescin2()
        {
            Suma2 = 0;
            if (c22.Checked == true)
            {
                double a = 1;
                if (t22.Text.ToString() != "")
                    a = Convert.ToDouble(t22.Text);


                Suma2 = Suma2 + (1 * a);
            }
            if (c23.Checked == true)
            {
                double a = 1;
                if (t23.Text.ToString() != "")
                    a = Convert.ToDouble(t23.Text);


                Suma2 = Suma2 + (0.80 * a);
            }

            return Suma2;
        }
        private void recarga()
        {
            if (c5.Checked == true)
            {
                double a = 1;
                if (t5.Text.ToString() != "")
                    a = Convert.ToDouble(t5.Text);
          

                Suma = Suma + (1 * a);
            }
            if (c6.Checked == true)
            {
                double a = 1;
                if (t6.Text.ToString() != "")
                    a = Convert.ToDouble(t6.Text);
              

                Suma = Suma + (0.80 * a);
            }
            if (c7.Checked == true)
            {
                double a = 1;
                if (t7.Text.ToString() != "")
                    a = Convert.ToDouble(t7.Text);
               

                Suma = Suma + (0.70 * a);
            }
            if (c8.Checked == true)
            {
                double a = 1;
                if (t8.Text.ToString() != "")
                    a = Convert.ToDouble(t8.Text);
                

                Suma = Suma + (0.60 * a);
            }
            if (c9.Checked == true)
            {
                double a = 1;
                if (t9.Text.ToString() != "")
                    a = Convert.ToDouble(t9.Text);
               

                Suma = Suma + (0.50 * a);
            }
        }
        private double recarga2()
        {
            Suma2 = 0;
            if (c5.Checked == true)
            {
                double a = 1;
                if (t5.Text.ToString() != "")
                    a = Convert.ToDouble(t5.Text);


                Suma2 = Suma2 + (1 * a);
            }
            if (c6.Checked == true)
            {
                double a = 1;
                if (t6.Text.ToString() != "")
                    a = Convert.ToDouble(t6.Text);


                Suma2 = Suma2 + (0.80 * a);
            }
            if (c7.Checked == true)
            {
                double a = 1;
                if (t7.Text.ToString() != "")
                    a = Convert.ToDouble(t7.Text);


                Suma2 = Suma2 + (0.70 * a);
            }
            if (c8.Checked == true)
            {
                double a = 1;
                if (t8.Text.ToString() != "")
                    a = Convert.ToDouble(t8.Text);


                Suma2 = Suma2 + (0.60 * a);
            }
            if (c9.Checked == true)
            {
                double a = 1;
                if (t9.Text.ToString() != "")
                    a = Convert.ToDouble(t9.Text);


                Suma2 = Suma2 + (0.50 * a);
            }

            return Suma2;
        }
        private void dosli()
        {
            if (c10.Checked == true)
            {
                double a = 1;
                if (t10.Text.ToString() != "")
                    a = Convert.ToDouble(t10.Text);
              

                Suma = Suma + (0.50 * a);
            }
            if (c11.Checked == true)
            {
                double a = 1;
                if (t11.Text.ToString() != "")
                    a = Convert.ToDouble(t11.Text);
           

                Suma = Suma + (0.40 * a);

            }
            if (c12.Checked == true)
            {
                double a = 1;
                if (t12.Text.ToString() != "")
                    a = Convert.ToDouble(t12.Text);
               

                Suma = Suma + (0.30 * a);
            }
        }
        private double dosli2()
        {
            Suma2 = 0;
            if (c10.Checked == true)
            {
                double a = 1;
                if (t10.Text.ToString() != "")
                    a = Convert.ToDouble(t10.Text);


                Suma2 = Suma2 + (0.50 * a);
            }
            if (c11.Checked == true)
            {
                double a = 1;
                if (t11.Text.ToString() != "")
                    a = Convert.ToDouble(t11.Text);


                Suma2 = Suma2 + (0.40 * a);

            }
            if (c12.Checked == true)
            {
                double a = 1;
                if (t12.Text.ToString() != "")
                    a = Convert.ToDouble(t12.Text);


                Suma2= Suma2 + (0.30 * a);
            }
            return Suma2;
        }
        private void unli()
        {
            if (c13.Checked == true)
            {
                double a = 1;
                if (t13.Text.ToString() != "")
                    a = Convert.ToDouble(t13.Text);
             

                Suma = Suma + (2 * a);
            }
            if (c14.Checked == true)
            {
                double a = 1;
                if (t14.Text.ToString() != "")
                    a = Convert.ToDouble(t14.Text);
              

                Suma = Suma + (1.50 * a);
            }
            if (c15.Checked == true)
            {
                double a = 1;
                if (t15.Text.ToString() != "")
                    a = Convert.ToDouble(t15.Text);
          

                Suma = Suma + (1.41 * a);
            }
            if (c16.Checked == true)
            {
                double a = 1;
                if (t16.Text.ToString() != "")
                    a = Convert.ToDouble(t16.Text);
            

                Suma = Suma + (1 * a);
            }
        }
        private double unli2()
        {
            Suma2 = 0;
            if (c13.Checked == true)
            {
                double a = 1;
                if (t13.Text.ToString() != "")
                    a = Convert.ToDouble(t13.Text);


                Suma2 = Suma2 + (2 * a);
            }
            if (c14.Checked == true)
            {
                double a = 1;
                if (t14.Text.ToString() != "")
                    a = Convert.ToDouble(t14.Text);


                Suma2 = Suma2 + (1.50 * a);
            }
            if (c15.Checked == true)
            {
                double a = 1;
                if (t15.Text.ToString() != "")
                    a = Convert.ToDouble(t15.Text);


                Suma2 = Suma2 + (1.41 * a);
            }
            if (c16.Checked == true)
            {
                double a = 1;
                if (t16.Text.ToString() != "")
                    a = Convert.ToDouble(t16.Text);


                Suma2 = Suma2 + (1 * a);
            }
            return Suma2;
        }
        private void setec()
        {
            if (c17.Checked == true)
            {
                double a = 1;
                if (t17.Text.ToString() != "")
                    a = Convert.ToDouble(t17.Text);
            

                Suma = Suma + (1.50 * a);
            }
            if (c18.Checked == true)
            {
                double a = 1;
                if (t18.Text.ToString() != "")
                    a = Convert.ToDouble(t18.Text);
             

                Suma = Suma + (1 * a);
            }
            if (c19.Checked == true)
            {
                double a = 1;
                if (t19.Text.ToString() != "")
                    a = Convert.ToDouble(t19.Text);
              

                Suma = Suma + (0.8 * a);
            }
            if (c20.Checked == true)
            {
                double a = 1;
                if (t20.Text.ToString() != "")
                    a = Convert.ToDouble(t20.Text);
              

                Suma = Suma + (0.8 * a);
            }
            if (c21.Checked == true)
            {
                double a = 1;
                if (t21.Text.ToString() != "")
                    a = Convert.ToDouble(t21.Text);

                Suma = Suma + (0.7 * a);
            }
        }
        private double setec2()
        {
            Suma2 = 0;
            if (c17.Checked == true)
            {
                double a = 1;
                if (t17.Text.ToString() != "")
                    a = Convert.ToDouble(t17.Text);


                Suma2 = Suma2 + (1.50 * a);
            }
            if (c18.Checked == true)
            {
                double a = 1;
                if (t18.Text.ToString() != "")
                    a = Convert.ToDouble(t18.Text);


                Suma2 = Suma2 + (1 * a);
            }
            if (c19.Checked == true)
            {
                double a = 1;
                if (t19.Text.ToString() != "")
                    a = Convert.ToDouble(t19.Text);


                Suma2 = Suma2 + (0.8 * a);
            }
            if (c20.Checked == true)
            {
                double a = 1;
                if (t20.Text.ToString() != "")
                    a = Convert.ToDouble(t20.Text);


                Suma2 = Suma2 + (0.8 * a);
            }
            if (c21.Checked == true)
            {
                double a = 1;
                if (t21.Text.ToString() != "")
                    a = Convert.ToDouble(t21.Text);

                Suma2 = Suma2 + (0.7 * a);
            }
            return Suma2;
        }
        private void quinientos()
        {
            if (c24.Checked == true)
            {
                double a = 1;
                if (t24.Text.ToString() != "")
                    a = Convert.ToDouble(t24.Text);

                Suma = Suma + (0.50 * a);
            }
            if (c25.Checked == true)
            {
                double a = 1;
                if (t25.Text.ToString() != "")
                    a = Convert.ToDouble(t25.Text);

                Suma = Suma + (0.30 * a);

            }
            if (c26.Checked == true)
            {
                double a = 1;
                if (t26.Text.ToString() != "")
                    a = Convert.ToDouble(t26.Text);

                Suma = Suma + (0.26 * a);
            }
            if (c27.Checked == true)
            {
                double a = 1;
                if (t27.Text.ToString() != "")
                    a = Convert.ToDouble(t27.Text);

                Suma = Suma + (0.25 * a);
            }
            if (c28.Checked == true)
            {
                double a = 1;
                if (t28.Text.ToString() != "")
                    a = Convert.ToDouble(t28.Text);

                Suma = Suma + (0.23 * a);
            }
        }
        private double quinientos2()
        {
            Suma2 = 0;
            if (c24.Checked == true)
            {
                double a = 1;
                if (t24.Text.ToString() != "")
                    a = Convert.ToDouble(t24.Text);

                Suma2 = Suma2 + (0.50 * a);
            }
            if (c25.Checked == true)
            {
                double a = 1;
                if (t25.Text.ToString() != "")
                    a = Convert.ToDouble(t25.Text);

                Suma2 = Suma2 + (0.30 * a);

            }
            if (c26.Checked == true)
            {
                double a = 1;
                if (t26.Text.ToString() != "")
                    a = Convert.ToDouble(t26.Text);

                Suma2 = Suma2 + (0.26 * a);
            }
            if (c27.Checked == true)
            {
                double a = 1;
                if (t27.Text.ToString() != "")
                    a = Convert.ToDouble(t27.Text);

                Suma2 = Suma2 + (0.25 * a);
            }
            if (c28.Checked == true)
            {
                double a = 1;
                if (t28.Text.ToString() != "")
                    a = Convert.ToDouble(t28.Text);

                Suma2 = Suma2 + (0.23 * a);
            }

            return Suma2;
        }
        private void vidrio()
        {
            if (c29.Checked == true)
            {
                double a = 1;
                if (t29.Text.ToString() != "")
                    a = Convert.ToDouble(t29.Text);

                Suma = Suma + (1.50 * a);
            }
            if (c30.Checked == true)
            {
                double a = 1;
                if (t30.Text.ToString() != "")
                    a = Convert.ToDouble(t30.Text);

                Suma = Suma + (1.30 * a);
            }
            if (c31.Checked == true)
            {
                double a = 1;
                if (t31.Text.ToString() != "")
                    a = Convert.ToDouble(t31.Text);

                Suma = Suma + (1.25 * a);
            }

        }
        private double vidrio2()
        {
            Suma2 = 0;
            if (c29.Checked == true)
            {
                double a = 1;
                if (t29.Text.ToString() != "")
                    a = Convert.ToDouble(t29.Text);

                Suma2 = Suma2 + (1.50 * a);
            }
            if (c30.Checked == true)
            {
                double a = 1;
                if (t30.Text.ToString() != "")
                    a = Convert.ToDouble(t30.Text);

                Suma2 = Suma2 + (1.30 * a);
            }
            if (c31.Checked == true)
            {
                double a = 1;
                if (t31.Text.ToString() != "")
                    a = Convert.ToDouble(t31.Text);

                Suma2 = Suma2 + (1.25 * a);
            }

            return Suma2;
        }
        private void Calcula()
        {
            baginbox();
            //----------------------------------350
            trescin();
            //-----------------------------------recarga
            recarga();
            //-----------------------------------2l
            dosli();
            //--------------------------------------1l
            unli();
            //--------------------------------700
            setec();
            //-------------------------500
            quinientos();
            //----------------------------vidrio
            vidrio();

        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            t17.Enabled = true;
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            t18.Enabled = true;
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            t19.Enabled = true;
        }
        private static string product="";
        private string TipoProducto()
        {
            if (c1.Checked == true || c2.Checked == true || c3.Checked == true || c4.Checked == true)
                product = "Bag in Box";

            if (c5.Checked == true || c6.Checked == true || c7.Checked == true || c8.Checked == true || c9.Checked == true)
                product = "Recarga";

            if (c10.Checked == true || c11.Checked == true || c12.Checked == true )
                product = "2 Lt.";

            if (c13.Checked == true || c14.Checked == true || c15.Checked == true || c16.Checked == true)
                product = "1 Lt.";

            if (c17.Checked == true || c18.Checked == true || c19.Checked == true || c20.Checked == true || c21.Checked == true)
                product = "700 ml.";

            if (c22.Checked == true || c23.Checked == true )
                product = "350 ml.";

            if (c24.Checked == true || c25.Checked == true || c26.Checked == true || c27.Checked == true || c28.Checked == true)
                product = "500 ml.";

            if (c29.Checked == true || c30.Checked == true || c31.Checked == true )
                product = "Vidrio";

            return product;


        }

        private int c = 0;
        private void Agregafila()
        {
           
           
         //   switch (TipoProducto())
           // {
            //    case "Bag in Box":
                    if (t1.Enabled == true && t1.Text.ToString() != "")
                        c += Convert.ToInt32(t1.Text);
                    if (t2.Enabled == true && t2.Text.ToString() != "")
                        c += Convert.ToInt32(t2.Text);
                    if (t3.Enabled == true && t3.Text.ToString() != "")
                        c += Convert.ToInt32(t3.Text);
                    if (t4.Enabled == true && t4.Text.ToString() != "")
                        c += Convert.ToInt32(t4.Text);


                    Sum = baginbox2();
                    dt.Rows.Add("Bag in Box", c, Sum);
                    Sum = 0;
                    c = 0;
                //    break;
                //case "Recarga":
                    if (t5.Enabled == true && t5.Text != "")
                        c += Convert.ToInt32(t5.Text);
                    if(t6.Enabled==true && t6.Text!="")
                        c += Convert.ToInt32(t6.Text);
                    if(t7.Enabled==true && t7.Text!="")
                        c += Convert.ToInt32(t7.Text);
                    if(t8.Enabled==true && t8.Text!="")
                        c += Convert.ToInt32(t8.Text);
                    if (t9.Enabled == true && t9.Text != "")
                        c += Convert.ToInt32(t9.Text);

                    Sum = recarga2();                   
                    dt.Rows.Add("Recarga", c,Sum);
                    Sum = 0;
                    c = 0;

                //    break;
                //case "2 Lt.":
                    if (t10.Enabled == true && t10.Text != "")
                        c +=Convert.ToInt32(t10.Text);
                    if(t11.Enabled==true && t11.Text!="")
                        c += Convert.ToInt32(t11.Text);
                    if(t12.Enabled==true && t12.Text!="")
                        c += Convert.ToInt32(t12.Text);


                    Sum = dosli2();
                    dt.Rows.Add("2 Lt.", c, Sum);
                    Sum = 0;
                    c = 0;

                //    break;
                //case "1 Lt.":
                    if (t13.Enabled == true && t13.Text != "")
                        c += Convert.ToInt32(t13.Text);
                    if(t14.Enabled==true && t14.Text!="")
                        c +=Convert.ToInt32(t14.Text);
                    if(t15.Enabled==true && t15.Text!="")
                        c +=Convert.ToInt32(t15.Text);
                    if(t16.Enabled==true && t16.Text!="")
                        c +=Convert.ToInt32(t16.Text);


                    Sum = unli2();
                    dt.Rows.Add("1 Lt.", c, Sum);
                    Sum = 0;
                    c = 0;

                //    break;
                //case "700 ml.":
                    if (t17.Enabled == true && t17.Text != "")
                        c += Convert.ToInt32(t17.Text);
                    if(t18.Enabled==true && t18.Text!="")
                        c += Convert.ToInt32(t18.Text);
                    if(t19.Enabled==true && t19.Text!="")
                        c += Convert.ToInt32(t19.Text);
                    if(t20.Enabled==true && t20.Text!="")
                        c +=Convert.ToInt32(t20.Text);
                    if (t21.Enabled == true && t21.Text != "")
                       c +=Convert.ToInt32(t21.Text);

                    Sum = setec2();
                     dt.Rows.Add("700 ml.",c, Sum);
                    Sum = 0;
                    c = 0;

                //    break;
                //case "350 ml.":
                    if (t22.Enabled == true && t22.Text != "")
                        c +=Convert.ToInt32(t22.Text);
                    if(t23.Enabled==true && t23.Text!="")
                       c +=Convert.ToInt32(t23.Text);


                    Sum = trescin2();
                   dt.Rows.Add("350 ml.", c, Sum);
                    Sum = 0;
                    c = 0;

                //    break;
                //case "500 ml.":
                    if (t24.Enabled == true && t24.Text != "")
                        c += Convert.ToInt32(t24.Text);
                    if(t25.Enabled==true && t25.Text!="")
                        c += Convert.ToInt32(t25.Text);
                    if(t26.Enabled==true && t26.Text!="")
                        c += Convert.ToInt32(t26.Text);
                    if(t27.Enabled==true && t27.Text!="")
                        c += Convert.ToInt32(t27.Text);
                    if (t28.Enabled == true && t28.Text != "")
                        c += Convert.ToInt32(t28.Text);

                    Sum = quinientos2();
                     dt.Rows.Add("500 ml.", c, Sum);
                    Sum = 0;
                    c = 0;

                //    break;
                //case "Vidrio":
                    if (t29.Enabled == true && t29.Text != "")
                        c += Convert.ToInt32(t29.Text);
                    if(t30.Enabled==true && t30.Text!="")
                        c += Convert.ToInt32(t30.Text);
                    if(t31.Enabled==true && t31.Text!="")
                        c +=  Convert.ToInt32(t31.Text);


                    Sum = vidrio2();
                      dt.Rows.Add("Vidrio", c, Sum);
                    Sum = 0;
                    c = 0;
                    //break;
 
            //}
           
            
        }
        private void button1_Click(object sender, EventArgs e)
        {

            convierte();

            Suma = 0;
            Calcula();
            label20.Text = Suma.ToString();

           

        }
        private void convierte()
        {
            if (t1.Text.ToString() == "" && c1.Checked==true)
                t1.Text = "1";
            if (t2.Text.ToString() == "" && c2.Checked == true)
                t2.Text = "1";
            if (t3.Text.ToString() == "" && c3.Checked == true)
                t3.Text = "1";
            if (t4.Text.ToString() == "" && c4.Checked == true)
                t4.Text = "1";
            if (t5.Text.ToString() == "" && c5.Checked == true)
                t5.Text = "1";
            if (t6.Text.ToString() == "" && c6.Checked == true)
                t6.Text = "1";
            if (t7.Text.ToString() == "" && c7.Checked == true)
                t7.Text = "1";
            if (t8.Text.ToString() == "" && c8.Checked == true)
                t8.Text = "1";
            if (t9.Text.ToString() == "" && c9.Checked == true)
                t9.Text = "1";
            if (t10.Text.ToString() == "" && c10.Checked == true)
                t10.Text = "1";
            if (t11.Text.ToString() == "" && c11.Checked == true)
                t11.Text = "1";
            if (t12.Text.ToString() == "" && c12.Checked == true)
                t12.Text = "1";
            if (t13.Text.ToString() == "" && c13.Checked == true)
                t13.Text = "1";
            if (t14.Text.ToString() == "" && c14.Checked == true)
                t14.Text = "1";
            if (t15.Text.ToString() == "" && c15.Checked == true)
                t15.Text = "1";
            if (t16.Text.ToString() == "" && c16.Checked == true)
                t16.Text = "1";
            if (t17.Text.ToString() == "" && c17.Checked == true)
                t17.Text = "1";
            if (t18.Text.ToString() == "" && c18.Checked == true)
                    t18.Text = "1";
            if (t19.Text.ToString() == "" && c19.Checked == true)
                t19.Text = "1";

            if (t20.Text.ToString() == "" && c20.Checked == true)
                    t20.Text = "1";
            if (t21.Text.ToString() == "" && c21.Checked == true)
                t21.Text = "1";
            if (t22.Text.ToString() == "" && c22.Checked == true)
                t22.Text = "1";
            if (t23.Text.ToString() == "" && c23.Checked == true)
                t23.Text = "1";
            if (t24.Text.ToString() == "" && c24.Checked == true)
                t24.Text = "1";
            if (t25.Text.ToString() == "" && c25.Checked == true)
                    t25.Text = "1";
            if (t26.Text.ToString() == "" && c26.Checked == true)
                t26.Text = "1";
            if (t27.Text.ToString() == "" && c27.Checked == true)
                t27.Text = "1";
            if (t28.Text.ToString() == "" && c28.Checked == true)
                t28.Text = "1";
            if (t29.Text.ToString() == "" && c29.Checked == true)
                t29.Text = "1";
            if (t30.Text.ToString() == "" && c30.Checked == true)
                t30.Text = "1";
            if (t31.Text.ToString() == "" && c31.Checked == true)
                t31.Text = "1";

              
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            t1.Enabled = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            t2.Enabled = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            t3.Enabled = true;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            t4.Enabled = true;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            t5.Enabled = true;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            t6.Enabled = true;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            t7.Enabled = true;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            t8.Enabled = true;
        }

        private void checkBox33_CheckedChanged(object sender, EventArgs e)
        {
            t9.Enabled = true;
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            t10.Enabled = true;
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            t11.Enabled = true;
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            t12.Enabled = true;
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            t13.Enabled = true;
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            t14.Enabled = true;
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            t15.Enabled = true;
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            t16.Enabled = true;
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            t20.Enabled = true;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            t21.Enabled = true;
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            t22.Enabled = true;
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            t23.Enabled = true;
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            t24.Enabled = true;
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            t25.Enabled = true;
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            t26.Enabled = true;
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            t27.Enabled = true;
        }

        private void checkBox34_CheckedChanged(object sender, EventArgs e)
        {
            t28.Enabled = true;
        }

        private void checkBox32_CheckedChanged(object sender, EventArgs e)
        {
            t29.Enabled = true;
        }

        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
            t30.Enabled = true;
        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            t31.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //BAG IN BOX
            c1.Checked = false;
            c2.Checked = false;
            c3.Checked = false;
            c4.Checked = false;
            t1.Clear();
            t2.Clear();
            t3.Clear();
            t4.Clear();
            t1.Enabled = false;
            t2.Enabled = false;
            t3.Enabled = false;
            t4.Enabled = false;

            //Recarga
            t5.Clear();
            t6.Clear();
            t7.Clear();
            t9.Clear();
            t8.Clear();
            c5.Checked = false;
            c6.Checked = false;
            c7.Checked = false;
            c8.Checked = false;
            c9.Checked = false;
            t8.Enabled = false;
            t5.Enabled = false;
            t6.Enabled = false;
            t7.Enabled = false;
            t9.Enabled = false;

            //2LT
            t10.Clear();
            t11.Clear();
            t12.Clear();
            c10.Checked = false;
            c11.Checked = false;
            c12.Checked = false;
            t10.Enabled = false;
            t11.Enabled = false;
            t12.Enabled = false;

            //1LT
            t13.Clear();
            t14.Clear();
            t15.Clear();
            t16.Clear();
            c13.Checked = false;
            c14.Checked = false;
            c15.Checked = false;
            c16.Checked = false;
            t13.Enabled = false;
            t14.Enabled = false;
            t15.Enabled = false;
            t16.Enabled = false;


            //700
            t17.Clear();
            t18.Clear();
            t19.Clear();
            t20.Clear();
            t21.Clear();
            c17.Checked = false;
            c18.Checked = false;
            c19.Checked = false;
            c20.Checked = false;
            c21.Checked = false;
            t17.Enabled = false;
            t18.Enabled = false;
            t19.Enabled = false;
            t20.Enabled = false;
            t21.Enabled = false;

            //350
            t22.Clear();
            t23.Clear();
            c22.Checked = false;
            c23.Checked = false;
            t22.Enabled = false;
            t23.Enabled = false;

            //500
            t24.Clear();
            t25.Clear();
            t26.Clear();
            t27.Clear();
            t28.Clear();
            c24.Checked = false;
            c25.Checked = false;
            c26.Checked = false;
            c27.Checked = false;
            c28.Checked = false;
            t24.Enabled = false;
            t25.Enabled = false;
            t26.Enabled = false;
            t27.Enabled = false;
            t28.Enabled = false;

            //vidrio
            t29.Clear();
            t30.Clear();
            t31.Clear();
            c29.Checked = false;
            c30.Checked = false;
            c31.Checked = false;
            t29.Enabled = false;
            t30.Enabled = false;
            t31.Enabled = false;

            label20.Text = "0";

            dt.Rows.Clear();
        }

        private void t1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            convierte();
            dt.Rows.Clear();
            Agregafila();
        }

   
        
        
    }
}
