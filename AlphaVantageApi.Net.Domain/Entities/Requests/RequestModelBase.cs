﻿using AlphaVantageApi.Net.Domain.Enums;

namespace AlphaVantageApi.Net.Domain.Entities.Requests
{
    public abstract class RequestModelBase
    {
        public Function Function { get; }

        public RequestModelBase(Function function)
        {
            Function = function;
        }
    }
}
