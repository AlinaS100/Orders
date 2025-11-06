using Orders.Shared.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Orders.Shared.Entites;

public class Country : IEntityWithName
{
    public int Id { get; set; }

    [Display(Name = "País")]
    [Required(ErrorMessage = "El campo {0} es obligatorio.")]
    [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres.")]
    public string Name { get; set; } = null!;

    public ICollection<State>? States { get; set; }

    public int StatesNumber => States == null ? 0 : States.Count;
}