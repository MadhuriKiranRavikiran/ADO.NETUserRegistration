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
        //    private readonly UserDataAccess userDataAccess;

        //    public UserManager(UserDataAccess dataAccess)
        //    {
        //        this.userDataAccess = dataAccess;
        //    }

        //    public bool RegisterUser(UserModel model)
        //    {
        //        if (ValidateUser(model))
        //        {
        //            userDataAccess.AddUser(model);
        //            return true;
        //        }
        //        return false;
        //    }

        //    private bool ValidateUser(UserModel model)
        //    {
        //        return true; 
        //    }

        //}
        private readonly UserManagementDBEntities1 dbContext;

        public UserManager(UserManagementDBEntities1 dbContext)
        {
            this.dbContext = dbContext;
        }

        public bool RegisterUser(UserModel model)
        {
            if (ValidateUser(model))
            {
                var userEntity = new User
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    Password = model.Password
                };

                dbContext.Users.Add(userEntity);
                dbContext.SaveChanges();

                return true;
            }
            return false;
        }

        private bool ValidateUser(UserModel model)
        {
            // Perform validation logic here, if needed
            return true;
        }
    }
}
