using UnityEngine;

public class Yellow : Balls // INHERITANCE
{
private Vector2 yellowPos = new Vector2(-230, 145); // ABSTRACTION
private string yellowText = "Yellow!"; // ABSTRACTION
//end of variables

protected override void OnMouseDown() // POLYMORPHISM
{
    base.OnMouseDown();
    DisplayColorName(yellowText, yellowPos); // ABSTRACTION
}

}
