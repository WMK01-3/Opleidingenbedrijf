﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrijfsOpleiding.Models
{
    [Table("Enrollments")]
    public sealed class Enrollment
    {
        [Key]
        public int EnrollmentID { get; set; }
        public DateTime Timestamp;
        public bool Payed;

        public int CourseID { get; set; }
        public int UserID { get; set; }

       // public virtual ICollection<User> Users { get; set; }

        //[ForeignKey("CourseID")]
        //public virtual Course Course { get; set; }
        //[ForeignKey("UserID")]
        //public virtual User User { get; set; }


        public Enrollment()
        {
            
        }


        public Enrollment(int userid, int courseid)
        {
            UserID = userid;
            CourseID = courseid;
        }
    }
}
