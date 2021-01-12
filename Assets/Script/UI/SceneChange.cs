using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChange : MonoBehaviour
{
    public void SceneMapLevel()
    {
        SceneManager.LoadScene("MapLevel"); //새로운 레벨을 로드합니다.
    }

    public void SceneChooseStage()
    {
        SceneManager.LoadScene("ChoosStage"); //새로운 레벨을 로드합니다.
    }
}
