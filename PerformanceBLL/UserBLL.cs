using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PerformanceEntity;

namespace PerformanceBLL
{
    public class UserBLL
    {

        public static bool ValidateUsers(UserEntity newuser)
        {

            StringBuilder message = new StringBuilder();
            bool validUsers = true;

            if(newuser.Userfname==string.Empty)
            {
                validUsers = false;
            }
            if(newuser.Userlname==string.Empty)
            {
                validUsers = false;
            }
            if(newuser.Useremail==string.Empty)
            {
                validUsers = false;
            }
            if(newuser.Usercity==string.Empty)
            {
                validUsers = false;
            }
            if(newuser.Usermobileno==string.Empty)
            {
                validUsers = false;
            }
            if(newuser.Roleid==0)
            {
                validUsers = false;
            }
            if(newuser.userpassword==string.Empty)
            {
                validUsers = false;
            }
            return validUsers;
        }


        public static int AddUsers(UserEntity newuser)
        {
            int Useradded = 0;
            if(ValidateUsers(newuser))
            {
                Useradded = UserDAL.AddUsers(newuser);
                

            }
        }
    }
}
