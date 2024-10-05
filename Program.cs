namespace Westcoast_Education;

class Program
{
    static void Main()
    {
        var studentList = new StudentList();
        studentList.PrintStudentList();

        var teacherList = new Teachers();
        teacherList.PrintTeacherList();

        var educationalLeadersList = new EducationLeaders();
        educationalLeadersList.PrintEducationalLeadersList();

        var coursesList = new AddCourses();
        coursesList.PrintCourseList();

    }
}
