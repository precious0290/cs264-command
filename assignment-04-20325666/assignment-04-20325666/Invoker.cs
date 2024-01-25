//Invoker stores all the commands in a list for the undo redo functionality


using System;
using System.Collections;
public class Invoker{
  
    public  Stack<Command> undo = new Stack<Command>();
    public  Stack<Command> redo = new Stack<Command>();
    
   

   public void AddCommand(Command command)
   {
            undo.Push(command);
            redo.Clear();
   }

   public void UndoCommand()
   {

   if(undo.Count > 0)
   {
    var undid = undo.Pop();
    undid.Undo();
    redo.Push(undid);
   }
   else{
    Console.WriteLine("Nothing to undo");
   }

    
   }

   public void RedoCommand()
   {
    if(redo.Count > 0)
    {
        var redone = redo.Pop();
        redone.Execute();
        undo.Push(redone);
    }
    else
        {
            Console.WriteLine("Nothing to redo");
        }
   }



    //   public  void Action(string shape, Command command, Canvas usercanvas)
    //     {

                                 
    //      undo.Push(command);
    //      redo.Clear();
    //     } 

    

          
}