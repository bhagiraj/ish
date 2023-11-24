using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("Marks_Master")]
    public class Marks_Master
    {
        private DbMCA Db = new DbMCA();
        [Key]
        public int Mark_Master_ID { get; set; }
        public string Enrollment_No { get; set; }
        public int Roll_No { get; set; }
        public int Subject_ID { get; set; }
        public string Exam_Name { get; set; }
        public decimal Marks { get; set; }

        public List<Marks_Master> GetAllStudent()
        {
            return Db.marks_Masters.ToList();
        }
    }
}