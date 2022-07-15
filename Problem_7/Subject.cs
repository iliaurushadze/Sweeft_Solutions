namespace Problem_7
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Subject")]
    public partial class Subject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int subject_id { get; set; }

        [Required]
        [StringLength(15)]
        public string subject_name { get; set; }

        public short subject_grade { get; set; }

        public int pupil_id { get; set; }

        public int teacher_id { get; set; }

        public virtual Pupil Pupil { get; set; }

        public virtual Teacher Teacher { get; set; }
    }
}
