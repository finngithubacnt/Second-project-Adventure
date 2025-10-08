using UnityEngine;
using System.Collections.Generic;
using System;

[Serializable]
public struct DialoguePiece
{
    public string name;
    [TextArea] public string dialogue;
}
public class DieALog : MonoBehaviour
{
   public List<DialoguePiece> dialogue;

    public void StartDialogue()
    {

    }
}
