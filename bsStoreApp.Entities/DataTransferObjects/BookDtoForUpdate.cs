using System.ComponentModel.DataAnnotations;

namespace bsStoreApp.Entities.DataTransferObjects
{
    public record BookDtoForUpdate : BookDtoForManipulation
    {
        [Required]
        public int Id { get; init; }
    }
}
