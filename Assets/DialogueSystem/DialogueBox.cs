using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueBox : MonoBehaviour
{
    [SerializeField]
    private TMP_Text content;

    [SerializeField]
    private Image portrait;

    private void Start()
    {
        gameObject.SetActive(false);
    }

    internal void Display(Dialogue dialogue)
    {
        gameObject.SetActive(true);
        StartCoroutine(dialogue.Display(content));
    }

    internal void Hide()
    {
        gameObject.SetActive(false);
    }
}
