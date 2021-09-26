using Shop.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Services
{
    public interface IProductService
    {
        void AddCollar(Guid orderId, CollarDTO dto);
        void AddNormalLeash(Guid orderId, NormalLeashDTO dto);
        void AddReversibleLeash(Guid orderId, ReversibleLeashDTO dto);
        void AddSuspenders(Guid orderId, SuspendersDTO dto);
        void AddTrainingLeash(Guid orderId, TrainingLeashDTO dto);
    }
}
