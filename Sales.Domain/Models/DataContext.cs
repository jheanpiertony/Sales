namespace Sales.Domain.Models
{
    using System.Data.Entity;
    class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }
    }
}
