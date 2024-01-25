//<path d="M150 0 L75 200 L225 200 Z" />
// <path id="lineAB" d="M 100 350 l 150 -300" stroke="red"
 // stroke-width="3" fill="none" />
  public class Path : Shape
 {
   private string path;
    private string fill=""; // shape colour
    private string stroke=""; //outline colour
    private string strokewidth=""; //shape thickness
    
    public Path()
    {
     this.path="M150 0 L75 200 L225 200 Z";
    }
    public Path(string path)
    {
       this.path = path;
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
        return "<path d="+"\""+path+"\""+" stroke="+"\""+stroke+"\""+" stroke-width="+"\""+strokewidth+"\"" +" fill="+"\""+fill+"\"" +"/>";
    }
   
    


    
 }
 //<line x1 = "20" y1 = "20" x2 = "200" y2 = "180" stroke = "black" stroke-width = "3"/>
 //<path d="M150 0 L75 200 L225 200 Z" />
// <path id="lineAB" d="M 100 350 l 150 -300" stroke="red"
 // stroke-width="3" fill="none" />
