using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Models
{
    public class ProductDTO
    {
        public IList<CollarDTO> Collars { get; set; }
        public IList<NormalLeashDTO> NormalLeashes { get; set; }
        public IList<ReversibleLeashDTO> ReversibleLeashes { get; set; }
        public IList<SuspendersDTO> Suspenders { get; set; }
        public IList<TrainingLeashDTO> TrainingLeashes { get; set; }
        public Guid OrderId { get; set; }
    }
}
