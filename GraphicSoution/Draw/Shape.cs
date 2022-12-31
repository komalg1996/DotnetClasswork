namespace Draw;
public enum Color{RED,GREEN,BLUE};
public abstract class Shape{
    protected int Width{get;set;}
    protected Color color{get;set;}

    //Draw method 
    public abstract void Draw();

}