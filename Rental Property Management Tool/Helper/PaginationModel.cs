using System.Threading.Tasks;

namespace Rental_Property_Management_Tool.Helper
{
    public class PaginationModel<T> where T : class
    {
        public PaginationModel(T data, int total)
        {
            Data = data;
            TotalCount = total;
        }
        public T Data { get; set; }
        public int TotalCount { get; set; } 
    }
}
