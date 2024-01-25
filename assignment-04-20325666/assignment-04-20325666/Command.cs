 public interface Command{
    //these are methods command uses to execute what the user wants to do with an action
    public void Execute(); //responsible for executing the commands for the program -> needs to be in every canvas command class
    public void Undo(); //responsible for undoing the commands
  


 //commands for canvas -> canvas will implement these -> these need classes
   // public void CreateShape();
  //  public void DeleteShape();
}

/* Plan: create classes for createshape, deleteshape, updateshape and clearcanvas( basically all ur methods from the canvas class)

what does the canvas do then? is the canvas just for display? 
*/