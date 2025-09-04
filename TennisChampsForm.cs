/*
 * Project:         Women's Tennis Champions Program
 * Date:            11/01/23
 * Developed By:    E. P. Hubbs
 * Class Name:      TennisChampsForm
 * Purpose:         Form class to count the entered player's total wins and count all players total back-to-back wins and output them to the form  
 * Uses:            TennisChampsForm form class
 * Last Modified:   9/9/25
*/

namespace PHubbsProgram13
{
    public partial class TennisChampsForm : Form
    {
        public TennisChampsForm()
        {
            InitializeComponent();
        }

        //event click method to display a particular player's total US Open wins throughout their career

        private void btnTotalWins_Click(object sender, EventArgs e)
        {
            string player = string.Empty;
            int numTimes = 0;

            //message box to validate the playername combobox

            if (cboxPlayerName.SelectedItem == null)
            {
                MessageBox.Show("\"You have to select a player!\"", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboxPlayerName.Focus();
                return;
            }

            player = cboxPlayerName.Text;

            //loop to check through total list of champions

            for (int i = 0; i < cboxChampions.Items.Count; i++)
            {
                //check if the chosen player name is the same as the selected player

                if (player == cboxChampions.Items[i].ToString())
                {
                    //increase count if player is found

                    numTimes++;
                }
            }

            //output the count to the form label

            lblOutput.Text = $"{player} won {numTimes.ToString()} US Open championship(s)";
        }

        //click event method to display all of the total back-to-back wins in US Open history

        private void btnBackToBack_Click(object sender, EventArgs e)
        {

            int backToBack = 0;

            //loop to check through the total list of champions

            for (int i = 0; i < cboxChampions.Items.Count - 1; i++)
            {
                //checks each line of data and compares it to the previous line. If they match, backToBack count is increased
                if (cboxChampions.Items[i].ToString() == cboxChampions.Items[i + 1].ToString())
                {

                    //increase count when a back-to-back is found

                    backToBack++;
                }
            }

            //output the total to the form label

            lblOutput.Text = $"Players won {backToBack.ToString()} total back-to-back championships";
        }

        //event click method to close the form when Exit button is clicked

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}