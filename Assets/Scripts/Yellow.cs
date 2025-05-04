using UnityEngine;

public class Yellow : Balls
{
private Vector2 yellowPos = new Vector2(-230, 145);
private string yellowText = "Yellow!";
//end of variables

protected override void OnMouseDown()
{
    base.OnMouseDown();
    DisplayColorName(yellowText, yellowPos);   
}

}
