using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMover : MonoBehaviour
{
    [SerializeField] private string MoveSceneName;

    void Start()
    {
        
    }

   public void SceneMove()
   {
        Debug.Log("¾À ÀÌµ¿>>");
        SceneManager.LoadScene(MoveSceneName);
   }
}
