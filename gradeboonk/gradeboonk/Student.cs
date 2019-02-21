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
        public Student(string firstName, string lastName, string username, long phoneNumber) //try to make boolean?
        {
            FirstName = firstName;
            LastName = lastName;
            TardyCount = 0;
            AbsentCount = 0;
            PhoneNumber = phoneNumber;
            Username = username;
            
        }

        //methoods
        
        Public void markTardy( string username )
        {
            TardyCount++;
        } 
        
        Public void markAbsent( string username )
        {
            AbsentCount++;
        }
        
        Public int getTardyCount(string username)
        {
            return TardyCount;
        }
        
        Public int getAbsentCount(string username)
        {
            return AbsentCount;
        }

    }
}
