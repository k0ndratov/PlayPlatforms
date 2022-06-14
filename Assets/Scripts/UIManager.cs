using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private Text UIText;
    private int appleCount;
    private void Awake()
    {
        UIText = GetComponent<Text>();
        appleCount = 0;
        Collectable.collected += IncreaseApple;
    }

    private void IncreaseApple()
    {
        appleCount++;
    }

    private void Update()
    {
        UIText.text = "Колличество яблок: " + appleCount;
    }
}
