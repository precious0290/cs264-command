// See https://aka.ms/new-console-template for more information
/* Name of App that will control the functions of the app whilst handing the user input

it will export the svg hardcode into an svg file that will hold the shapes
*/
using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DeluxePad
{
  public class Program{


    public static void Main(string[]args)
    {
        Console.WriteLine("Welcome to DeluxePad!"+"\nGet Started Drawing Right Away( Type 's')");
        Console.WriteLine("For information or Help ( Type 'i')");
        Console.WriteLine("To end the program ( Type 'e')");
        Console.WriteLine();

        string fillColour="";
        string strokeColour="";
        string StrokeWidthSize="";
        string userResponse=Console.ReadLine().ToLower();
        string userChoice ="";
         string usercommand =""; //used for deciding what commands the user wants to execute
        Random rand = new Random();
       
         bool endSession = false;
    
        Canvas usercanvas = new Canvas();
        Invoker userinvoker = new Invoker();

        //NOTE: please change line 745, it is a string that downloads the svg file to that specified file directory. So changes the string path
        //on that line to a suitable location for your desktop.

        //Operating System: Windows 10
        //IDE: Visual Studio Code


//old idea
///STEP ONE BREAKDOWN OF  COMMAND IMPLEMENTATION
/* Main class -> calls on CreateShape to createshape 
   Canvas calls on createshape to add shape to canvas
   main class calss on canvas to display the current canvas
   main class saves the canvas to a file on completion?*/

//New idea
/*Main Summary Implementation for Command Pattern 
  Main class user selects a command they would like to execute-> the selected command along with the necessary information
  is passed into the Invoker class to be executed -> the executed command carries out its task by invoking a method from the canvas.
  The command gets stored in the undo stack and once the undo command is invoked , the command is popped off the undo stack and onto
  the redo stack to be un-executed. Once the redo command is invoked the command is popped off the redo stack list and popped back onto the undo stack to be re-executed*/

//Start Menu Switch Statement which displays the choices the user may want to select
        while(endSession==false){
        switch(userResponse) 
        {
            case "i":
           // Console.WriteLine("information!!!!!");
            Console.WriteLine("DeluxePad Version 6.9");
            Console.WriteLine("for more information on Svg please visit: https://developer.mozilla.org/en-US/docs/Web/SVG/Tutorial");
            Console.WriteLine("If you cannot open ur svg file you can use an svg to png converter"+"\nSee here ->https://cloudconvert.com/svg-to-png");
            break;

            case "s":
            Console.WriteLine("");
            Console.WriteLine("Commands:");
            Console.WriteLine("");
            Console.WriteLine("C -> Create a shape ");
            Console.WriteLine("D -> Display canvas ");
            Console.WriteLine("S -> Save canvas to file ");
            Console.WriteLine("U -> Undo most recent command");
            Console.WriteLine("R -> Redo most recent command");
            Console.WriteLine("T -> Trash canvas(clear canvas command");
            Console.WriteLine("E -> Exit ");
            Console.WriteLine("");
          //command menu with description for what each command should do
             usercommand= Console.ReadLine().ToUpper();
            break;

           case "e":
           Console.WriteLine("Your session is finished!"+"\nHave a nice day<3 ");
           Environment.Exit(0);
           break;

           default:
            Console.WriteLine("No option was selected!"+"\nPlease select an option from the menu!");

            Console.WriteLine("");
            Console.WriteLine("To get started right away (Type 's')");
            Console.WriteLine("For information or Help ( Type 'i')");
            Console.WriteLine("To end the program ( Type 'end')");
            userResponse= Console.ReadLine();
            break;


  
            

        }
           
//Commands switch menu -> invoked when user types "s"
       switch(usercommand)
       {
            case "C":
            Console.WriteLine("Creating a shape");
            Console.WriteLine("[1] -> Create a random shape"+"\n[2] -> Choose a shape to create");
            userChoice=Console.ReadLine();
            if(userChoice == "1")
            {
               userChoice = rand.Next(1,9).ToString(); //1-8 
               //the first parameter is inclusive while the second parameter is exclusive; meaning that the method could return the lower bound but could not return the upper bound.
               //https://code-maze.com/csharp-generate-random-numbers-range/
               //the reason i have the random number parsed to a string is because my switch cases take string arguments.
            }
            else if(userChoice == "2")
            {
            Console.WriteLine("[1] -> Circle"+"\n[2] -> Ellipse"+"\n[3] -> Line");
            Console.WriteLine("[4] -> Path"+  "\n[5] -> Polygon"+"\n[6] -> Polyline");
            Console.WriteLine("[7] -> Rectangle" + "\n[8] -> Square" );
            userChoice = Console.ReadLine();
            }
           //create shape command
            break;

            case "D":
            Console.WriteLine("Displaying Canvas");
            userChoice = "display";
            //display canvas
            break;

            case "S":
            Console.WriteLine("Save canvas to file");
           userChoice="save";
           //save canvas to file
            break;
            
            case "U":
            Console.WriteLine("Undoing most recent command");
            userChoice ="undo";
            //undo command
            break;

            case "R":
             Console.WriteLine("Redoing most recent command");
           userChoice ="redo";
           //redo command
            break;
            
            case "T":
            Console.WriteLine("Trashing canvas(clear canvas command)");
            userChoice="clear"; 
            //clears canvas command
            break;

            case "E":
            Console.WriteLine("Exit");
             Console.WriteLine("Your session is finished!"+"\nHave a nice day<3 ");
             Environment.Exit(0);
             //exits program
            break;
       }


      Shape userShape  = new Circle(); // -> defined in my switch case scope so i can refer to it at any point within the switch
      string userDecision; //used for deciding what attributes, if any should b added to their shape
     
     //menu for creating, undoing , redoing  shapes, saving to a file, and clearing the canvas invoked from the command switch statement
         switch(userChoice)
         {
            case "1":
            Console.WriteLine("Drawing a Circle!");
            Console.WriteLine("Would you like to change default circle size?"+"\n(Type 'y' for yes)"+"\n(Type 'n' for no)" );
           userDecision = Console.ReadLine().ToLower();
             
           if(userDecision=="y")
           {
            Console.WriteLine("Type in 3 numbers,pressing enter everytime");
            Console.WriteLine("Circle x: ");
            string userCx = Console.ReadLine();
            Console.WriteLine("Circle y: ");
            string userCy= Console.ReadLine();
            Console.WriteLine("Radius: ");
            string userRadius = Console.ReadLine();
            userShape = new Circle(userCx,userCy,userRadius);
            
           }
           else if(userDecision=="n"){
             userShape = new Circle();
           }
           userDecision="";
           Console.WriteLine("Would you like to change the default circle colour and the line thickness size?"+"\n(Type 'y' for yes)"+"\n(Type 'n' for no)");
           userDecision = Console.ReadLine().ToLower();

           if(userDecision=="y")
           {
             Console.WriteLine("Type in 2 colours and a number,pressing enter everytime");
             Console.WriteLine("Shape Colour:");
             string fillcolour = Console.ReadLine().ToLower();
             Console.WriteLine("Shape Outline Colour");
             string strokecolour = Console.ReadLine().ToLower();
             Console.WriteLine("Shape Outline Thickness");
             string strokesize = Console.ReadLine();
             userShape.setFill(fillcolour);  
             userShape.setStroke(strokecolour);
             userShape.setStrokeWidth(strokesize);
             Console.WriteLine("This is your Circle!");
           Console.WriteLine(userShape.getShapeAttribute());
             
           }
           else if(userDecision=="n")
           {
             userShape.setFill("");
             userShape.setStroke("");
             userShape.setStrokeWidth("");
             Console.WriteLine("This is your Circle!");
           Console.WriteLine(userShape.getShapeAttribute());
           }
           fillColour = userShape.getFill();
           strokeColour= userShape.getStroke();
           StrokeWidthSize = userShape.getStrokeWidth();

                 
          CreateShape command = new CreateShape(usercanvas, userShape.getShapeAttribute());
           command.Execute();
           userinvoker.AddCommand(command);
           Console.WriteLine("");
       userResponse = "s";//goes back to the start menu switch statement to showcase the app's commands

         //adds svg circle string to list
            break;


            case "2":
            Console.WriteLine("Drawing a Ellipse!");
            Console.WriteLine("Would you like to change default ellipse size?"+"\n(Type 'y' for yes)"+"\n(Type 'n' for no)" );
           userDecision = Console.ReadLine().ToLower();
             userShape  = new Ellipse();
           if(userDecision=="y")
           {
            Console.WriteLine("Type in 4 numbers, pressing enter everytime");
            Console.WriteLine("Circle x coordinate");
            string userCx = Console.ReadLine();
            Console.WriteLine("Circle y coordinate");
            string userCy= Console.ReadLine();
            Console.WriteLine("Circle Radius x coordinate");
            string userRx = Console.ReadLine();
            Console.WriteLine("Circle Radius y coordinate");
            string userRy = Console.ReadLine();
            userShape = new Ellipse(userCx,userCy,userRx,userRy);

            
           }
           else if(userDecision=="n"){
             userShape = new Ellipse();
           }
           userDecision="";
           Console.WriteLine("Would you like to change the default ellipse colour and the line thickness size?"+"\n(Type 'y' for yes)"+"\n(Type 'n' for no)");
           userDecision = Console.ReadLine().ToLower();
             if(userDecision=="y")
           {Console.WriteLine("Type in 2 colours and a number,pressing enter everytime");
             Console.WriteLine("Shape Colour:");
             string fillcolour = Console.ReadLine().ToLower();
             Console.WriteLine("Shape Outline Colour");
             string strokecolour = Console.ReadLine().ToLower();
             Console.WriteLine("Shape Outline Thickness");
             string strokesize = Console.ReadLine();
             userShape.setFill(fillcolour);  
             userShape.setStroke(strokecolour);
             userShape.setStrokeWidth(strokesize);
             Console.WriteLine("This is your Ellipse!");
           Console.WriteLine(userShape.getShapeAttribute());
             
           }
           else if(userDecision=="n")
           {
             userShape.setFill("");
             userShape.setStroke("");
             userShape.setStrokeWidth("");
             Console.WriteLine("This is your Ellipse!");
           Console.WriteLine(userShape.getShapeAttribute());
           }
           fillColour = userShape.getFill();
           strokeColour= userShape.getStroke();
           StrokeWidthSize = userShape.getStrokeWidth();
           
           CreateShape command1 = new CreateShape(usercanvas, userShape.getShapeAttribute());
           command1.Execute();
           userinvoker.AddCommand(command1);
           Console.WriteLine("");
         userResponse = "s";//goes back to the start menu switch statement to showcase the app's commands

             
            break;

            case "3":
            Console.WriteLine("Drawing a Line!");
            userDecision="";
          
            Console.WriteLine("Would you like to change default line size?"+"\n(Type 'y' for yes)"+"\n(Type 'n' for no)" );
           userDecision = Console.ReadLine().ToLower();
            
             userShape = new Line();
           if(userDecision=="y")
           {
            Console.WriteLine("Type in 4 numbers, pressing enter everytime");
            Console.WriteLine("Line x1 coordinate");
            string userX1 = Console.ReadLine();
            Console.WriteLine("Line x2 coordinate");
            string userX2= Console.ReadLine();
            Console.WriteLine("Line y1 coordinate");
            string userY1 = Console.ReadLine();
            Console.WriteLine("Line y2 coordinate");
            string userY2 = Console.ReadLine();
            userShape = new Line(userX1,userX2,userY1,userY2);

            
           }
           else if( userDecision=="n")
           {
            userShape = new Line();
           }
             
           
           userDecision="";
           Console.WriteLine("Would you like to change the default line colour and the line thickness size?"+"\n(Type 'y' for yes)"+"\n(Type 'n' for no)");
           userDecision = Console.ReadLine();
             if(userDecision=="y")
           {
            Console.WriteLine("Type in 1 colour and a number,pressing enter everytime");
             Console.WriteLine("Shape Outline Colour");
             string strokecolour = Console.ReadLine().ToLower();
             Console.WriteLine("Shape Outline Thickness");
             string strokesize = Console.ReadLine();  
             userShape.setStroke(strokecolour);
             userShape.setStrokeWidth(strokesize);
             Console.WriteLine("This is your Line!");
           Console.WriteLine(userShape.getShapeAttribute());
             
           }
           else if(userDecision=="n")
           {
         
             userShape.setStroke("");
             userShape.setStrokeWidth("");
             Console.WriteLine("This is your Line!");
           Console.WriteLine(userShape.getShapeAttribute());
           }
           
           strokeColour= userShape.getStroke();
           StrokeWidthSize = userShape.getStrokeWidth();
          CreateShape command2 = new CreateShape(usercanvas, userShape.getShapeAttribute());
           command2.Execute();
           userinvoker.AddCommand(command2);
          userResponse = "s";//goes back to the start menu switch statement to showcase the app's commands
           Console.WriteLine("");
           
            break;

            case "4":
            Console.WriteLine("Drawing a Path!");
                      userDecision="";
          
            Console.WriteLine("Would you like to change default path size?"+"\n(Type 'y' for yes)"+"\n(Type 'n' for no)" );
           userDecision = Console.ReadLine();
            
             userShape = new Path();
           if(userDecision=="y")
           {
            Console.WriteLine("Type in a line with 7 inputs in a row, for example: M150 0 L75 200 L225 200 Z ");
            string path = Console.ReadLine();

            userShape = new Path(path);

            
           }
           else if( userDecision=="n")
           {
            userShape = new Path();
           }
             
           
           userDecision="";
           Console.WriteLine("Would you like to change the default path colour and the line thickness size?"+"\n(Type 'y' for yes)"+"\n(Type 'n' for no)");
           userDecision = Console.ReadLine();
             if(userDecision=="y")
           {
            Console.WriteLine("Type in 2 colours and a number,pressing enter everytime");
             Console.WriteLine("Shape Colour:");
             string fillcolour = Console.ReadLine().ToLower();
             Console.WriteLine("Shape Outline Colour");
             string strokecolour = Console.ReadLine().ToLower();
             Console.WriteLine("Shape Outline Thickness");
             string strokesize = Console.ReadLine();
             userShape.setFill(fillcolour);  
             userShape.setStroke(strokecolour);
             userShape.setStrokeWidth(strokesize);
             Console.WriteLine("This is your Path!");
           Console.WriteLine(userShape.getShapeAttribute());
             
           }
           else if(userDecision=="n")
           {
             userShape.setFill("");
             userShape.setStroke("");
             userShape.setStrokeWidth("");
             Console.WriteLine("This is your Path!");
           Console.WriteLine(userShape.getShapeAttribute());
           }
           fillColour = userShape.getFill();
           strokeColour= userShape.getStroke();
           StrokeWidthSize = userShape.getStrokeWidth();
           CreateShape command3 = new CreateShape(usercanvas, userShape.getShapeAttribute());
           command3.Execute();
           userinvoker.AddCommand(command3);
           userResponse = "s";//goes back to the start menu switch statement to showcase the app's commands
            break; 

            case "5":
            Console.WriteLine("Drawing a Polygon!");
            userDecision="";
          
            Console.WriteLine("Would you like to change default polygon size?"+"\n(Type 'y' for yes)"+"\n(Type 'n' for no)" );
           userDecision = Console.ReadLine();
            
             userShape = new Polygon();
           if(userDecision=="y")
           {
            Console.WriteLine("Type in a line with 8 inputs in a row, for example: 220,10 300,210 170,250 123,234 ");
            string points = Console.ReadLine();

            userShape = new Polygon(points);

            
           }
           else if( userDecision=="n")
           {
            userShape = new Polygon();
           }
             
           
           userDecision="";
           Console.WriteLine("Would you like to change the default polygon colour and the line thickness size?"+"\n(Type 'y' for yes)"+"\n(Type 'n' for no)");
           userDecision = Console.ReadLine();
             if(userDecision=="y")
           {
            Console.WriteLine("Type in 2 colours and a number,pressing enter everytime");
             Console.WriteLine("Shape Colour:");
             string fillcolour = Console.ReadLine().ToLower();
             Console.WriteLine("Shape Outline Colour");
             string strokecolour = Console.ReadLine().ToLower();
             Console.WriteLine("Shape Outline Thickness");
             string strokesize = Console.ReadLine();
             userShape.setFill(fillcolour);  
             userShape.setStroke(strokecolour);
             userShape.setStrokeWidth(strokesize);
             Console.WriteLine("This is your Polygon!");
           Console.WriteLine(userShape.getShapeAttribute());
             
           }
           else if(userDecision=="n")
           {
             userShape.setFill("");
             userShape.setStroke("");
             userShape.setStrokeWidth("");
             Console.WriteLine("This is your Polygon!");
           Console.WriteLine(userShape.getShapeAttribute());
           }
           fillColour = userShape.getFill();
           strokeColour= userShape.getStroke();
           StrokeWidthSize = userShape.getStrokeWidth();
            CreateShape command4 = new CreateShape(usercanvas, userShape.getShapeAttribute());
           command4.Execute();
           userinvoker.AddCommand(command4);
         userResponse = "s";//goes back to the start menu switch statement to showcase the app's commands
           Console.WriteLine("");
            break;

            case "6":
            Console.WriteLine("Drawing a Polyline!");
              userDecision="";
          
            Console.WriteLine("Would you like to change default polyline size?"+"\n(Type 'y' for yes)"+"\n(Type 'n' for no)" );
           userDecision = Console.ReadLine();
            
             userShape = new Polyline();
           if(userDecision=="y")
           {
            Console.WriteLine("Type in a line with 12 inputs in a row, for example: 20,20 40,25 60,40 80,120 120,140 200,180 ");
            Console.WriteLine("Each x, y position is separated by a comma -> 7,6 ==> 7 is x, 6 is y");
            string points = Console.ReadLine();

            userShape = new Polyline(points);

            
           }
           else if( userDecision=="n")
           {
            userShape = new Polyline();
           }
             
           
           userDecision="";
           Console.WriteLine("Would you like to change the default polyline colour and the line thickness size?"+"\n(Type 'y' for yes)"+"\n(Type 'n' for no)");
           userDecision = Console.ReadLine();
             if(userDecision=="y")
           {
            Console.WriteLine("Type in 2 colours and a number,pressing enter everytime");
             Console.WriteLine("Shape Colour:");
             string fillcolour = Console.ReadLine().ToLower();
             Console.WriteLine("Shape Outline Colour");
             string strokecolour = Console.ReadLine().ToLower();
             Console.WriteLine("Shape Outline Thickness");
             string strokesize = Console.ReadLine();
             userShape.setFill(fillcolour);  
             userShape.setStroke(strokecolour);
             userShape.setStrokeWidth(strokesize);
             Console.WriteLine("This is your Polyline!");
           Console.WriteLine(userShape.getShapeAttribute());
             
           }
           else if(userDecision=="n")
           {
             userShape.setFill("");
             userShape.setStroke("");
             userShape.setStrokeWidth("");
             Console.WriteLine("This is your Polyline!");
           Console.WriteLine(userShape.getShapeAttribute());
           }
           fillColour = userShape.getFill();
           strokeColour= userShape.getStroke();
           StrokeWidthSize = userShape.getStrokeWidth();
           CreateShape command5 = new CreateShape(usercanvas, userShape.getShapeAttribute());
           command5.Execute();
           userinvoker.AddCommand(command5);
         userResponse = "s";//goes back to the start menu switch statement to showcase the app's commands
           Console.WriteLine("");
            break;

            case "7":
            Console.WriteLine("Drawing a Rectangle!");
              userDecision="";
          
            Console.WriteLine("Would you like to change default rectangle size?"+"\n(Type 'y' for yes)"+"\n(Type 'n' for no)" );
           userDecision = Console.ReadLine();
            
             userShape = new Rectangle();
           if(userDecision=="y")
           {
            Console.WriteLine("Type in 4 numbers, pressing enter everytime ");
            Console.WriteLine("Rectangle x coordinate:");
            string x = Console.ReadLine();
            Console.WriteLine("Rectangle y coordinate:");
            string y = Console.ReadLine();
            Console.WriteLine("Rectangle height:");
            string height = Console.ReadLine();
            Console.WriteLine("Rectangle weight:");
            string width = Console.ReadLine();

            userShape = new Rectangle(x,y,height,width);

            
           }
           else if( userDecision=="n")
           {
            userShape = new Rectangle();
           }
             
           
           userDecision="";
           Console.WriteLine("Would you like to change the default rectangle colour and the line thickness size?"+"\n(Type 'y' for yes)"+"\n(Type 'n' for no)");
           userDecision = Console.ReadLine();
             if(userDecision=="y")
           {
             Console.WriteLine("Type in 2 colours and a number,pressing enter everytime");
             Console.WriteLine("Shape Colour:");
             string fillcolour = Console.ReadLine().ToLower();
             Console.WriteLine("Shape Outline Colour");
             string strokecolour = Console.ReadLine().ToLower();
             Console.WriteLine("Shape Outline Thickness");
             string strokesize = Console.ReadLine();
             userShape.setFill(fillcolour);  
             userShape.setStroke(strokecolour);
             userShape.setStrokeWidth(strokesize);
             Console.WriteLine("This is your Rectangle!");
           Console.WriteLine(userShape.getShapeAttribute());
             
           }
           else if(userDecision=="n")
           {
             userShape.setFill("");
             userShape.setStroke("");
             userShape.setStrokeWidth("");
              Console.WriteLine("This is your Rectangle!");
           Console.WriteLine(userShape.getShapeAttribute());
           }
           fillColour = userShape.getFill();
           strokeColour= userShape.getStroke();
           StrokeWidthSize = userShape.getStrokeWidth();
          CreateShape command6 = new CreateShape(usercanvas, userShape.getShapeAttribute());
           command6.Execute();
           userinvoker.AddCommand(command6);
           userResponse = "s";//goes back to the start menu switch statement to showcase the app's commands
           Console.WriteLine("");
            break; 


            case "8":
            Console.WriteLine("Drawing a Square!");
              userDecision="";
          
            Console.WriteLine("Would you like to change default square size?"+"\n(Type 'y' for yes)"+"\n(Type 'n' for no)" );
           userDecision = Console.ReadLine();
            
             userShape = new Rectangle();
           if(userDecision=="y")
           {
            Console.WriteLine("Type in 3 numbers, pressing enter everytime ");
            Console.WriteLine("Square x coordinate:");
            string x = Console.ReadLine();
            Console.WriteLine("Square y coordinate:");
            string y = Console.ReadLine();
            Console.WriteLine("Square height:");
            string height = Console.ReadLine();


            userShape = new Square(x,y,height);
            
           }
           else if( userDecision=="n")
           {
           userShape = new Square();
           }
             
           
           userDecision="";
           Console.WriteLine("Would you like to change the default square colour and the line thickness size?"+"\n(Type 'y' for yes)"+"\n(Type 'n' for no)");
           userDecision = Console.ReadLine();
             if(userDecision=="y")
           {
             Console.WriteLine("Type in 2 colours and a number,pressing enter everytime");
             Console.WriteLine("Shape Colour:");
             string fillcolour = Console.ReadLine().ToLower();
             Console.WriteLine("Shape Outline Colour");
             string strokecolour = Console.ReadLine().ToLower();
             Console.WriteLine("Shape Outline Thickness");
             string strokesize = Console.ReadLine();
             userShape.setFill(fillcolour);  
             userShape.setStroke(strokecolour);
             userShape.setStrokeWidth(strokesize);
             Console.WriteLine("This is your Square!");
             
           Console.WriteLine(userShape.getShapeAttribute());
             
           }
           else if(userDecision=="n")
           {
             userShape.setFill("");
             userShape.setStroke("");
             userShape.setStrokeWidth("");
              Console.WriteLine("This is your Square!");
              
           Console.WriteLine(userShape.getShapeAttribute());
           }
           fillColour = userShape.getFill();
           strokeColour= userShape.getStroke();
           StrokeWidthSize = userShape.getStrokeWidth();
          CreateShape command7 = new CreateShape(usercanvas, userShape.getShapeAttribute());
           command7.Execute();
           userinvoker.AddCommand(command7);
          userResponse = "s"; //goes back to the start menu switch statement to showcase the app's commands
           Console.WriteLine("");
            break; 

            case "undo":
            Console.WriteLine("");
            Console.WriteLine("Last Command was undone!");
           userinvoker.UndoCommand();
           userResponse = "s";
            break;

            case "redo":
            Console.WriteLine("Last Command was redone!");
           userinvoker.RedoCommand();
           Console.WriteLine("");
           userResponse = "s";
            break;

            case "clear":
            Console.WriteLine("");
             usercanvas.StoreList();
            ClearCanvas command8  = new ClearCanvas(usercanvas);
            command8.Execute();
             userinvoker.AddCommand(command8);
             userResponse = "s";
            break;

            case "display":
            usercanvas.ShapesDrawnList();
            userResponse = "s";
            break;

            case "save":
            endSession = true;
            break;

             default:
            Console.WriteLine("[1] -> Circle"+"\n[2] -> Ellipse"+"\n[3] -> Line");
            Console.WriteLine("[4] -> Path"+  "\n[5] -> Polygon"+"\n[6] -> Polyline");
            Console.WriteLine("[7] -> Rectangle" + "\n[8] -> Square" );
            userResponse = "s";
            break; 
            
         }

       
         
        }


 Console.WriteLine();        
//svg string 
string svgStartTag ="<svg height=\"1080\" width=\"800\">";
string svgEndTag="</svg>";

//manages svg file export
string userFileName="UserSketchpad.svg";
Console.WriteLine("Would you like to create a name for your file?"+"\n(Type 'y' for yes)"+"(Type 'n' for no)");
  Console.WriteLine();
  string userFileChoice = Console.ReadLine();


  switch(userFileChoice)
  {
    case "y":
     Console.WriteLine("Type in a name for your file, for example: Sketchpad.svg");
     userFileName = Console.ReadLine();
    break;

    case "n":
    userFileName="UserSketchpad.svg";
    break;
  }

 string pathString = @"C:\Users\pdere\Downloads\3rd-Year-Modules\CS264\assignment-04-20325666\SVGTest4";
 pathString = System.IO.Path.Combine(pathString, userFileName);
   
   Console.WriteLine("Writing your svg file to a folder");
using(StreamWriter sw = File.CreateText(pathString))
{
  sw.WriteLine(svgStartTag);
 sw.WriteLine(usercanvas.GetShapeDrawnList());
  sw.WriteLine();
  sw.WriteLine(svgEndTag);
  
}
Console.WriteLine("If you cannot open ur svg file you can use an svg to png converter"+"\nSee here ->https://cloudconvert.com/svg-to-png");
Console.WriteLine();
Console.WriteLine("What your svg file looks like:");
Console.WriteLine();
Console.WriteLine(svgStartTag);
usercanvas.ShapesDrawnList();
Console.WriteLine(svgEndTag);
      
     

   


    }
   
   
}


}


