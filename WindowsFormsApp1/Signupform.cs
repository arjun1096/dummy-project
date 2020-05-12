using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PerformanceEntity;

namespace PresentationLayer
{
    public partial class Signupform : Form
    {
        public Signupform()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

     

        private void Button1_Click(object sender, EventArgs e)
        {

              UserEntity newuserentity = new UserEntity();
              newuserentity.Userfname = Convert.ToString(fnamebox);
              newuserentity.Userlname = Convert.ToString(lnamebox);
              newuserentity.Useremail = Convert.ToString(emailnamebox);
              newuserentity.userpassword = Convert.ToString(passwordbox);
              string password = Convert.ToString(confpasswordbox);
              newuserentity.Usercity = Convert.ToString(citybox);
              newuserentity.Usermobileno = Convert.ToString(mobilebox);
              string role=Convert.ToString(Rolebox);
              newuserentity.Roleid = int.Parse(role);
            

            



        }

      
    }
}
