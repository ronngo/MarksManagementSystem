using System;

namespace MarksManagementSystem
{
    class StudentMark : IStudentMark
    {
        public string FullName {set; get;}
        public int ID {set; get;}
        public string Class {set; get;}
        public int Semester {set; get;}
        public float AverageMark {set; get;}

        public void Display()
        {
            Console.WriteLine("Full name :" + FullName);
            Console.WriteLine("ID : " + ID);
            Console.WriteLine("Class :" + Class);
            Console.WriteLine("Semeter :" + Semester);
            Console.WriteLine("AverageMark :" + AverageMark);          
        }
        int[] SubjectMarkList = new int[5];
        public int this [int index]
        {
            get
            {
                return SubjectMarkList[index];
            }
            set
            {
                SubjectMarkList[index] = value;
            }
        }
        public void AveCal()
        {
            AverageMark = (float)(SubjectMarkList[0] + SubjectMarkList[1]+ SubjectMarkList[2]+ SubjectMarkList[3]+ SubjectMarkList[4])/5;
            Console.WriteLine("Average Mark = " + AverageMark);
        }
    }
}
