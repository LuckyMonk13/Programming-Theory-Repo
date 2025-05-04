using UnityEngine;

public class Blue : Balls
{
private Vector2 bluePos = new Vector2(230, 145);
private string blueText = "Blue!";
//end of variables

protected override void OnMouseDown()
{
    base.OnMouseDown();
    DisplayColorName(blueText, bluePos);   
}

}
