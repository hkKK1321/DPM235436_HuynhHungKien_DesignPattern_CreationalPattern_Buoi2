using DPM235436_HuynhHungKien_Visitor_DP.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235436_HuynhHungKien_Visitor_DP.Interfaces
{
    public interface IVisitor
    {
        void VisitConcreteComponentA(ConcreteComponentA element);
        void VisitConcreteComponentB(ConcreteComponentB element);
    }
}
