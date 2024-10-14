using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Dependency_Injection
{
    internal class ClassRoom
    {
        private readonly Teacher _teacher;

        public ClassRoom(Teacher teacher)
        {
            _teacher = teacher;
        }

        public void GetTeacherInfo()
        {
            _teacher.GetInfo();
        }
    }
}
