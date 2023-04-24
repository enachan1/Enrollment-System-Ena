using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enrollment_System
{
    abstract class manageCRUD
    {
        public abstract void addData(string data);
        public abstract void deleteData(int id);
        public abstract void updateData(int id, string updatedata);
    }
}
