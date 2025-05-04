using UnityEngine;

public class Red : Balls
{
private Vector2 redPos = new Vector2(0, 145);
private string redText = "Red!";
//end of variables

protected override void OnMouseDown()
{
    base.OnMouseDown();
    DisplayColorName(redText, redPos);   
}

}
