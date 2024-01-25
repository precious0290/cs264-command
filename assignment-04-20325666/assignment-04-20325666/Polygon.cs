// Polygon : Shape -> inheritance

public class Polygon : Shape
{
   private string points;
    private string fill=""; // shape colour
    private string stroke=""; //outline colour
    private string strokewidth=""; //shape thickness

    public Polygon()
    {
        this.points ="220,10 300,210 170,250 123,234";
    }
    public  Polygon(string points)
    {
      this.points = points;

    }

    public void setFill(string fill)
    {
         if(fill =="")
        {
            this.fill = "orange";
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
        return "<polygon points="+"\""+points+"\""+" stroke="+"\""+stroke+"\""+" stroke-width="+"\""+strokewidth+"\"" +" fill="+"\""+fill+"\""+"/>";
    }
   

}
// <polygon points="220,10 300,210 170,250 123,234" style="fill:lime;stroke:purple;stroke-width:1" />