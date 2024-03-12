namespace StudentPortalWeb2.Models.Entities
{
    public class Student
    {
       ///Datos solicitados a los estudiantes    
    public Guid ID { get; set; }
    public String Name { get; set; }

    public String Email { get; set; }

    public String Phone { get; set; }

    public bool Subscribed { get; set; }
}
}
