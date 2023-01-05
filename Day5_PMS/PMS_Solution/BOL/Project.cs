namespace BOL;
public class Project
{
    public int Id{get;set;}
    public string Name{get;set;}
     public string Type{get;set;}
    public string Description{get;set;}
    public DateTime StartDate{get;set;}
    public DateTime EndDate{get;set;}
    public Project(){
        this.Id=1;
        this.Name="StudyPtoject";
        this.Type="Education";
        this.Description="Online Education";
        this.StartDate= new DateTime(2023-01-01);
        this.EndDate=new DateTime(2023-12-01);
    }
    public Project(int id, string name, string type, string description, DateTime startDate, DateTime endDate){
        this.Id=id;
        this.Name=name;
        this.Type=type;
        this.Description=description;
        this.StartDate=startDate;
        this.EndDate=endDate;

    }

}
