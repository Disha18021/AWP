using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac2b1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        class AreaCalculator
        {
            public double CalculateArea(double sideLength)
            {
                return sideLength * sideLength;
            }


            public double CalculateArea(double length, double width)
            {
                return length * width;
            }
        
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            AreaCalculator calculator = new AreaCalculator();

            double sideLength = System.Convert.ToDouble(TextBox1.Text);

            double areaSquare = calculator.CalculateArea(sideLength);
            Square.Text = "Area of the square with side length " + sideLength + " : " +  areaSquare;

            double length = System.Convert.ToDouble(TextBox2.Text);

            double width = System.Convert.ToDouble(TextBox3.Text);

            double areaRectangle = calculator.CalculateArea(length, width);
            Rectangle.Text = "Area of the rectangle with length " + length + " and width "+ width + " : " + areaRectangle;

        }
    }
}