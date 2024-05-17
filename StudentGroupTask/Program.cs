using System;

namespace StudentGroupTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Student stu1=new Student("Rasim","Mahmudov");
          Student stu2=new Student("Stu2","Stu2li");
          Student stu3=new Student("stu3","stu3li");

            Teacher teacher1 = new Teacher("Lorem","Ipsum");
            Teacher teacher2 = new Teacher("Lorem2","Ipsum2");
            Teacher teacher3 = new Teacher("Lorem3","Ipsum3");

            Topic topic = new Topic("OOP");
            Topic topic2 = new Topic("Class");
            Topic topic3 = new Topic("Inheritance");

            Group group = new Group("PB401");

            group.AddTeacher(teacher1);
            group.AddTeacher(teacher2);
            group.AddTeacher(teacher3);

            group.AddStudent(stu1);
            group.AddStudent(stu2);
            group.AddStudent(stu3);

            group.AddTopic(topic);
             group.AddTopic(topic2);
            group.AddTopic(topic3);

            group.RemoveTopic(topic);
            group.RemoveTopic(topic3);
            //group.RemoveTopic(topic3);
            //group.RemoveTopic(topic);

            group.RemoveTeacher(teacher1);
            group.RemoveTeacher(teacher2);
            //group.RemoveTeacher(teacher2);

            group.RemoveStudent(stu1);
            group.RemoveStudent(stu2);
            //group.RemoveStudent(stu3);
            //group.RemoveStudent(stu3);
            group.GetStudents();
            group.GetTeachers();
            group.GetTopics();
            group.GetDetails();
        }
    }
}
