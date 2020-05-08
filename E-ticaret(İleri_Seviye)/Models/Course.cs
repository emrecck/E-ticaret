using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Services.Description;

namespace E_ticaret_İleri_Seviye_.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string WhatWillYouLearn { get; set; }
        public string CourseImage { get; set; }
        public int PersonAdded { get; set; }
        public string CourseReyting { get; set; }
        public string CourseLanguage { get; set; }
        public int CourseLectures { get; set; }
        public string CourseLenght { get; set; }

        public int CategoryId{ get; set; }
        public Category Category{ get; set; }

        public List<Instructor> Instructors { get; set; }
    }
}