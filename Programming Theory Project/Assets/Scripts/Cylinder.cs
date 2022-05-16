using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cylinder : Shape
{
    // POLYMORPHISM
    protected override void PrintName()
    {
        Debug.Log(ShapeMaterial.name + " " + Name);
    }
}
