using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Models
{
    public class ProductDTO
    {
        public IEnumerable<CollarDTO> Collars { get; set; }
        public IEnumerable<NormalLeashDTO> NormalLeashes { get; set; }
        public IEnumerable<ReversibleLeashDTO> ReversibleLeashes { get; set; }
        public IEnumerable<SuspendersDTO> Suspenders { get; set; }
        public IEnumerable<TrainingLeashDTO> TrainingLeashes { get; set; }
    }
}
