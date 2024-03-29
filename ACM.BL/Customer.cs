﻿using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable 


    {
        public Customer(): this(0)
        {

        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public List<Address>AddressList { get; set; }


        public int CustomerId { get; private set; }

        public string EmailAddress { get; set; }

        public string FirstName { get; set; }

        public int CustomerType { get; set; }

        public override string ToString() => FullName;

        private string lastName;

        public string FullName
        {
            get
            {
                string fullName = FirstName;
                if (!string.IsNullOrWhiteSpace(lastName))

                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += " ,";
                    }
                    fullName += lastName;
                    
                }
                return fullName;
            }
           
        }


        public static int InstanceCount { get; set; }
        public string LastName
        {
            get
            {
                return lastName; 
            }

            set
            {
                lastName = value;
            }

        }

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(lastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
        public string Log() =>

            $"{CustomerId}: {FullName} Email: {EmailAddress} Status: {EntityState.ToString()}";
        

        

        

    }

   

}
