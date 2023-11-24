using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("Subject_Master")]
    public class Subject_Master
    {
        private DbMCA Db = new DbMCA();
        [Key]
        public int Subject_Master_ID { get; set; }
        public string Subject_Name { get; set; }
        public string Subject_Alias { get; set; }
        public int Subject_Sequence { get; set; }
        public bool Is_Active { get; set; }

        public List<Subject_Master> GetAllSubject()
        {
            return Db.subject_Masters.ToList().OrderBy(m => m.Subject_Sequence).ToList();
        }
    }
}