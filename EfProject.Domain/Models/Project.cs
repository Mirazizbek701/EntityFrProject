using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfProject.Domain.Models;

public class Project
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int project_id { get; set; }
    public string? project_name { get; set; }
    public string? isCreated { get; set; }
    [ForeignKey("id")]
    public int employeeId { get; set; }
}
