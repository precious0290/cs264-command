using System;
using System.Collections.Generic;
//contract for what each shape class must have/contain
interface Shape
{
    void setFill(string fill);
    string getFill();
    void setStroke(string stroke);
    string getStroke();

    void setStrokeWidth(string strokewidth);
    string getStrokeWidth();

    string getShapeAttribute(); //returns the svg string to get added into the list
}