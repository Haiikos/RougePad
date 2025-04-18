using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NotepadosTextopados : MonoBehaviour
{
    public TMP_InputField inputField;

    public void SaveText()
    {
        string savetext = inputField.text;
        PlayerPrefs.SetString("notepadContent", savetext);
        PlayerPrefs.Save();
        Debug.Log("text saved");
    }

    public void LoadText()
    {
        if (PlayerPrefs.HasKey("notepadContent")) 
        {
            inputField.text = PlayerPrefs.GetString("notepadContent");
            Debug.Log("text load");
        }
    }

    public void ClearText()
    {
        inputField.text = "";
    }
}
