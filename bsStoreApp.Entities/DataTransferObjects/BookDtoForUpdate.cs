using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bsStoreApp.Entities.DataTransferObjects
{
    public record BookDtoForUpdate(int id ,String title ,decimal price);

    ///*public record BookDttoForUpdate*/
    //{
    //    public int Id { get; init; }
    //    public String Title { get; init; }
    //    public decimal Price { get; init; } 
    //}
}
