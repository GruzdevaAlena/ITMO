using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace students
{
    public partial class AddStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack)
            {
                Page.Validate();
                if (!Page.IsValid)
                    return;

                Student student = new Student(FirstName.Text, LastName.Text);
                try
                {
                   
                    SampleContext context = new SampleContext();
                    context._Students.Add(student);
                    context.SaveChanges();
                    Response.Redirect(Request.Url.ToString());
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
    }
}