namespace Draw;

public class Circle:Shape,IPrintable{
    public Point Center{get;set;}
    public int Radius{get;set;}
//default ctr
public Circle(){
    this.Center=new Point(0,0);
    this.Radius=1;
}
//parametrized ctr
public Circle(Point p, int r){
    this.Center=p;
    this.Radius=r;
}

public override void Draw(){
    Type t=this.GetType();
    Console.WriteLine("Type="+t.Name);
    Console.WriteLine("("+this.Center+"), Radius="+this.Radius+","+this.Width+","+this.color);
}
public void Print(){
            Console.WriteLine("Printing object on existing printer");
            Type t=this.GetType();
            Console.WriteLine("Type ="+ t.Name);
            Console.WriteLine("("+ this.Center+ "), Radius=" +this.Radius+ ","+
                            this.Width+"," + this.color);
        }

}
