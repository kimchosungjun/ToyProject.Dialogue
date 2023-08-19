using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
public class DialogueManager : DialogueViewBase
{
    DialogueRunner dialogueRunner;
    static DialogueManager dialogueManager = new DialogueManager();
    public static DialogueManager Instance { get { return dialogueManager; } }

    void Awake()
    {
        dialogueRunner = FindObjectOfType<DialogueRunner>();
        dialogueRunner.AddCommandHandler("TestFunc", TestFunc);
        dialogueRunner.AddCommandHandler<string>("Test2Func", Test2Func);
    }

    void TestFunc()
    {

    }

    void Test2Func(string temp)
    {

    }
}
