using System;
using System.Collections;
using TMPro;
using UnityEngine;


[CreateAssetMenu(fileName = "Dialogue", menuName = "Scriptable Objects/Dialogue")]
public class Dialogue : ScriptableObject
{
    [SerializeField]
    [Multiline]

    private string content;

    [SerializeField]
    private int wordsPerMinute;

    internal IEnumerator Display(TMP_Text textBox)
    {
        textBox.text = content;
        int totalCharacters = textBox.maxVisibleCharacters;
        for (int i = 0; i < totalCharacters; i++)
        {
            textBox.maxVisibleCharacters = i;
            float averageWordLength = 4.8f;
            float charactersPerMinute = averageWordLength * wordsPerMinute;
            float charactersPerSecond = charactersPerMinute / 60.0f;
            float delay = 1.0f / charactersPerSecond;
            yield return new WaitForSeconds(delay);
        }
       
       
    }

}