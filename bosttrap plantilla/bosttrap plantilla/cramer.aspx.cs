using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bosttrap_plantilla
{
    public partial class cramer : System.Web.UI.Page
    {
        MetodoDeCramer metodo = new MetodoDeCramer();
        Calculo calcular = new Calculo();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            metodo.Numero1 = Convert.ToInt32(TextBox1.Text);
            metodo.Numero2 = Convert.ToInt32(TextBox2.Text);
            metodo.Numero3 = Convert.ToInt32(TextBox3.Text);
            metodo.Numero4 = Convert.ToInt32(TextBox4.Text);

            metodo.Numero5 = Convert.ToInt32(TextBox5.Text);
            metodo.Numero6 = Convert.ToInt32(TextBox6.Text);
            metodo.Numero7 = Convert.ToInt32(TextBox7.Text);
            metodo.Numero8 = Convert.ToInt32(TextBox8.Text);

            metodo.Numero9 = Convert.ToInt32(TextBox9.Text);
            metodo.Numero10 = Convert.ToInt32(TextBox10.Text);
            metodo.Numero11 = Convert.ToInt32(TextBox11.Text);
            metodo.Numero12 = Convert.ToInt32(TextBox12.Text);


            TextBox13.Text = "" + calcular.CalCulemos(metodo);
            TextBox17.Text = "" + calcular.CalCulemos5(metodo);
            TextBox21.Text = "" + calcular.CalCulemos9(metodo);
            TextBox16.Text = "" + calcular.CalCulemos3(metodo);
            TextBox20.Text = "" + calcular.CalCulemo8(metodo);
            TextBox24.Text = "" + calcular.CalCulemos12(metodo);
            TextBox29.Text =""  + calcular.CalCulemos(metodo);
            TextBox59.Text = "" + calcular.CalCulemos(metodo);

            TextBox25.Text = "X";
            TextBox56.Text = "X";
            TextBox57.Text = "Y";
            TextBox58.Text = "Z";
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            int B;
            B = Convert.ToInt32(TextBox2.Text);
            TextBox30.Text = ("" + B);
            TextBox60.Text = ("" + B);
            TextBox26.Text = "Y";
            int a;
            a = Convert.ToInt32(TextBox2.Text);

            if (a > 0)
            {

                TextBox14.Text = ("+" + a);                

            }
            else
            {

                TextBox14.Text = (" " + a);
               
            }
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
            int B;
            B = Convert.ToInt32(TextBox3.Text);
            TextBox31.Text = ("" + B);
            TextBox61.Text = ("" + B);
            TextBox27.Text = "Z";
            int b;
            b = Convert.ToInt32(TextBox3.Text);
            if (b > 0)
            {
                TextBox15.Text = ("+" + b);
                
            }
            else
            {
                TextBox15.Text = (" " + b);
               
            }
        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {
            int B;
            B = Convert.ToInt32(TextBox4.Text);
            TextBox32.Text = ("" + B);
            TextBox28.Text = "TI";
        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {
            int B;
            B = Convert.ToInt32(TextBox6.Text);
            TextBox34.Text = ("" + B);
            TextBox63.Text = ("" + B);
            int b;
            b = Convert.ToInt32(TextBox6.Text);
            if (b > 0)
            {
                TextBox18.Text = ("+" + b);
                
            }
            else
            {
                TextBox18.Text = (" " + b);
               
            }

        }

        protected void TextBox7_TextChanged(object sender, EventArgs e)
        {
            int B;
            B = Convert.ToInt32(TextBox7.Text);
            TextBox35.Text = ("" + B);
            TextBox64.Text = ("" + B);
            int a;
            a = Convert.ToInt32(TextBox7.Text);

            if (a > 0)
            {
                TextBox19.Text = ("+" + a);
                
            }
            else
            {
                TextBox19.Text = (" " + a);
                
            }
        }

        protected void TextBox10_TextChanged(object sender, EventArgs e)
        {
            int B;
            B = Convert.ToInt32(TextBox10.Text);
            TextBox38.Text = ("" + B);
            TextBox66.Text = ("" + B);
            int b;
            b = Convert.ToInt32(TextBox10.Text);
            if (b > 0)
            {
                TextBox22.Text = ("+" + b);
                
            }
            else
            {
                TextBox22.Text = (" " + b);
                
            }

        }

        protected void TextBox11_TextChanged(object sender, EventArgs e)
        {
            int B;
            B = Convert.ToInt32(TextBox11.Text);
            TextBox39.Text = ("" + B);
            TextBox67.Text = ("" + B);
            int a;
            a = Convert.ToInt32(TextBox11.Text);

            if (a > 0)
            {
                TextBox23.Text = ("+" + a);               

            }
            else
            {
                TextBox23.Text = (" " + a);
                
            }
        }

        protected void TextBox17_TextChanged(object sender, EventArgs e)
        {
           
        }

        protected void TextBox18_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void TextBox19_TextChanged(object sender, EventArgs e)
        {
           
        }

        protected void TextBox20_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void TextBox13_TextChanged(object sender, EventArgs e)
        {
           
        }

        protected void TextBox29_TextChanged(object sender, EventArgs e)
        {
           
        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {
            int B;
            B = Convert.ToInt32(TextBox5.Text);
            TextBox33.Text = ("" + B);
            TextBox62.Text = ("" + B);


        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox8_TextChanged(object sender, EventArgs e)
        {
            int B;
            B = Convert.ToInt32(TextBox8.Text);
            TextBox36.Text = ("" + B);
        }

        protected void TextBox9_TextChanged(object sender, EventArgs e)
        {
            int B;
            B = Convert.ToInt32(TextBox9.Text);
            TextBox37.Text = ("" + B);
            TextBox65.Text = ("" + B);
        }

        protected void TextBox12_TextChanged(object sender, EventArgs e)
        {
            int B;
            B = Convert.ToInt32(TextBox12.Text);
            TextBox40.Text = ("" + B);
        }
    }
}