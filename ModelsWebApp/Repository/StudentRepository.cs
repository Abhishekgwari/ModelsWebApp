using ModelsWebApp.Models;

namespace ModelsWebApp.Repository
{
    public class StudentRepository : IStudent
    {
        public List<StudentModel> getAllStudents()
        {
            return DataSource();
        }

        public StudentModel getStudentByID(int id)
        {
            return DataSource().Where(x=> x.rollNo == id).FirstOrDefault();
        }

        private List<StudentModel> DataSource()
        {
            return new List<StudentModel>{
            new StudentModel {rollNo =1, Name="Abhishek",Gender="Male",Standard= 10 },
            new StudentModel {rollNo =2, Name="Aman",Gender="Male",Standard= 11 },
            new StudentModel {rollNo =3, Name="Lokesh",Gender="Male",Standard= 12 },
             new StudentModel {rollNo =4, Name="Neha",Gender="Female",Standard= 9 },
            new StudentModel {rollNo =5, Name="Astha",Gender="Female",Standard= 8 }

            };
        }
    }
}
