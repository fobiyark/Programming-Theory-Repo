using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shapes : MonoBehaviour
{
    private string nameShape; // ENCAPSULATION

    // ENCAPSULATION
    public string Name
    {
        get { return nameShape; }
        set
        {
            if(string.IsNullOrEmpty(value))
            {
                Debug.LogError("name must not be blank");
            }
            else if (!value.All(char.IsLetter))
            {
                Debug.LogError("Use Letter Please");
            }
            else
            {
                nameShape = value;
            }

        }
    }
    // ENCAPSULATION
    private Color colorShape;
    // ENCAPSULATION
    protected Color ColorShape { get { return colorShape; } set{ colorShape = value; } }

    //INHERITANCE
    private void OnMouseDown()
    {
        DisplayText();// ABSTRACTION
        DisplayColor();// ABSTRACTION
    }

    //POLYMORPHISM
    protected abstract void DisplayText();

    //POLYMORPHISM
    protected virtual void DisplayColor()
    {
        GetComponent<Renderer>().material.color = ColorShape;
    } 
}
