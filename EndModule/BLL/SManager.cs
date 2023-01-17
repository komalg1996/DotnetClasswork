namespace BLL;
using DAL;
using BOL;
public class SManager

{
    public List<Student> GetAll(){
         return DBManager.GetAll();
    }
    public bool Insert(int rollno,string name,string email,string city){
        if(DBManager.Insert(rollno,name,email,city))
        return true;
        return false;
    }

    public void Update(int rollno,string name,string email,string city){
        DBManager.Update(rollno,name,email,city);
        
    }

    public void Delete(int rollno){
    DBManager.Delete(rollno);
    }

    public Student GetByRollno(int rollno){
       return DBManager.GetByRollno(rollno);
    }
}
