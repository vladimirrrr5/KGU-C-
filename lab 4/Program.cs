using System;
using System.Collections.Generic;
using System.Text;

namespace lab4{
    class Program
    {
        static void Main()
        {

        }
    }
    class Publication
    {
        string name;
        double prise;
        public Publication(string name,double prise)
        {
            this.name = name;
            this.prise = prise;
        }
        public void Getdata()
        {

        }
        public void Putdata()
        {

        } 
    }
    class Book
    {
        int NumberOfPage;
        
        public Book(int NumberOfPage)
        {
            this.NumberOfPage = NumberOfPage;
        }
    }
    class Type
    {
        int RecordingTime;//в минутах
        public Type(int RecordingTime)
        {
            this.RecordingTime = RecordingTime;
        }
    }
}   


