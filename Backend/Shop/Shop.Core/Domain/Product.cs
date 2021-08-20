using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Domain
{
    public class Product
    {
        public Guid Id { get; set; }
        public IEnumerable<Collar> Collars { get; set; }
        public IEnumerable<NormalLeash> NormalLeashes { get; set; }
        public IEnumerable<ReversibleLeash> ReversibleLeashes { get; set; }
        public IEnumerable<Suspenders> Suspenders { get; set; }
        public IEnumerable<TrainingLeash> TrainingLeashes { get; set; }
        //public IEnumerable<Tape> Tape { get; set; }
        public Guid OrderId { get; set; }
        public Order Order { get; set; }

    }
}
