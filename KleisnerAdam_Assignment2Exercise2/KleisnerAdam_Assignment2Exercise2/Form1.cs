using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KleisnerAdam_Assignment2Exercise2
{
    public partial class Form1 : Form
    {
        //created instence of second form,  not needed yet so set to null
        public AddingContact newDialogue = null;
        //create instence of listview item, not needed yet so set to null
        ListViewItem addContact = null;

        public Form1()
        {
            InitializeComponent();
        }
        //method that is run when add is selected from the menu strip
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //creates new dialogue for adding contact so that it will open multiple times instead of once.
            newDialogue = new AddingContact();
            //shows the new dialogue so the user can see
            newDialogue.Show();
            //creating subscribtion for custom event, this makes it so the NewDialouge_addContact code will run when this is hit.
            newDialogue.addContact += NewDialogue_addContact;
        }
        //this method will run when the corresponding subscribtion is hit, will add new contact to list view.
        private void NewDialogue_addContact(object sender, EventArgs e)
        {
            //checking if the number as any letters in it
            if (newDialogue.newContact.Number.ToUpper().Contains('A') || newDialogue.newContact.Number.ToUpper().Contains('B') ||
                newDialogue.newContact.Number.ToUpper().Contains('C') || newDialogue.newContact.Number.ToUpper().Contains('D') ||
                newDialogue.newContact.Number.ToUpper().Contains('E') || newDialogue.newContact.Number.ToUpper().Contains('F') ||
                newDialogue.newContact.Number.ToUpper().Contains('G') || newDialogue.newContact.Number.ToUpper().Contains('H') ||
                newDialogue.newContact.Number.ToUpper().Contains('I') || newDialogue.newContact.Number.ToUpper().Contains('J') ||
                newDialogue.newContact.Number.ToUpper().Contains('K') || newDialogue.newContact.Number.ToUpper().Contains('L') ||
                newDialogue.newContact.Number.ToUpper().Contains('M') || newDialogue.newContact.Number.ToUpper().Contains('N') ||
                newDialogue.newContact.Number.ToUpper().Contains('O') || newDialogue.newContact.Number.ToUpper().Contains('P') ||
                newDialogue.newContact.Number.ToUpper().Contains('Q') || newDialogue.newContact.Number.ToUpper().Contains('R') ||
                newDialogue.newContact.Number.ToUpper().Contains('S') || newDialogue.newContact.Number.ToUpper().Contains('T') ||
                newDialogue.newContact.Number.ToUpper().Contains('U') || newDialogue.newContact.Number.ToUpper().Contains('V') ||
                newDialogue.newContact.Number.ToUpper().Contains('W') || newDialogue.newContact.Number.ToUpper().Contains('X') ||
                newDialogue.newContact.Number.ToUpper().Contains('Y') || newDialogue.newContact.Number.ToUpper().Contains('Z') ||
                newDialogue.newContact.Number.Length <= 9 || newDialogue.newContact.Number.Length == 11 || newDialogue.newContact.Number.Length >=12)
            {
                //if anything is wrong then the text box will be highlighted in red
                newDialogue.phoneNumberTextBox.BackColor = Color.LightCoral;
            }
            else
            {
                //if the number checks out then the text box will turn green
                newDialogue.phoneNumberTextBox.BackColor = Color.LawnGreen;
            }
            //checking if first name uses any numbers
            if (newDialogue.newContact.FirstName.Contains('0') || newDialogue.newContact.FirstName.Contains('1') ||
               newDialogue.newContact.FirstName.Contains('2') || newDialogue.newContact.FirstName.Contains('3') ||
               newDialogue.newContact.FirstName.Contains('4') || newDialogue.newContact.FirstName.Contains('5') ||
               newDialogue.newContact.FirstName.Contains('6') || newDialogue.newContact.FirstName.Contains('7') ||
               newDialogue.newContact.FirstName.Contains('8') || newDialogue.newContact.FirstName.Contains('9'))
            {
                //if anything is wrong then the text box will be highlighted in red
                newDialogue.firstNameTextBox.BackColor = Color.LightCoral;
            }
            else
            {
                //if the information in the text box information if correct it will turn green
                newDialogue.firstNameTextBox.BackColor = Color.LawnGreen;
            }
            //checking if last name uses any numbers
            if (newDialogue.newContact.LastName.Contains('0') || newDialogue.newContact.LastName.Contains('1') ||
               newDialogue.newContact.LastName.Contains('2') || newDialogue.newContact.LastName.Contains('3') ||
               newDialogue.newContact.LastName.Contains('4') || newDialogue.newContact.LastName.Contains('5') ||
               newDialogue.newContact.LastName.Contains('6') || newDialogue.newContact.LastName.Contains('7') ||
               newDialogue.newContact.LastName.Contains('8') || newDialogue.newContact.LastName.Contains('9'))
            {
                //if anything is wrong then the text box will be highlighted in red
                newDialogue.lastNameTextBox.BackColor = Color.LightCoral;
            }
            else
            {
                //the last name text box will be turned green if the info is correct
                newDialogue.lastNameTextBox.BackColor = Color.LawnGreen;
            }
            //checking to see if email uses the @ and ends with .com/.edu/or .org
           if (!(newDialogue.newContact.Email.Contains('@')))
            {
                //if anything is wrong then the text box will be highlighted in red
                newDialogue.emailTextBox.BackColor = Color.LightCoral;
            }
           else
            {
                //if the email info is correct then the text box will turn green
                newDialogue.emailTextBox.BackColor = Color.LawnGreen;
            }
            //checks to see if the number is the approprite size (the ten is for no dashes and the 12 is for dashes)
            if (!(newDialogue.emailTextBox.BackColor == Color.LightCoral) && !(newDialogue.lastNameTextBox.BackColor == Color.LightCoral) &&
                !(newDialogue.firstNameTextBox.BackColor == Color.LightCoral) && !(newDialogue.phoneNumberTextBox.BackColor == Color.LightCoral))
            {
                //creates new listviewItem in order to add the needed information into the listview
                addContact = new ListViewItem();
                //creates new contact class and sets it equal to the on with all the contact info the user inputed in the other scree,
                contactClass newContact = (sender as AddingContact).newContact;
                //Setting what is written on the list view about the item
                addContact.Text = newContact.ToString();

                //determines which picture it will have based on which phone type radio button is checked.
                if (newContact.Mobile)
                {
                    //if mobile is checked it gives it approprite image
                    addContact.ImageIndex = 0;
                }
                if (newContact.Work)
                {
                    //if mobile is checked it gives it approprite image
                    addContact.ImageIndex = 1;
                }
                if (newContact.Home)
                {
                    //if mobile is checked it gives it approprite image
                    addContact.ImageIndex = 2;
                }
                //creates the tag which is what holds the actual item.
                addContact.Tag = newContact;
                //adds the new listview item into the list view
                listView1.Items.Add(addContact);
                //closes newdialouge if it works properly
                newDialogue.Close();
            }
        }
        //this method will switch the list view pictures from being small to large
        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //This line switched how the list view items will be displayed, in this situation it is being set to large.
            listView1.View = View.LargeIcon;
            //switches which item will be checked(this one switched large to being checked and small to not being checked)
            smallToolStripMenuItem.Checked = false;
            largeToolStripMenuItem.Checked = true;
        }

        //this method will switch the list view pictures from being large, to small
        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //This line switched how the list view items will be displayed, in this situation it is being set to small.
            listView1.View = View.SmallIcon;
            largeToolStripMenuItem.Checked = false;
            //switches which item will be checked(this one switched large to being checked and large to not being checked)
            smallToolStripMenuItem.Checked = true;
        }

        //This method will allow users to edit an item
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Creates a new instance of teh AddingContact form so that it will show up more then once in this situation.
            newDialogue = new AddingContact();
            //Populates the addingcontact with the selected items information
            newDialogue.firstNameTextBox.Text = (listView1.SelectedItems[0].Tag as contactClass).FirstName;
            newDialogue.lastNameTextBox.Text = (listView1.SelectedItems[0].Tag as contactClass).LastName;
            newDialogue.phoneNumberTextBox.Text = (listView1.SelectedItems[0].Tag as contactClass).Number;
            newDialogue.emailTextBox.Text = (listView1.SelectedItems[0].Tag as contactClass).Email;
            newDialogue.mobileButton.Checked = (listView1.SelectedItems[0].Tag as contactClass).Mobile;
            newDialogue.workButton.Checked = (listView1.SelectedItems[0].Tag as contactClass).Work;
            newDialogue.homeButton.Checked = (listView1.SelectedItems[0].Tag as contactClass).Home;
            //Sets the edit button to being visible
            newDialogue.editButton.Visible = true;
            //shows Adding Contact form
            newDialogue.Show();
            //subscription to the edit contact custom event, allow the NewDialouge code to run when this part is reached
            newDialogue.editContact += NewDialogue_editContact;
        }

        //This mehtod allows users to edit items in the list view
        private void NewDialogue_editContact(object sender, EventArgs e)
        {
            //sets new contact class equal to the contact class with the new user info
            contactClass newContact = (sender as AddingContact).newContact;
            //changes the selected items text to the new text the user wanted.
            listView1.SelectedItems[0].Text = newContact.ToString();
            //Changes what image is show with the contact based on the changes the user made
            if (newContact.Mobile)
            {
                listView1.SelectedItems[0].ImageIndex = 0;
            }
            if (newContact.Work)
            {
                listView1.SelectedItems[0].ImageIndex = 1;
            }
            if (newContact.Home)
            {
                listView1.SelectedItems[0].ImageIndex = 2;
            }

            listView1.SelectedItems[0].Tag = newContact;
        }
        //This method deletes the contact the user has selected
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Removes the currently selected item from the list view.
            listView1.Items.Remove(listView1.SelectedItems[0]);
            //Since no item is selected the edit and delete buttons are turned invisible to the user
            deleteToolStripMenuItem.Visible = false;
            editToolStripMenuItem.Visible = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Since an item is now selected the delete and edit buttons are made visible
            deleteToolStripMenuItem.Visible = true;
            editToolStripMenuItem.Visible = true;
        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Exits the whole application when the button is clicked
            Application.Exit();
        }
    }
}
