using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CROSSWORKERS.CHEMICLEAN.Domain.Models
{
    public abstract class Entity<TKey>
    {
        public TKey Id { set; get; }
    }
}
