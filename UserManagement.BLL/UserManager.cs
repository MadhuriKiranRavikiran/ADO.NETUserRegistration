using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using UserManagement.DAL;
using UserManagement.DAL.Model;

namespace UserManagement.BLL
{
    public class UserManager
    {
        private readonly UserDataAccess userDataAccess;

        public UserManager(UserDataAccess dataAccess)
        {
            this.userDataAccess = dataAccess;
        }

        public bool RegisterUser(UserModel model)
        {
            if (ValidateUser(model))
            {
                userDataAccess.AddUser(model);
                return true;
            }
            return false;
        }

        private bool ValidateUser(UserModel model)
        {
            return true; 
        }

    }
}
