using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Business.Abstract
{
    public interface IPaymentService
    {
        void AfterStarting();
        void AfterStoping();
        void BeforeStarting();
        void BeforeStopping();
        bool Continued();
        void Paused();
        void Shutdown();
        bool Start();
        bool Stop();
    }
}
