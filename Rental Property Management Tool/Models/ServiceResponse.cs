﻿namespace Rental_Property_Management_Tool.Models
{
    public class ServiceResponse
    {
        public T Data { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; } = null;
    }
}
