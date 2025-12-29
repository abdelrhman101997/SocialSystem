using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.Application.Shared
{
    public class ApiResponse<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T? Data { get; set; }
        public IEnumerable<string>? Errors { get; set; }

        private ApiResponse(bool success, string message, T? data = default, IEnumerable<string>? errors = null)
        {
            Success = success;
            Message = message;
            Data = data;
            Errors = errors;
        }

        public static ApiResponse<T> SuccessResponse(T data, string message = "Operation successful.")
            => new(true, message, data);

        public static ApiResponse<T> FailResponse(string message = "Operation failed.", IEnumerable<string>? errors = null)
            => new(false, message, default, errors);
    }
}
