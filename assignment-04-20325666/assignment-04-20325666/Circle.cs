
public class Circle : Shape
{

    private string cx; //circle x
    private string cy;//circle y
    private string r; //radius
    private string fill=""; // shape colour
    private string stroke=""; //outline colour
    private string strokewidth=""; //shape thickness

public Circle()
{
    this.cx ="4";
    this.cy ="4";
    this.r="2";
}
    public Circle(string cx,string cy,string r)
    {
        this.cx = cx;
        this.cy=cy;
        this.r = r;
        
        getStrokeWidth();
        getFill();
        getStroke();
    }
   /* public double getCX()
    {
        return cx;
    }
    public double getCY()
    {
        return cy;
    }
    public double getR()
    {
        return r;
    } */
    public void setFill(string fill)
    {
         if(fill =="")
        {
            this.fill = "red";
        }
        else{
            this.fill = fill;
        }
       
    }
    public string getFill()
    {
        return fill;
    }
    public void setStroke(string stroke)
    {
        if(stroke=="")
        {
          this.stroke = "black";  
        }
        else{
             this.stroke = stroke;
        }
       
    }
    public string getStroke()
    {
        return stroke;
    }
    public  void setStrokeWidth(string strokewidth)
    {
       
        if(strokewidth=="")
        {
            this.strokewidth ="1";
        }
        else{
             this.strokewidth = strokewidth;
        }
    }
    public string getStrokeWidth()
    {
        return strokewidth;
    }
    
    public string getShapeAttribute()
    {
        //svg representation
        return "<circle cx="+"\""+cx+"\""+ " cy="+ "\""+ cy+ "\"" +" r="+"\""+r+"\""+" stroke="+"\""+stroke+"\""+" stroke-width="+"\""+strokewidth+"\"" +" fill="+"\""+fill+"\""+"/>";
    }


    
}
//<circle cx="50" cy="50" r="40" stroke="black" stroke-width="3" fill="red" />