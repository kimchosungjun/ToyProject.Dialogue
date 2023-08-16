using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static GameManager instance; static GameManager Instance { get { return instance; } }
    ResourceManager resource = new ResourceManager(); public static ResourceManager Resource { get { return Instance.resource; } }

    private void Awake()
    {
        if (instance == null)
        {
            GameObject gameManager = GameObject.Find("GameManager");
            if (gameManager == null)
            {
                gameManager = new GameObject { name = "GameManager" };
                gameManager.AddComponent<GameManager>();
            }
            instance = gameManager.GetComponent<GameManager>();
            DontDestroyOnLoad(gameManager);
        }
    }
}
