using System;

namespace MarksManagementSystem
{
    public interface IStudentMark
    {
        public string FullName {set; get;}
        public int ID {set; get;}
        public string Class {set; get;}
        public int Semester {set; get;}
        public float AverageMark {set; get;}

        public void Display();
        
    }
   
}