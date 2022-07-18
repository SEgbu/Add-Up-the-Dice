using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    public AudioSource buttonNoise; 
    public void Play(){
        buttonNoise.Play();
        SceneManager.LoadScene("GameScene");
    }

    public void Options(){
        buttonNoise.Play();
        SceneManager.LoadScene("OptionScene");
    }

    public void Tutorial(){
        buttonNoise.Play();
        SceneManager.LoadScene("TutorialScene");
    }
    public void QuitButton(){
        buttonNoise.Play();
        Application.Quit();
    }
}
