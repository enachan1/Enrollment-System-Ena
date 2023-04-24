using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enrollment_System
{
    class addstdEncaps
    {
        // get and set student information
        public static string getFullName(string fname, string mname, string lname, string suff)
        {
            string combinedName = fname + " " + mname + " " + lname + " " + suff;
            return combinedName;
        }
        public static string getGender(string gender)
        {
            return gender;
        }
        public static string getCivil(string civil)
        {
            return civil;
        }
        public static string getCitizen(string citizen)
        {
            return citizen;
        }
        public static string getBirthDay(string birthday)
        {
            return birthday;
        }
        public static string getBirthplace(string birthplace)
        {
            return birthplace;
        }
        public static string getReligion(string religion)
        {
            return religion;
        }
        public static string getAddress(string address)
        {
            return address;
        }
        
        public static string getGuardianName(string gname)
        {
            return gname;
        }
        public static string getContact(string contact)
        {
            return contact;
        }
        public static string getemail(string email)
        {
            return email;
        }
        public static int getage(int age)
        {
            return age;
        }
    }
}
