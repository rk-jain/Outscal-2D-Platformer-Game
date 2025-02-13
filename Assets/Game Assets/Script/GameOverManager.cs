using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour {

    public void OnReplayButtonClick() {
        SceneManager.LoadScene(SceneTransitionManager.GetInstance().levelToReload);

        BGMPlayer.GetInstance().ButtonSound();
    }

    public void OnQuitButtonClick() {
        SceneManager.LoadScene(0);

        BGMPlayer.GetInstance().ButtonSound();
    }
}
