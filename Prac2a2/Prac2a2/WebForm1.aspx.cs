
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac2a2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        TextBox textBox1;
        Label resultLabel;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Creating and setting properties for Label
            Label label1 = new Label();
            label1.ID = "Label1";
            label1.Text = "Enter amount in USD: ";
            this.form1.Controls.Add(label1);

            // Creating and setting properties for TextBox
            textBox1 = new TextBox();
            textBox1.ID = "TextBox1";
            this.form1.Controls.Add(textBox1);

            // Line break
            this.form1.Controls.Add(new LiteralControl("<br />"));

            // Creating and setting properties for Button
            Button button1 = new Button();
            button1.ID = "Button1";
            button1.Text = "Convert to INR";
            button1.Click += new EventHandler(Button1_Click);
            this.form1.Controls.Add(button1);

            // Line break
            this.form1.Controls.Add(new LiteralControl("<br /><br />"));

            // Creating and setting properties for Result Label
            resultLabel = new Label();
            resultLabel.ID = "ResultLabel";
            this.form1.Controls.Add(resultLabel);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double usdValue = double.Parse(textBox1.Text);
            ConversionService obj = new ConversionService();
            double inrValue = obj.ConvertUsdToInr(usdValue);
            resultLabel.Text = string.Format("USD {0:0.00} = INR {1:0.00}", usdValue, inrValue);
        }
    }

    public class ConversionService
    {
        private const double ConversionRate = 83.80;

        public double ConvertUsdToInr(double usdValue)
        {
            return usdValue * ConversionRate;
        }
    }
}