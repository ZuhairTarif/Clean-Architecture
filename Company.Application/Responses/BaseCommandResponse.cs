using System;
using System.Collections.Generic;

namespace Company.Application.Responses
{
    public class BaseCommandResponse
    {
        public int ResponseId { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; }
    }
}
