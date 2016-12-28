using ProjetoMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetoMvc.DataAccessLayer;

namespace ProjetoMvc.Model
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            SalesERPDAL salesDal = new SalesERPDAL();

            return salesDal.Employees.ToList();
        }

        public Employee SaveEmployee(Employee e)
        {
            SalesERPDAL salesDal = new SalesERPDAL();
            salesDal.Employees.Add(e);
            salesDal.SaveChanges();
            return e;
        }

        public UserStatus GetUserValidity(UserDetails u)
        {
            if (u.UserName == "Admin" && u.Password == "Admin")
            {
                return UserStatus.AuthenticatedAdmin;
            }
            else if (u.UserName == "Leo" && u.Password == "Leo")
            {
                return UserStatus.AuthenticatedUser;
            }
            else
            {
                return UserStatus.NonAuthenticatedUser;
            }
        }

    }
}