//
//
using System;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace DisplayTable
{
    public partial class DisplayAuthorsTable : Form
    {
        // constructor for style points.
        /*public DisplayAuthorsTable()
        {
            InitializeComponent();
        }
        */

        //Entity Framework DBContext
        private CardCatalog.BooksEntities dbcontext =
            new CardCatalog.BooksEntities();

        // load Data from database into DataGridView. Learning this as I go.
        private void DisplayAuthorsTable_Load(object sender, EventArgs e)
        {
            // load Authors table ordered by LastName, then FirstName
            dbcontext.Authors
                .OrderBy(author => author.LastName)
                .ThenBy(author => author.FirstName)
                .Load();

            // specify DataSource for authorBindingSource
            authorBindingSource.DataSource = dbcontext.Authors.Local;
        }

        // click event handler for Save Button in the BindingNavigator
        // saves the changes made to the data.
        private void authorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate(); // validate the input fields.
            authorBindingSource.EndEdit(); // complete current edits, if necessary.

            // save changes
            try
            {
                dbcontext.SaveChanges(); // write to DB file
            }
            catch (DbEntityValidationException)
            {
                MessageBox.Show("FirstName and LastName must contain values, Entity Validation Exception");
            }
        }
    }
}
