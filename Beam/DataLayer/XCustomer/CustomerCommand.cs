﻿using DataLayer.Security;
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

        public static bool NewCustomer(Customer cust )
        {
            try
            {
                db = new dbDataContext(Properties.Settings.Default.xprema_beroConnectionString);
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
              
                return true;

              
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
                
                q.PhoneNumber = cust.PhoneNumber;
                q.CustomerEmail = cust.CustomerEmail;
                db.SubmitChanges();
                HistoryCommand.NewHistory(new History()
                {
                    ActionName = "Edit Customer",
                    Description = String.Format("old Info Is customer Name {0}\n Phone Number : {1}Created At {2} \n New Info is customer Name {3}\n Phone Number : {4}Created At {5}", q.CustomerName, q.PhoneNumber, q.CreateDate, cust.CustomerName, cust.PhoneNumber, cust.CreateDate),
                    DateOfProcess = DateTime.Now,
                    SystemUser = LoginInfomation.CurrnetUser
                });

             
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
            
                return true;
            }
            catch (Exception e)
            {

                ProcessChange("Error message", "Can't Delete Customer", e.ToString());
                throw new Exception(e.Message);
            }
        }

        public static List<Customer> GetAll()
        {
            db = new dbDataContext(Properties.Settings.Default.xprema_beroConnectionString);
            return db.Customers.ToList();
        }

        public static Customer GetCustomerByID(int XID)
        {
            Customer tb = db.Customers.Where(p => p.ID == XID).Single();
            return tb;
        }
        public static Customer GetCustomerByName(string Custname)
        {
            Customer tb = db.Customers.Where(p => p.CustomerName == Custname ).Single();
            return tb;
        }


        public static bool EditCustomer_TotalNeed(Customer cust)
        {
            
                var q = db.Customers.Where(p => p.ID == cust.ID).Single();
                q.Total_Need = cust.Total_Need;
                db.SubmitChanges();
               
              
                return true;
           
        }


    }
}
