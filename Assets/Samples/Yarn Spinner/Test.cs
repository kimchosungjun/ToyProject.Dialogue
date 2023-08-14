using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class Test : MonoBehaviour
{
    DialogueRunner dialogueRunner;
    private void Awake()
    {
        dialogueRunner = FindObjectOfType<DialogueRunner>();
    }
    public void OnClicked()
    {
        dialogueRunner.StartDialogue("Start");
    }
}
