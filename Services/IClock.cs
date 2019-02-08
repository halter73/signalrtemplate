using System;
using System.Threading.Tasks;

namespace SignalRTemplate.Services
{
    public interface IClock
    {
        Task SendTime(DateTime serverTime);
    }
}