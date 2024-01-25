
public class Square : Shape
{
    private string x;
    private string y;
    private string width;
    private string height;
    private string fill=""; // shape colour
    private string stroke=""; //outline colour
    private string strokewidth=""; //shape thickness

public Square()
{
        this.x = "40";
        this.y = "60";
        this.height= "20";
        this.width = "20";
}
    public Square(string x,string y,string height)
    {
        this.x = x;
        this.y = y;
        this.height= height;
        this.width = height;
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