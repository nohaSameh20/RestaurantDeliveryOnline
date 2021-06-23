using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CharityProject.Domain.Common
{
    public interface IEntity
    {
         
    }

    public interface IEntity<T> : IEntity
    {
        [Key]
        T Id { set; get; }

    }


}
