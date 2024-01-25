
public class Rectangle : Shape
{
    private string x;
    private string y;
    private string width;
    private string height;
    private string fill=""; // shape colour
    private string stroke=""; //outline colour
    private string strokewidth=""; //shape thickness

public Rectangle()
{
        this.x = "40";
        this.y = "60";
        this.height= "10";
        this.width = "20";
}
    public Rectangle(string x,string y,string height, string width)
    {
        this.x = x;
        this.y = y;
        this.height= height;
        this.width = width;
    }

public void setFill(string fill)
    {
         if(fill =="")
        {
            this.fill = "purple";
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
        return "<rect x="+"\""+x+"\""+ " y="+ "\""+ y+ "\""+" width="+"\""+width+"\""+" height="+"\""+height+"\""+" stroke="+"\""+stroke+"\""+" stroke-width="+"\""+strokewidth+"\"" +" fill="+"\""+fill+"\""+"/>";
    }
  
}
//<rect x = "10" y = "10" width = "40" height = "68" fill = "yellow" stroke = "black" stroke-width = "3"/>.