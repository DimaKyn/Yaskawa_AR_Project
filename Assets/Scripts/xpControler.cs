using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

using TMPro;

public class xpControler : MonoBehaviour
{   
    public AudioSource soundEffectsSrc;
    public AudioClip sfx;
    [SerializeField] private TextMeshProUGUI LevelText;
    [SerializeField] private TextMeshProUGUI ExperienceText;
    [SerializeField] private int Level;
    public float CurrentXp;
    [SerializeField] private float TargetXp;
    [SerializeField] private Image xpProgressBar;

<<<<<<< Updated upstream
    [SerializeField] private float DelayBetweenXPGains = 0.05f; // Adjust delay as needed
=======
    [SerializeField] private float DelayBetweenXPGains; // Adjust delay as needed
>>>>>>> Stashed changes
    [SerializeField] private string scene;
    [SerializeField] private bool toMoveScene;

    public GameObject xpGainText;

    void Start(){
        xpProgressBar.fillAmount = (CurrentXp / TargetXp);
    }

    public void buttonPressed()
    {
        StartCoroutine(AddXPWithDelay());
    }

    IEnumerator AddXPWithDelay()
    {
        while (CurrentXp < 100)
        {
<<<<<<< Updated upstream
            CurrentXp += 25;
            ExperienceText.text = CurrentXp + " / " + TargetXp;
=======
            CurrentXp += 1;
            ExperienceText.text = CurrentXp + " / " + TargetXp + " XP";
>>>>>>> Stashed changes
            xpProgressBar.fillAmount = (CurrentXp / TargetXp);
            
            yield return new WaitForSeconds(DelayBetweenXPGains);

            if (CurrentXp == 100){
                ExperienceController(CurrentXp);
                break;
            }
        }
    }

    public void ExperienceController(float CurrentXp){
        soundEffectsSrc.clip = sfx;
        soundEffectsSrc.Play();
        waitForIt(0.5f);
        if(CurrentXp >= TargetXp){
            CurrentXp = 0;
            Level++;
            LevelText.text = "Level : " + Level.ToString();
            xpProgressBar.fillAmount = 0;
            ExperienceText.text = CurrentXp + " / " + TargetXp + " XP";
        }
        waitForIt(0.7f);

        if(toMoveScene){
            MoveToScene();
        }
    }

    IEnumerator waitForIt(float delay){
        yield return new WaitForSeconds(delay*Time.deltaTime);
    }

    public void MoveToScene(){
        SceneManager.LoadScene(scene);
    }

    
    public void OpenGainText(){
        if(xpGainText != null){
            bool isActive = xpGainText.activeSelf;
            xpGainText.SetActive(!isActive);
            Invoke ("CloseGainText", 2);
        }
    }
    public void CloseGainText(){
        if(xpGainText != null){
            bool isActive = xpGainText.activeSelf;
            xpGainText.SetActive(!isActive);

        }
    }
    public void playSfx(){
        soundEffectsSrc.clip = sfx;
        soundEffectsSrc.Play();
    }
}
