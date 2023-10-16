using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Final
{
    internal class Company
    {
        public string Name{ get; set; }
        User[] companyUsers = new User[0];


        public void Register(string name,string surname, string password)
        {



            if (password.Length < 5)
            {
                Console.WriteLine("The password must be longer than 4 characters.");
                return;
            }
        }

        public bool Login(string searchUsername , string searchPassword)
        {
            foreach(var item in companyUsers) 
            {
                if(item.Username == searchUsername && item.Password == searchPassword)
                {
                    Console.WriteLine("Login succesful.");
                    return true;
                }
            }
            Console.WriteLine("Username or Password is incorrect.");
            return false;
        }

        public void GetAll()
        {
            for (int info = 0; info < companyUsers.Length; info++)
            {
                Console.WriteLine($"{info + 1} User Name : {companyUsers[info].Name} User Surname : {companyUsers[info].Surname} User Email : {companyUsers[info].Email} Username : {companyUsers[info].Username}");
            }
        }

        //public User GetAll()
        //{
        //    foreach (var item in companyUsers)
        //    {
        //        return item;
        //    }
        //    return null;
        //}

        public void GetByUsername(string enteredUsername)
        {
            foreach (var index in companyUsers) 
            { 
                if(index.Username == enteredUsername)
                {
                    Console.WriteLine($"{index.Username}  {index.Email}");
                }
            
            }
        }
        public void UpdateByUsername(string username, string updatedName = null, string updatedSurname = null, string updatedUsername = null, string updatedEmail = null)
        {
            for (int k = 0; k < companyUsers.Length; k++)
            {
                if (companyUsers[k].Username == username)
                {
                    companyUsers[k].Name = updatedName;
                    companyUsers[k].Surname = updatedSurname;
                    companyUsers[k].Username = updatedUsername;
                    companyUsers[k].Email = updatedEmail;
                }
                else
                {
                    Console.WriteLine("User not found.");
                }
            }    
        }

        //public void DeleteByUsername(string username)
        //{

        //}
    }
}
