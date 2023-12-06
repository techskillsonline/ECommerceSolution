using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.SharedKernel
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedTime { get; private init; } = DateTime.Now;
        public DateTime? UpdatedTime { get; set; }
        public string Createdby { get; set; }
        public string? UpdatedBy { get; set; }
        public bool IsActive { get; private set; } = true;
    }
}

