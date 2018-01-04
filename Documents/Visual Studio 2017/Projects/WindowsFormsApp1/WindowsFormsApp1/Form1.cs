using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // firstClicked points to the first label control
        // that the player clicks, but it will be null
        // if the player hasn't clicked a label yet
        Label firstClicked = null;

        // secondClicked points to the second Label control
        // that the player clicks
        Label secondClicked = null;

        // use this random object to choose random icons for the aquares
        Random random = new Random();

        // variable to keep track of the time played
        int timePlayed = 0;

        // each of these letters is an interesting icon
        // in thhe webdings font,
        // and each icon appears twice in this list
        List<string> icons = new List<string>()
        {
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"
        };

        public Form1()
        {
            InitializeComponent();

            AssignIconsToSquares();
        }

        /// <summary> 
        /// Assign each icon from the list of icons to a random square
        /// </summary>
        private void AssignIconsToSquares()
        {
            // the tableLayoutPanel has 16 labels,
            // and the icon list has 16 icons,
            // so an icon is plulled at random from the list
            // and added to each label
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }

        /// <summary>
        /// Every label's Click event is handled by this even handler
        /// </summary>
        /// <param name="sender">The label that was clicked</param>
        /// <param name="e"></param>
        private void label_Click(object sender, EventArgs e)
        {
            // the timer is only on after two non-matching
            // icons have been shown to the player,
            // so ignore any clicks if the time is running
            if (timer1.Enabled == true)
            {
                return;
            }

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                // if the clicked lael is black, the player clicked
                // and icon that's already been revealded --
                // ignore the click
                if (clickedLabel.ForeColor == Color.Black)
                {
                    return;
                }

                // if firstClicked is null, this is the first icon
                // in the pair that the player clicked,
                // so set firstClicked to the label that the player
                // clicked, change its color to black, and return
                if (firstClicked == null)
                {
                    timer2.Start();
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;

                    return;
                }

                // if the player gets this far, the timer isn't
                // running and firstClicked isn't null,
                // so this must be the second icon that the player clicked
                // set its color to black
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;
                
                // check to see if the player won
                CheckForWinner();

                // if the player clicked two mathing icons, keep them
                // black and rest firstClicled amd secondClicked
                // so the player can click another icon
                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    System.Media.SystemSounds.Beep.Play();
                    return;
                }
                System.Media.SystemSounds.Asterisk.Play();
                // if the player gets this far, the player
                // clicked two defferent icons, so start the
                // time (which will wait three quarters of
                // a second, and then hide the icons)
                timer1.Start();
            }

        }

        /// <summary>
        /// this timer is started when the player clicks
        /// two icons that don't match,
        /// so it counts three quarters of a second
        /// and then turns itself of and hides both icons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            // stop the timer
            timer1.Stop();

            // hide both icons
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;
            System.Media.SystemSounds.Hand.Play();
            // reset firstClicked and secondClicked
            // so the next time a label is
            // clicked, the program knows it's the first click
            firstClicked = null;
            secondClicked = null;
        }

        /// <summary>
        /// check every icon to see if it is mathced, by
        /// comparing its forground color to its backgroundcolor.
        /// if all of the icons are mathced the player wins
        /// </summary>
        private void CheckForWinner()
        {
            // go through all of the labels in the TableLayoutPanel,
            // chaking each one to see if its icon is matched
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                    {
                        return;
                    }
                }
            }

            // if the loop didn't return, it didn't find
            // any unmatched icons
            // that means the user won. show a message and close the form
            timer2.Stop();
            MessageBox.Show(text: $"You matched all the icons in {timePlayed} seconds", caption: "Congratulations");
            Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timePlayed += 1;
            timer.Text = timePlayed.ToString();
        }
    }
}
