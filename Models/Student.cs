using System.ComponentModel.DataAnnotations;

public class Student{
    public int Id {get;set;}
    [Required(ErrorMessage ="this field is required")]
    public string NameSurname {get;set;}
    public int Age {get;set;}
}