//creates a shape to be placed on the canvas

public class CreateShape: Command
{
    Canvas newcanvas;
    string shape;
    public CreateShape(Canvas canvas, string shape)
    {
      this.newcanvas = canvas;
      this.shape = shape;
    }

    public void Execute()
    {
        newcanvas.AddShape(shape);
    }


    public void Undo()
    {
       newcanvas.RemoveShape(shape);
    }
}


//how does create shape actually work? -> maybe decide shape on canvas and just call createshape to execute the command? -> CreateShape.execute(usershape)?