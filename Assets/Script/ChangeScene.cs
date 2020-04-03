using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    void OnCollisionEnter(Collision MoveToS2)
    {
        if (MoveToS2.gameObject.name == "Ball(Player)") ;
        {
            SceneManager.LoadScene("Scene2");
        }
    }
}
