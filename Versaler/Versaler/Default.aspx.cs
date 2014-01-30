using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Versaler
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox.Focus();

        }

        protected void Button_Click(object sender, EventArgs e)
        {
            if (TextBox.Text != "")
            {
                // Då svaret presenteras ska det inte vara möjligt att ändra i textfältet.
                TextBox.Enabled = false;
                string text = TextBox.Text;
                int capital = Model.TextAnalyzer.GetNumberOfCapitals(text);
                Label.Text = capital.ToString();
                // Gömma placeholder som innehåller Label.
                PlaceHolder.Visible = true;
                // Gömmar label också för säkerhetsskuld.
                Label.Visible = true;
                //Ersätter textens namn till Rensa .
                Button.Text = "Rensa";
            }
        }
    }
} 