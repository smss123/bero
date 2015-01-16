using DataLayer.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DataLayer.XCustomer
{
    public class CustomerCommand:BaseDatabase
    {
        public  delegate void OnchangeCallBack(string processName, string Usermsg, string description);
        public static event OnchangeCallBack ProcessChange;

        public static bool NewCustomer(Customer cust , string CustName)
        {
            try
            {

                Customer tb = db.Customers.Where(i => i.CustomerName == CustName).Single();
                if (tb.ID == 0)
                {
                       // ^^^ If Not Existed : Start Save At Customer Table & Write New History  
                        db.Customers.InsertOnSubmit(cust);
                        db.SubmitChanges();

                        HistoryCommand.NewHistory(new History() {
                         ActionName="Adding New Customer",
                          Description = "customer Name "+cust.CustomerName+
                           "\n Phone Number : "+cust.PhoneNumber+
                           "Created At "+cust.CreateDate.ToString(),
                            DateOfProcess = DateTime.Now,
                             SystemUser = LoginInfomation.CurrnetUser,
                         HistoryAction = "Adding New Customer",
                 
                        });
                ProcessChange("Adding Customer", cust.CustomerName + " has Been Saved ",null);
                return true;
                }
                // ^^^ If Already Existed : Cancel Process.
                MessageBox.Show("The Current Customer Already Exiest ..");

                return false; ;
              
            }
            catch (Exception e)
            {

                ProcessChange("Error message", "Can't Save Customer", e.ToString());
                return false;
            }
        }

        public static bool EditCustomer(Customer cust)
        {
            try
            {
                var q = db.Customers.Where(p => p.ID == cust.ID).Single();
                q.CustomerName = cust.CustomerName;
                q.No_building = cust.No_building;
                q.No_permissibility = cust.No_permissibility;
                q.PhoneNumber = cust.PhoneNumber;
                db.SubmitChanges();
                HistoryCommand.NewHistory(new History()
                {
                    ActionName = "Edit Customer",
                    Description = String.Format("old Info Is customer Name {0}\n Phone Number : {1}Created At {2} \n New Info is customer Name {3}\n Phone Number : {4}Created At {5}", q.CustomerName, q.PhoneNumber, q.CreateDate, cust.CustomerName, cust.PhoneNumber, cust.CreateDate),
                    DateOfProcess = DateTime.Now,
                    SystemUser = LoginInfomation.CurrnetUser
                });

                ProcessChange("Edit Customer", cust.CustomerName + " has Been Edited ", null);
                q = null;
                return true;
            }
            catch (Exception e)
            {

                ProcessChange("Error message", "Can't Edit Customer", e.ToString());
                return false;
            }
        }
        public static bool DeleteCustomer(int iD)
        {
            try
            {
                var q = db.Customers.Where(p => p.ID == iD).Single();
                db.Customers.DeleteOnSubmit(q);
                db.SubmitChanges();
                HistoryCommand.NewHistory(new History()
                {
                    ActionName = "Delete Customer",
                    Description = String.Format(" Info Is customer Name {0}\n Phone Number : {1}Created At {2} \n", q.CustomerName, q.PhoneNumber, q.CreateDate),
                    DateOfProcess = DateTime.Now,
                    SystemUser = LoginInfomation.CurrnetUser
                });
                q = null;
                ProcessChange("Delete Customer", q.CustomerName + " has Been Deleted ", null);
                return true;
            }
            catch (Exception e)
            {

                ProcessChange("Error message", "Can't Delete Customer", e.ToString());
                return false;
            }
        }

        public static List<Customer> GetAll()
        {
            return db.Customers.ToList();
        }

        public static Customer GetCustomerByID(int XID)
        {
            Customer tb = db.Customers .Where (p => p.ID == XID ).Single()
            return tb;
        }
        public static Customer GetCustomerByName(string Custname)
        {
            Customer tb = db.Customers.Where(p => p.CustomerName == Custname ).Single();
            return tb;
        }

    }
}
