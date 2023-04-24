using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Enrollment_System
{
    class dbmscon
    {
        // connection string
        public static string conString = "Data Source=ENACHAN\\SQLEXPRESS;Initial Catalog=Enrollment_System;Integrated Security=True";

        //Showing Student List
        public static string showStdInfo = "SELECT * FROM StudentListTBL";

        // Showing Programs
        public static string showPrgInfo = "SELECT * FROM programList";

        //Show School Section
        public static string showSectionInfo = "SELECT * from sectionList";

        //Show School year
        public static string showSy = "SELECT * FROM schoolYearList";

        //Show enrolled student
        public static string showEnrolledStd = "SELECT * FROM enrolledStudentsList";

        //show balances
        public static string showBalance = "SELECT * FROM balances";

        // show transaction log
        public static string showtransact = "SELECT * FROM transactionlog";

        //show subject
        public static string showsubject = "SELECT * FROM subjectList";

    }
}
