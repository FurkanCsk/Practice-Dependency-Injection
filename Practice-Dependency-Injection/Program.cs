using Practice_Dependency_Injection;

var teacher = new Teacher()
{
    FirstName = "Furkan",
    LastName = "Coşkun"
};

var classRoom = new ClassRoom(teacher);

classRoom.GetTeacherInfo();