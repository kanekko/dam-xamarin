using System;
using Refit;

namespace RefitMVVM.Service
{
    public static class RefitServiceGenerator
    {
        public static IRefitService GetService()
        {
            return RestService.For<IRefitService>("http://80.241.208.215/ingeteam/api");
        }
    }
}
