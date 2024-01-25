// Polygon : Shape -> inheritance

public class Polyline : Shape
{
   private string points;
    private string fill=""; // shape colour
    private string stroke=""; //outline colour
    private string strokewidth=""; //shape thickness

    public Polyline()
    {
        this.points ="20,20 40,25 60,40 80,120 120,140 200,180";
    }
    public  Polyline(string points)
    {
      this.points = points;

    }

    public void setFill(string fill)
    {
         if(fill =="")
        {
            this.fill = "green";
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
        return "<polyline points="+"\""+points+"\""+" stroke="+"\""+stroke+"\""+" stroke-width="+"\""+strokewidth+"\"" +" fill="+"\""+fill+"\""+"/>";
    }
   

}
// <polygon points="220,10 300,210 170,250 123,234" style="fill:lime;stroke:purple;stroke-width:1" />


/*  
 <polyline points="20,20 40,25 60,40 80,120 120,140 200,180"
  style="fill:none;stroke:black;stroke-width:3" />*/
