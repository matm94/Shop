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
        public IList<Collar> Collars { get; set; }
        public IList<NormalLeash> NormalLeashes { get; set; }
        public IList<ReversibleLeash> ReversibleLeashes { get; set; }
        public IList<Suspenders> Suspenders { get; set; }
        public IList<TrainingLeash> TrainingLeashes { get; set; }
        public Guid OrderId { get; set; }
        public Order Order { get; set; }

    }
}
