using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Balls : MonoBehaviour
{
[SerializeField] protected TextMeshProUGUI colorNameText;
private AudioSource audioSource;
private string colorName;
//end of variables

protected string ColorName
    {
        get => colorName;
        set
        {
            if (value.Length <= 10)
            {
                colorName = value;
            }
            else
            {
                Debug.LogWarning("Color name is too long! Max 10 characters.");
                colorName = value.Substring(0, 10) + "-"; // truncate (that means the words get chopped)
            }
        }
    }
    protected void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    protected virtual void OnMouseDown()
    {
            audioSource.Play();
    }

    protected void DisplayColorName(string newColorName, Vector2 textPosition)
{
    ColorName = newColorName;
    colorNameText.rectTransform.anchoredPosition = textPosition;
    colorNameText.text = colorName; 
}

}
