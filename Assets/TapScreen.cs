using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TapScreen : MonoBehaviour
{
    public void start(){
        SceneManager.LoadScene("PlayScene");
    }
}
