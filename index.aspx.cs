using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculadoraPOO
{
    public partial class INDEX : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //valido si se ejecuta evento de postback
            if (!IsPostBack)
            {
                //inicializo variables de sesion para almacenar temporales
                Session["num1"] = "0";
                Session["oper"] = "";
                Session["eq"] = "";
            }
            
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            //valido temporales
            if ((string)Session["oper"] == "")
            {
                //valido si hay 0
                if (lblres.Text == "0")
                {
                    lblres.Text = "1";
                }
                else
                {
                    lblres.Text = lblres.Text + "1";
                }
            }
            else
            {
                Session["oper"] = "";
                lblres.Text = "1";
            }

        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            //valido temporales
            if ((string)Session["oper"] == "")
            {
                //valido si hay 0
                if (lblres.Text == "0")
                {
                    lblres.Text = "2";
                }
                else
                {
                    lblres.Text = lblres.Text + "2";
                }
            }
            else
            {
                Session["oper"] = "";
                lblres.Text = "2";
            }
        }

        protected void btnsum_Click(object sender, EventArgs e)
        {
            //ejecuto funcion de validacion
            validacion();

            Session["oper"] = "+";
            Session["eq"] = "+";

            //muestro resultado y proceso
            lblproc.Text = lblproc.Text + " " + lblres.Text + " +";

        }

        protected void btn3_Click(object sender, EventArgs e)
        {
            //valido temporales
            if ((string)Session["oper"] == "")
            {
                //valido si hay 0
                if (lblres.Text == "0")
                {
                    lblres.Text = "3";
                }
                else
                {
                    lblres.Text = lblres.Text + "3";
                }
            }
            else
            {
                Session["oper"] = "";
                lblres.Text = "3";
            }
        }

        protected void btn4_Click(object sender, EventArgs e)
        {
            //valido temporales
            if ((string)Session["oper"] == "")
            {
                //valido si hay 0
                if (lblres.Text == "0")
                {
                    lblres.Text = "4";
                }
                else
                {
                    lblres.Text = lblres.Text + "4";
                }
            }
            else
            {
                Session["oper"] = "";
                lblres.Text = "4";
            }
        }

        protected void btn5_Click(object sender, EventArgs e)
        {
            //valido temporales
            if ((string)Session["oper"] == "")
            {
                //valido si hay 0
                if (lblres.Text == "0")
                {
                    lblres.Text = "5";
                }
                else
                {
                    lblres.Text = lblres.Text + "5";
                }
            }
            else
            {
                Session["oper"] = "";
                lblres.Text = "5";
            }
        }

        protected void btn6_Click(object sender, EventArgs e)
        {
            //valido temporales
            if ((string)Session["oper"] == "")
            {
                //valido si hay 0
                if (lblres.Text == "0")
                {
                    lblres.Text = "6";
                }
                else
                {
                    lblres.Text = lblres.Text + "6";
                }
            }
            else
            {
                Session["oper"] = "";
                lblres.Text = "6";
            }
        }

        protected void btn7_Click(object sender, EventArgs e)
        {
            //valido temporales
            if ((string)Session["oper"] == "")
            {
                //valido si hay 0
                if (lblres.Text == "0")
                {
                    lblres.Text = "7";
                }
                else
                {
                    lblres.Text = lblres.Text + "7";
                }
            }
            else
            {
                Session["oper"] = "";
                lblres.Text = "7";
            }
        }

        protected void btn8_Click(object sender, EventArgs e)
        {
            //valido temporales
            if ((string)Session["oper"] == "")
            {
                //valido si hay 0
                if (lblres.Text == "0")
                {
                    lblres.Text = "8";
                }
                else
                {
                    lblres.Text = lblres.Text + "8";
                }
            }
            else
            {
                Session["oper"] = "";
                lblres.Text = "8";
            }
        }

        protected void btn9_Click(object sender, EventArgs e)
        {
            //valido temporales
            if ((string)Session["oper"] == "")
            {
                //valido si hay 0
                if (lblres.Text == "0")
                {
                    lblres.Text = "9";
                }
                else
                {
                    lblres.Text = lblres.Text + "9";
                }
            }
            else
            {
                Session["oper"] = "";
                lblres.Text = "9";
            }
        }

        protected void btn0_Click(object sender, EventArgs e)
        {
            //valido temporales
            if ((string)Session["oper"] == "")
            {
                //valido si hay 0
                if (lblres.Text == "0")
                {
                    lblres.Text = "0";
                }
                else
                {
                    lblres.Text = lblres.Text + "0";
                }
            }
            else
            {
                Session["oper"] = "";
                lblres.Text = "0";
            }
        }

        protected void btneq_Click(object sender, EventArgs e)
        {
            lblproc.Text = lblproc.Text + " " + lblres.Text + " =";

            //ejecuto funcion de validacion
            validacion();

            Session["oper"] = "";
            Session["eq"] = "";
            Session["num1"] = "0";

            //muestro resultado y proceso
            lblproc.Text = lblproc.Text + " " + lblres.Text;
            lblhist.Text = lblproc.Text + "</br>" + lblhist.Text;
            lblproc.Text = "";

        }

        protected void btnres_Click(object sender, EventArgs e)
        {
            //ejecuto funcion de validacion
            validacion();

            Session["oper"] = "-";
            Session["eq"] = "-";

            //muestro resultado y proceso
            lblproc.Text = lblproc.Text + " " + lblres.Text + " -";
        }

        protected void btnmult_Click(object sender, EventArgs e)
        {
            //ejecuto funcion de validacion
            validacion();

            Session["oper"] = "x";
            Session["eq"] = "x";

            //muestro resultado y proceso
            lblproc.Text = lblproc.Text + " " + lblres.Text + " x";
            
        }
        //funcion de validacion para la ejecucion de los metodos del objeto
        public void validacion()
        {
            //variables
            int resultado;

            //creo el objeto
            Calculadora Proceso = new Calculadora();

            if ((string)Session["num1"] != "0")
            {
                //valido si operador cambio
                if ((string)Session["eq"] == "+")
                {
                    //calculo suma
                    resultado = Proceso.sumar(Int32.Parse((string)Session["num1"]), Int32.Parse(lblres.Text));
                }
                else if ((string)Session["eq"] == "-")
                {
                    //calculo resta
                    resultado = Proceso.restar(Int32.Parse((string)Session["num1"]), Int32.Parse(lblres.Text));
                }
                else if ((string)Session["eq"] == "x")
                {
                    //calculo resta
                    resultado = Proceso.multiplicar(Int32.Parse((string)Session["num1"]), Int32.Parse(lblres.Text));
                }
                else
                {
                    //valido division zero
                    if (lblres.Text == "0")
                    {
                        resultado = 0;
                    }
                    else
                    {
                        //calculo resta
                        resultado = Proceso.dividir(Int32.Parse((string)Session["num1"]), Int32.Parse(lblres.Text));
                    }

                }

            }
            else
            {
                resultado = Int32.Parse(lblres.Text);
            }

            //asigno resultado en variables de sesion
            Session["num1"] = string.Format("{0}", resultado);
            lblres.Text = string.Format("{0}", resultado);
        }

        protected void btndiv_Click(object sender, EventArgs e)
        {
            //ejecuto funcion de validacion
            validacion();

            Session["oper"] = "/";
            Session["eq"] = "/";

            //muestro resultado y proceso
            lblproc.Text = lblproc.Text + " " + lblres.Text + " /";
        }

        protected void btnc_Click(object sender, EventArgs e)
        {
            lblres.Text = "0";
            Session["oper"] = "";
            Session["eq"] = "";
            Session["num1"] = "0";
            lblproc.Text = "";
        }

        protected void btnce_Click(object sender, EventArgs e)
        {
            lblres.Text = "0";
        }
    }
    //creo la clase calculadora
    class Calculadora
    {
        
        //metodos publicos
        public int sumar(int num1, int num2)
        {
            //variables
            int res;

            //procesamiento
            res = num1 + num2;

            //devuelvo el resultado
            return res;

        }
        public int restar(int num1, int num2)
        {
            //variables
            int res;

            //procesamiento
            res = num1 - num2;

            //devuelvo el resultado
            return res;
        }
        public int multiplicar(int num1, int num2)
        {
            //variables
            int res;

            //procesamiento
            res = num1 * num2;

            //devuelvo el resultado
            return res;
        }
        public int dividir(int num1, int num2)
        {
            //variables
            int res;

            //procesamiento
            res = num1 / num2;

            //devuelvo el resultado
            return res;
        }
    }
}