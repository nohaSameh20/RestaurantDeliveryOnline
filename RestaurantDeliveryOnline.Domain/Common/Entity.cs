using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityProject.Domain.Common
{

    public class Entity<T> : IEntity
    {
        [Key]
        public T Id { get; set; }
        //=========Audit Members============ 
        public DateTime CreatedAt { set; get; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }

        public Entity()
        {
            CreatedAt = DateTime.Now;
        }
    }
}
