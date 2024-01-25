
//canvas keeps track of all the shapes in the list for the user to update, delete and create new shapes.
using System;
using System.Collections;

//Canvas' job is to store and display shapes created from the CreateShape command

public class Canvas{


  private  ArrayList shapeList = new  ArrayList();
  private ArrayList shapesstorage = new ArrayList();

  private string shape;

  private string shapesList;

  public Canvas()
  {   
     this.shapeList = shapeList;
     
  }
//adds the svg shape string to the list
  public void AddShape(string shape)
  {
    shapeList.Add(shape);
   
    // this.shapeList =shapeList;
  }

  public void StoreList()
  {
 shapesstorage.AddRange(shapeList);
  }
  //prints the shapes being drawn so far
  public void ShapesDrawnList()
  {
    int i=0; //refers to the z-index in the list , where the greater the number the higher the stackin order is.
    foreach(var shape in shapeList)
    {
      Console.WriteLine("["+i+"]"+shape);
       i++;
    }
   
  }
  //to return to main method for the svg shapes to b written in the file
  public string GetShapeDrawnList()
  {
     foreach(var shape in shapeList)
    {
      shapesList += shape+"\n";
    }
    return shapesList;
  }

public void RemoveShape(string shape)
{
 
  shapeList.Remove(shape);
}

public void ClearCanvas()
{
  shapeList.Clear();
}


public void AddAllShapes()
{
  shapeList.AddRange(shapesstorage);
}
//Deletes shape
 


 

}
