using Launchdry.Models;
using Launchdry.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Launchdry.Services.Business
{
    public class SecurityService
    {
        SecurityDAO daoservice = new SecurityDAO();
        public bool Authenticate(UserModel user)
        {
            return daoservice.FindByUser(user);
        }
    }
}