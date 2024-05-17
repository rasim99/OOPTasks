using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace StudentGroupTask
{
    internal class Group
    {
        public string GroupNo { get; set; }
        public int Limit { get; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }

        Student[] students;
        Student[] Students { get => students; }
        Teacher[] teachers;
        Teacher []Teachers { get=>teachers; }
        Topic[] topics;
        Topic[] Topics {  get => topics; } 
        public Group(string groupNo)
        {
            Limit = 10;
            StartDate = new DateTime(2024, 3, 30);
            EndDate = new DateTime(2025,2,12);
            students = new Student[0];
            teachers = new Teacher[0];
            topics = new Topic[0];
            GroupNo = groupNo;
        }
        public void AddStudent(Student student)
        {
            if (Limit>students.Length)
            {
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = student;
            }
            else
            {
                Console.WriteLine("groupda yer yoxdu");
            }
        }
       

        public void RemoveStudent(Student student)
        {
            int index=Array.IndexOf(students, student);
            if (index!=-1)
            {
                for (int i = index; i < students.Length-1; i++)
                {
                    students[i] = students[i + 1];
                }
                Array.Resize(ref students, students.Length - 1);
            }
            else
            {
                Console.WriteLine("groupda bele telebe yoxdur");
            }
        }



        public void AddTeacher(Teacher teacher)
        {
            Array.Resize(ref teachers, teachers.Length + 1);
            teachers[teachers.Length - 1] =teacher;
        }

        public void RemoveTeacher(Teacher teacher)
        {
            int index = Array.IndexOf(teachers, teacher);
            if (index != -1)
            {
                for (int i = index; i < teachers.Length - 1; i++)
                {
                    teachers[i] = teachers[i + 1];
                }
                Array.Resize(ref teachers, teachers.Length - 1);
            }
            else
            {
                Console.WriteLine("bele bir muellim  yoxdur");
            }
        }


        public void AddTopic(Topic topic)
        {
            Array.Resize(ref topics, topics.Length + 1);
            topics[topics.Length - 1] = topic;
        }

        public void RemoveTopic(Topic topic)
        {
            int index = Array.IndexOf(topics, topic);
            if (index != -1)
            {
                for (int i = index; i < topics.Length - 1; i++)
                {
                    topics[i] = topics[i + 1];
                }
                Array.Resize(ref topics, topics.Length - 1);
            }
            else
            {
                Console.WriteLine("movzu tapilmadi");
            }
        }

        public void GetDetails()
        {
            Console.WriteLine($"GroupNo :  {GroupNo} MaxStudent : {Limit}"+
                 $" StartDate  :{StartDate.Day} {StartDate.Month} {StartDate.Year} " +
                    $"  EndDate  : {EndDate.Day} {EndDate.Month} {EndDate.Year}");
        }

        public void GetStudents()
        {
            foreach (var student in students)
            {
                Console.WriteLine($" StudentName {student.Name} StudentSurName  " +
                    $"{student.SurName}  GroupNo {GroupNo}");
                   
            }
        }

        public void GetTeachers()
        {
            foreach (var teacher in teachers)
            {
             Console.WriteLine($"TeacherName : {teacher.Name}  TeacherSurname  : {teacher.SurName} {GroupNo}");

            }
        }

        public void GetTopics()
        {
            foreach (var topic in topics)
            {
                Console.WriteLine($"TopicName : {topic.TopicName}");
                
            }
        }
    }
}
