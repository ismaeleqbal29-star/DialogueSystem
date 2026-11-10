using System.Runtime.CompilerServices;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [SerializeField]
    private DialogueBox dialogueBox;
    [SerializeField]
    private Dialogue dialogue;
   private void OnTriggerEnter(Collider other)
   {
      if (other.CompareTag("Player"))
      {
        dialogueBox.Display(dialogue);
      }
   }

   private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            dialogueBox.Hide();
        }
    }
}
