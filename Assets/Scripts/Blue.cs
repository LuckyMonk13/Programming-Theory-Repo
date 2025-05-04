using UnityEngine;

public class Blue : Balls // INHERITANCE
{
private Vector2 bluePos = new Vector2(230, 145); // ABSTRACTION
private string blueText = "Blue!"; // ABSTRACTION
//end of variables

protected override void OnMouseDown() // POLYMORPHISM
{
    base.OnMouseDown();
    DisplayColorName(blueText, bluePos); // ABSTRACTION
}

}
