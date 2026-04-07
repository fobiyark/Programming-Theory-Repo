using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowShape : Shapes
{
    [SerializeField] TMP_Text nameText;
    [SerializeField] string _name;
    [SerializeField] Color _color;

    private void Start()
    {
        Name = _name;
    }

    protected override void DisplayText()
    {
        nameText.text = Name;
    }

    protected override void DisplayColor()
    {
        ColorShape = _color;
        base.DisplayColor();
    }
}
