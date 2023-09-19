using EfProject.Domain.States;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfProject.Domain.Models;

public class Employee
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Salary { get; set; }
    public Level level { get; set; }
    public List<Project>? Projects { get; set; }
}
