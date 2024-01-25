//clears the canvas

public class ClearCanvas: Command{

Canvas newcanvas;
    public ClearCanvas(Canvas newcanvas) {
       this.newcanvas = newcanvas;
    }

    public void Execute(){
        newcanvas.ClearCanvas();
    }

    public void Undo(){
        newcanvas.AddAllShapes();
    }

}