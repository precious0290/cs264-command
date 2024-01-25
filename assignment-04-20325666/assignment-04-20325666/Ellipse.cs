
  
public class Ellipse : Shape
{

    private string cx; //circle x
    private string cy;//circle y
    private string rx; //radius x
    private string ry;
    private string fill=""; // shape colour
    private string stroke=""; //outline colour
    private string strokewidth=""; //shape thickness

public Ellipse()
{
    this.cx ="6";
    this.cy ="4";
    this.rx="3";
    this.ry="2";
}
    public Ellipse(string cx,string cy,string rx,string ry)
    {
        this.cx = cx;
        this.cy=cy;
        this.rx = rx;
        this.ry =ry;
    }
    public void setFill(string fill)
    {
         if(fill =="")
        {
            this.fill = "blue";
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
        return "<ellipse cx="+"\""+cx+"\""+ " cy="+ "\""+ cy+ "\"" +" rx="+"\""+rx+"\""+" ry="+"\""+ry+"\""+" stroke="+"\""+stroke+"\""+" stroke-width="+"\""+strokewidth+"\"" +" fill="+"\""+fill+"\""+"/>";
    }
  

    
}
// <ellipse cx="200" cy="80" rx="100" ry="50"
  //style="fill:yellow;stroke:purple;stroke-width:2" />
  //<circle cx="50" cy="50" r="40" stroke="black" stroke-width="3" fill="red" /> -> copied format