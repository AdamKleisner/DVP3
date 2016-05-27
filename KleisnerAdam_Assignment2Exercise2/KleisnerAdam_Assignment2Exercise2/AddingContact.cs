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
    public partial class AddingContact : Form
    {
        //declaring the two public event handlers for adding and editing contacts
        public event EventHandler addContact;
        public event EventHandler editContact;

        //creates newContact which has all the info the user inputed
        public contactClass newContact
        {
            get
            {
                contactClass c = new contactClass(firstNameTextBox.Text, lastNameTextBox.Text, phoneNumberTextBox.Text, emailTextBox.Text, mobileButton.Checked, workButton.Checked, homeButton.Checked);
                return c;
            }
            set
            {
                firstNameTextBox.Text = value.FirstName;
                lastNameTextBox.Text = value.LastName;
                phoneNumberTextBox.Text = value.Number;
                emailTextBox.Text = value.Email;
                mobileButton.Checked = value.Mobile;
                workButton.Checked = value.Work;
                homeButton.Checked = value.Home;
            }
        }

        public AddingContact()
        {
            InitializeComponent();
        }
        //activates the add event handler when button is created
        private void addButton_Click(object sender, EventArgs e)
        {
            if (addContact != null)
            {
                addContact(this, new EventArgs());

            }
        }
        //this method activates when edit button is clicked also activates the event handler
        private void Edit_Click(object sender, EventArgs e)
        {
            if (editContact != null)
            {
                editContact(this, new EventArgs());

                Close();
            }
        }
    }
}
