using UnityEngine;

public class Collectable : MonoBehaviour
{
    public GameObject collector;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == collector)
        {
            collected.Invoke();
        }

        Destroy(this.gameObject);
    }

    public delegate void UIContainer();

    public static event UIContainer collected;
}
