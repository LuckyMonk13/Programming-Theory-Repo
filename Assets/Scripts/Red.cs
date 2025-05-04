using UnityEngine;

public class Red : Balls // INHERITANCE
{
private Vector2 redPos = new Vector2(0, 145); // ABSTRACTION
private string redText = "Red!"; // ABSTRACTION
//end of variables

protected override void OnMouseDown() // POLYMORPHISM
{
    base.OnMouseDown();
    DisplayColorName(redText, redPos); // ABSTRACTION
}

}
