using System;
using System.Windows.Forms;


namespace calculator
{
    //class named Form1 that inherits from Form, which is a standard Windows Forms class.

    public partial class Form1 : Form
    {
        double firstValue, secondValue;  //This line declare two variables of type double named firstValue and secondValue.
        double result;     //This line declares a variable named result of type double. 
        string operators;  //This line declares a variable named operators of type string


        public Form1()  //This is the constructor of Form1.
        {
            //It initializes the form components and loops through each ToolStripMenuItem in a dropdown menu and assigns the menu_Click event handler to the Click event of each item,

            InitializeComponent();

            foreach (ToolStripMenuItem item in menu.DropDownItems)
            {
                item.Click += menu_Click;
            }
        }


        //The Form1_Load method is called when the form is loaded. It sets the initial width and height of the form and the text box width.
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 337;
            this.Height = 562;
            textBox.Width = 312;
            
        }


        //This method is an event handler for the button labeled "0." It appends "0" to the text box unless the current text is already "0," in which case it doesn't change the text.
        private void zeroBt_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "0";
            }
            else
            {
                textBox.Text += "0";
            }
        }


        //following methods 'oneBt_Click' 'twoBt_Click' .. to.. 'nineBt_Click'
        //These methods are event handlers for button clicks, specifically for digits 0 to 9
        private void oneBt_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "1";
            }
            else
            {
                textBox.Text += "1";
            }
        }

        private void twoBt_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "2";
            }
            else
            {
                textBox.Text += "2";
            }
        }

        private void threeBt_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "3";
            }
            else
            {
                textBox.Text += "3";
            }
        }

        private void fourBt_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "4";
            }
            else
            {
                textBox.Text += "4";
            }
        }

        private void fiveBt_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "5";
            }
            else
            {
                textBox.Text += "5";
            }
        }

        private void sixBt_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "6";
            }
            else
            {
                textBox.Text += "6";
            }
        }

        private void sevenBt_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "7";
            }
            else
            {
                textBox.Text += "7";
            }
        }

        private void eightBt_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "8";
            }
            else
            {
                textBox.Text += "8";
            }
        }

        private void nineBt_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "9";
            }
            else
            {
                textBox.Text += "9";
            }
        }

        //This method handles the decimal point button. It adds a decimal point to the text box if there isn't already one present.
        private void dotBt_Click(object sender, EventArgs e)
        {
            if (!textBox.Text.Contains("."))
            {
                textBox.Text += ".";
            }
        }


        //This method is the event handler for when the "plus" button (plusBt) is clicked. It parses the value in the textBox control as a double, clears the text box, and sets the operators variable to "+".
        private void plusBt_Click(object sender, EventArgs e)
        {
            firstValue = double.Parse(textBox.Text);
            textBox.Clear();
            operators = "+";
        }


        //This method is the event handler for when the "minus" button (minusBt) is clicked.it parses the value in the textBox control as a double, clears the text box, and sets the operators variable to "-".
        private void minusBt_Click(object sender, EventArgs e)
        {
            try
            {
                firstValue = double.Parse(textBox.Text);
                textBox.Clear();
                operators = "-";
            }

            catch 
            {
                textBox.Text = "error";
                textBox.Clear();
            }
        }


        //It follows the same pattern as the previous methods but sets the operators variable to "*".
        private void multiplyBt_Click(object sender, EventArgs e)
        {
            firstValue = double.Parse(textBox.Text);
            textBox.Clear();
            operators = "*";
        }


        //It also follows the same pattern as the previous methods but sets the operators variable to "/".
        private void divideBt_Click(object sender, EventArgs e)
        {
            firstValue = double.Parse(textBox.Text);
            textBox.Clear();
            operators = "/";
        }


        //This method is the event handler for when the "plus/minus" button is clicked.
        // If the text box already contains a "-" it removes it  otherwise it adds a "-" to the beginning of the text in 'textBox'
        private void plsmiBt_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Contains("-"))
            {
                textBox.Text = textBox.Text.Trim('-');
            }
            else
            {
                textBox.Text = "-" + textBox.Text;
            }
        }


        //This method calculates the result based on the selected operator (operators). It parses the current text in the text box to a double (secondValue), performs the corresponding arithmetic operation, and displays the result in the text box.
        private void equalBt_Click(object sender, EventArgs e)
        {
                switch (operators)
                {
                    case "+":
                        secondValue = double.Parse(textBox.Text);
                        result = firstValue + secondValue;
                        textBox.Text = result.ToString();
                        break;

                    case "-":
                        secondValue = double.Parse(textBox.Text);
                        result = firstValue - secondValue;
                        textBox.Text = result.ToString();
                        break;

                    case "*":
                        secondValue = double.Parse(textBox.Text);
                        result = firstValue * secondValue;
                        textBox.Text = result.ToString();
                        break;

                    case "/":
                        secondValue = double.Parse(textBox.Text);
                        result = firstValue / secondValue;
                        textBox.Text = result.ToString();
                        break;
                    case "%":
                        secondValue = double.Parse(textBox.Text);
                        result = firstValue % secondValue;
                        textBox.Text = result.ToString();
                        break;

                }
        }


        //This method is triggered when the "C" (clearBt) button is clicked.
        //It sets both firstValue and secondValue variables to 0 to clear any stored values.
        //It also sets the text box content to "0" to visually clear the display.
        private void clearBt_Click(object sender, EventArgs e)
        {
            firstValue = 0; 
            secondValue = 0;
            textBox.Text = "0";
        }


        //This method is triggered when the "CE" (Clear Entry) button is clicked.
        //It clears the text of the textBox control and sets f (which is initially set to firstValue.ToString()) and s (which is initially set to secondValue.ToString()) to empty strings, effectively clearing any input without resetting the stored values to 0.
        private void clearentryBt_Click(object sender, EventArgs e)
        {
            string f, s;

            textBox.Text = "0";

            f = firstValue.ToString();
            s = secondValue.ToString();

            f = "";
            s = "";

        }


        //this method removes the last character from the text in the textBox control if the text length is greater than 0. If the text becomes empty after backspacing, it sets the text to "0".
        private void backspcBt_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length > 0)
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1);
            }
            if (textBox.Text == "")
            {
                textBox.Text = "0";
            }
        }


        //This method is the event handler for when the "minus" button (minusBt) is clicked.it parses the value in the textBox control as a double, clears the text box, and sets the operators variable to "-".
        private void modulBt_Click(object sender, EventArgs e)
        {
            firstValue = double.Parse(textBox.Text);
            textBox.Clear();
            operators = "%";
        }


        // when the "π" button is clicked, it sets the text box value to the constant value of π (pi).
        private void piBt_Click(object sender, EventArgs e)
        {
            textBox.Text = "3.141592";
        }


        //This method calculates the base-10 logarithm of a number. It parses the text in the text box to a double, calculates the logarithm using Math.Log10(), and displays the result in the text box.
        private void logBt_Click(object sender, EventArgs e)
        {
            double logg = double.Parse(textBox.Text);
            logg = Math.Log10(logg);
            textBox.Text = logg.ToString();
        }


        // the method calculates the square root of a number. It parses the text in the text box to a double, calculates the square root using Math.Sqrt(), and displays the result in the text box.
        private void sqrtBt_Click(object sender, EventArgs e)
        {
            double sqr = double.Parse(textBox.Text);
            sqr = Math.Sqrt(sqr);
            textBox.Text = sqr.ToString();
        }


        //when the "x²" button is clicked, this method calculates the square of a number. It parses the text in the text box to a double, squares the number, and then converts the result back to a string to display it in the text box.
        private void x2Bt_Click(object sender, EventArgs e)
        {
            double x2;
            x2 = double.Parse(textBox.Text) * double.Parse(textBox.Text);
            textBox.Text = x2.ToString();
        }


        //This method calculates the cube of a number. It parses the current text in the text box to doubles (w, y, z), calculates their product (w * y * z), and displays the result (x3) in the text box.
        private void x3Bt_Click(object sender, EventArgs e)
        {
            double x3 , w , y , z;
            w = double.Parse(textBox.Text);
            y = double.Parse(textBox.Text);
            z = double.Parse(textBox.Text);
            x3 = (w * y * z);
            textBox.Text = x3.ToString();

            
        }


        //This method calculates the sine of a number.It first parses the content of the text box(textBox.Text) to a double (sn).It then calculates the sine of sn using Math.Sin(sn).Finally, it sets the text box content to the calculated sine value converted to a string.
        private void sinBt_Click(object sender, EventArgs e)
        {
            double sn = double.Parse(textBox.Text);
            sn = Math.Sin(sn);
            textBox.Text = sn.ToString();
        }


        //This method calculates the cosine of a number.Similar to sinBt_Click, it parses the content of the text box to a double (cs), calculates the cosine using Math.Cos(cs), and sets the text box content to the calculated cosine value converted to a string.
        private void cosBt_Click(object sender, EventArgs e)
        {
            double cs = double.Parse(textBox.Text);
            cs = Math.Cos(cs);
            textBox.Text = cs.ToString();
        }


        //This method calculates the tangent of a number.Similar to the previous methods, it parses the content of the text box to a double (tn), calculates the tangent using Math.Tan(tn), and sets the text box content to the calculated tangent value converted to a string.
        private void tanBt_Click(object sender, EventArgs e)
        {
            double tn = double.Parse(textBox.Text);
            tn = Math.Tan(tn);
            textBox.Text = tn.ToString();
        }


        //This method calculates the tangent of a number.Similar to the previous methods, it parses the content of the text box to a double (tn), calculates the tangent using Math.Tan(tn), and sets the text box content to the calculated tangent value converted to a string.
        private void btn1x_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(1.0 / double.Parse(textBox.Text));
            textBox.Text = a.ToString();
        }


        //This method is triggered when the "Decimal" button is clicked.It parses the content of the text box(textBox.Text) to a double (dec).It then converts dec to two integers, i1 using Convert.ToInt32(dec) and i2 using a cast to int.Finally, it sets the text box content to i2.ToString(), which represents the integer part of the decimal number.
        private void decimalBt_Click(object sender, EventArgs e)
        {
            double dec = double.Parse(textBox.Text);
            int i1 = Convert.ToInt32(dec);
            int i2 = (int)dec;
            textBox.Text = i2.ToString();
        }


        //This method is triggered when the "Binary" button is clicked.It parses the content of the text box to an integer(b) using int.Parse(textBox.Text).It then converts b to its binary representation using Convert.ToString(b, 2).Finally, it sets the text box content to the binary representation of the integer.
        private void binary_Click(object sender, EventArgs e)
        {
            int b = int.Parse(textBox.Text);
            textBox.Text = Convert.ToString(b , 2);
        }


        //This method is triggered when the "Hex" button is clicked.Similar to binary_Click, it parses the content of the text box to an integer(h), converts h to its hexadecimal representation using Convert.ToString(h, 16), and sets the text box content to the hexadecimal representation.
        private void hexaBt_Click(object sender, EventArgs e)
        {
            int h = int.Parse(textBox.Text);
            textBox.Text = Convert.ToString(h , 16);
        }


        //This method is triggered when the "Oct" button is clicked.Similar to the previous methods, it parses the content of the text box to an integer(o), converts o to its octal representation using Convert.ToString(o, 8), and sets the text box content to the octal representation.
        private void octaBt_Click(object sender, EventArgs e)
        {
            int o = int.Parse(textBox.Text);
            textBox.Text = Convert.ToString(o , 8);
        }


        //This method is triggered when the "Standard" menu item is clicked.It sets the width of the form(this.Width), height of the form(this.Height), and width of the text box(textBox.Width) to specific values, making adjustments to the layout to fit a standard calculator view.
        private void standardMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 337;
            this.Height = 562;
            textBox.Width = 312;
        }


        //This method is triggered when the "Scientific" menu item is clicked.Similar to standardMenuItem_Click, it sets the width and height of the form and the width of the text box to different values, adjusting the layout to accommodate a scientific calculator view.
        private void scientificMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 579;
            this.Height = 562;
            textBox.Width = 551;
        }


        //This method is an event handler for the click event of menu items in general (not specific to "Standard" or "Scientific").It casts the sender object to a ToolStripMenuItem(clickeditem) to access its properties.
        //It checks if the clicked menu item is part of the drop-down menu (menu.DropDownItems.Contains(clickeditem)).If the clicked item is part of the menu, it sets the text of a label(label.Text) to the text of the clicked item, possibly for displaying the selected mode or operation.
        private void menu_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickeditem = (ToolStripMenuItem)sender;
            if (menu.DropDownItems.Contains(clickeditem))
            {
                label.Text = clickeditem.Text;
            }
        }


        //This method is triggered when the "Exit" menu item is clicked.It displays a confirmation dialog box asking the user to confirm if they want to exit.If the user clicks "Yes" (DialogResult.Yes), it exits the application using Application.Exit().
        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitcal;
            exitcal = MessageBox.Show("Confirm if you want to Exit", "Calculator", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exitcal == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
