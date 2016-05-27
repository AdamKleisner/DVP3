using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KleisnerAdam_Assignment1Exercise1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //checking if anything is entered
            if (itemNameTextBox.Text != "")
            {
                //checks to see which list it should be added
                if (needRadioButton.Checked == true)
                {
                    needList.Items.Add(itemNameTextBox.Text);
                }
                if (haveRadioButton.Checked == true)
                {
                    haveList.Items.Add(itemNameTextBox.Text);
                }
            }
            //clears the name of the item
            itemNameTextBox.Text = "";
        }

        private void haveList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Change all buttons that involve the need list to being invisible
            haveDeleteButton.Visible = true;
            haveMoveButton.Visible = true;
            needDeleteButton.Visible = false;
            needMoveButton.Visible = false;
        }

        
        private void needList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Change all buttons that involve the have list to being invisible
            haveDeleteButton.Visible = false;
            haveMoveButton.Visible = false;
            needDeleteButton.Visible = true;
            needMoveButton.Visible = true;

        }

        //This method will move items from the have list and remove it as well.
        private void haveMoveButton_Click(object sender, EventArgs e)
        {
            //adds the selected item from need list to have list
            if (haveList.SelectedItem != null)
            {

                needList.Items.Add(haveList.SelectedItem);
                //removes moved item from have list
                haveList.Items.Remove(haveList.SelectedItem);
            }
        }

        //This method will delete a selected item from the have list
        private void haveDeleteButton_Click(object sender, EventArgs e)
        {
            //deletes the selected item from the have list
            if (haveList.SelectedItem != null)
            {
                haveList.Items.Remove(haveList.SelectedItem);
            }
        }
        
        //This method moves items from the need list to have list
        private void needMoveButton_Click(object sender, EventArgs e)
        {
            //moves selected item from need list to have list
            if (needList.SelectedItem != null)
            {
                haveList.Items.Add(needList.SelectedItem);

                //deletes moved item from need list
                needList.Items.Remove(needList.SelectedItem);
            }
        }

        //Deletes selected item from need list
        private void needDeleteButton_Click(object sender, EventArgs e)
        {
            //removing the selected item from the need list
            if(needList.SelectedItem != null)
            {
                needList.Items.Remove(needList.SelectedItem);
            }
        }

        //This method is activated when the save tool strip menu is selected
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //creating new save dialog
            SaveFileDialog save = new SaveFileDialog();

            //displaying save dialog
            if (DialogResult.OK == save.ShowDialog())
            {
                // creatin the stream in order to write out the document
                using (StreamWriter outputfile = new StreamWriter(Path.Combine(@"C:\...\...\Documents", save.FileName + ".txt")))
                {
                    //outputting the need list
                    //the foreach will loop through the need list
                    foreach (object line in needList.Items)
                    {
                        //This is what will be written in the form
                        outputfile.WriteLine( "Need: " + line);
                    }
                    //outputing have list
                    //the foreach will loop through the have list
                    foreach (object line in haveList.Items)
                    {
                        //This is what will be written in the form
                        outputfile.WriteLine("Have: " + line);
                    }
                }
            }
        }

        //activates when the exit button from the menu strip is selected
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //cause the application to close
            Application.Exit();
        }
    }
}
