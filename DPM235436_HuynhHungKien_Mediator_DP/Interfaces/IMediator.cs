using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235436_HuynhHungKien_Mediator_DP.Interfaces
{
    public interface IMediator
    {
        void Notify(object sender, string ev);
    }
}
