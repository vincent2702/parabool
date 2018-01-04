using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Quiz
{
    public partial class Form1 : Form
    {
        // Create a Random object called randomizer
        // to generate random number.
        Random randomizer = new Random();

        // These integer variables store the numbers
        // for the addition problem.
        int addend1;
        int addend2;

        // these integer variables store the numbers
        // for the subtraction problem
        int minuend;
        int subtrahend;

        // these integer variables store the numbers
        // for the muktiplication problem
        int multiplicand;
        int multiplier;

        // these integer variables store the numbers
        // for the division problem
        int dividend;
        int divisor;

        // this integer variable keeps track of the
        // remaining time.
        int timeLeft;

        /// <summary>
        /// Start the quiz by filling in all of the problems
        /// and starting th timer.
        /// </summary>
        public void StartTheQuiz()
        {
            // fill in the addition problem
            // Generate two random numbers to add.
            // store the values in the variable 'addend1' and 'addend2'.
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            // convert the two randomly generated numbers
            // into strings so that they can be displayed
            // in the label controls
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            // 'sum'is the name of the NumericUpDown control.
            // this step makes sure its value is zero before
            // adding any values to it
            sum.Value = 0;

            // fill in the subtraction problem
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;

            // fill in the multiplication problem
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timeRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            // fill in the division problem
            dividend = randomizer.Next(2, 11);
            divisor = randomizer.Next(2, 11);
            dividedLeftLabel.Text = multiplicand.ToString();
            dividedRightLabel.Text = multiplier.ToString();
            quotient.Value = 0;

            // start the timer
            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                // if checkTheAnswer returns true, then the user
                // got the answer right. stop the time
                // and show a MessageBox
                timer1.Stop();
                MessageBox.Show("You got all the answers right!", "Congratulations!");
                startButton.Enabled = true;
            }
            if (timeLeft > 0)
            {
                if (timeLeft < 5)
                {
                    timeLabel.BackColor = Color.Red;
                }
                // display the new time left
                // by updating the time left label
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + "Seconds";
            }
            else
            {
                // if the user ran out of time, stop the time, show
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                timeLabel.Text = "time is up!";
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                MessageBox.Show("you didn't finish in time.", "sorry!");
                startButton.Enabled = true;
            }
        }

        /// <summary>
        /// Check the answer to see if the user got everything right
        /// </summary>
        /// <returns> True if answer's correct, false otherwise. </returns>
        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value) 
                && (minuend - subtrahend == difference.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            // select the whole answer in the NumericUpdDwon control.
            NumericUpDown answerBox = sender as NumericUpDown;
            
            if (answerBox != null)
            {

                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void answer_hint(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;
            if (answerBox != null)
            {
                if ((addend1 + addend2 == sum.Value)
                    || (minuend - subtrahend == difference.Value)
                    || (multiplicand * multiplier == product.Value)
                    || (dividend / divisor == quotient.Value))
                {
                    System.Media.SystemSounds.Beep.Play(); ;
                }
            }
        }
    }
}
