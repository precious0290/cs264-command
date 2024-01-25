 public class Line : Shape
 {
    private string x1;
    private string x2;
    private string y1;
    private string y2;
    private string fill=""; // shape colour
    private string stroke=""; //outline colour
    private string strokewidth=""; //shape thickness
    
    public Line()
    {
        this.x1="20";
        this.x2="200";
        this.y1="20";
        this.y2="180";
    }
    public Line(string x1,string x2,string y1,string y2)
    {
        this.x1=x1;
        this.x2=x2;
        this.y1=y1;
        this.y2=y2;
    }

//dont need to use setFill because the line will not show, so setFill(value) for line is redundant
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
        return "<line x1="+"\""+x1+"\""+ " y1="+ "\""+ y1+ "\"" +" x2="+"\""+x2+"\""+" y2="+"\""+y2+"\""+" stroke="+"\""+stroke+"\""+" stroke-width="+"\""+strokewidth+"\"" +"/>";
    }
    


    
 }
 //<line x1 = "20" y1 = "20" x2 = "200" y2 = "180" stroke = "black" stroke-width = "3"/>
