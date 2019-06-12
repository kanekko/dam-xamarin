using System;
using System.Threading.Tasks;
using Refit;

namespace RefitMVVM.Service
{
    public interface IRefitService
    {
        [Get("/numero")]
        Task<int> GetNumber();
    }
}
