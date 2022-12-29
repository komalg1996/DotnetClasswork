namespace Maths;

public class Complex{
private int real;
private int img;
//default ctr
public Complex(){
    this.real=0;
    this.img=0;
}
//paramitrised ctr
public Complex(int r, int i){
    this.real=r;
    this.img=i;
}
//property
public int Real{
    get{return this.real;}
    set{this.real=value;}
}
public int Img{
    get{return this.img;}
    set{this.img=value;}
}

public override string ToString(){
    return string.Format("real{0} img{1},", this.real,this.img);
}
public static Complex operator+ (Complex c1,Complex c2)
{
    Complex cc=new Complex();
    cc.Real=c1.Real+c2.Real;
    cc.Img=c1.Img+c2.Img;
    return cc;
}
}