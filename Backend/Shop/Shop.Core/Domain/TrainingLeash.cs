using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Domain
{
    public class TrainingLeash : TapeBase
    {
        public TrainingLeash(string color,string comments, double lenght, double price,bool handle)
            :base(color,comments,lenght,price,handle)
        {

        }
    }
}
