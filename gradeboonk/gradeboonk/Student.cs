using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradeboonk
{
    class Student
    {
        //parameters
        string FirstName;
        string LastName;
        int TardyCount;
        int AbsentCount;
        double OverallScore;
        long PhoneNumber;
        string Username;

        //Constructor 
        public Student(string firstName, string lastName, string username, long phoneNumber) //try to make boolean?//dont, you cant.
        {
            FirstName = firstName;
            LastName = lastName;
            TardyCount = 0;
            AbsentCount = 0;
            PhoneNumber = phoneNumber;
            Username = username;
            
        }

        //methoods
        
        public void markTardy( string username )
        {
            TardyCount++;
        } 
        
        public void markAbsent( string username )
        {
            AbsentCount++;
        }
        
        public int getTardyCount(string username)
        {
            return TardyCount;
        }
        
        public int getAbsentCount(string username)
        {
            return AbsentCount;
        }

        //a list/array for assignments goes around here
    }
}
