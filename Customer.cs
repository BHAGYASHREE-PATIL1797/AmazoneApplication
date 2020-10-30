// Customer Relationship module
// Namespace: logical collection of .NET Types
/*namespace CRM
{
    public class Customer
    {
        public string UserID { get; set; }  //Auto Property
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string ContactNubmer { get; set; }
        public string Location { get; set; }










        public Customer(string UserID, string Passward, string FullName, string Email, string ContactNumber, string Location)
        {
            this.UserID = UserID;
            this.Password = Passward;
            this.FullName = FullName;
            this.Email = Email;
            this.ContactNubmer = ContactNubmer;
            this.Location = Location;
        }


        public override string ToString()
        {
            //return base.ToString();

            return this.UserID + " " + this.Password + " " + this.FullName + " " + this.Email + " " + this.ContactNubmer+""+this.Location;
        }





    }


   

}
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CRM
{
    public class Customer
    {
        public string UserID { get; set; }  //Auto Property
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string ContactNubmer { get; set; }
        public string Location { get; set; }
    }
}
