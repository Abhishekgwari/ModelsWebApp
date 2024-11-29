using ModelsWebApp.Models;

namespace ModelsWebApp.Repository
{
    public interface IStudent
    {                                       // THESE ARE ABSTRACT METHODS
        List<StudentModel> getAllStudents();
        StudentModel getStudentByID(int id);
    }
}
