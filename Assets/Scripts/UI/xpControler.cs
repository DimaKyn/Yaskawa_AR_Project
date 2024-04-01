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

    [SerializeField] private float DelayBetweenXPGains; // Adjust delay as needed

    [SerializeField] private string scene;
    [SerializeField] private bool toMoveScene;

    public GameObject xpGainText, endBtn;

    void Start(){
            xpProgressBar.fillAmount = (CurrentXp / TargetXp);
    }

    public void buttonPressed()
    {
        if(Level < 3){
            StartCoroutine(AddXPWithDelay());
        }
    }

    IEnumerator AddXPWithDelay()
    {
        while (CurrentXp < 100)
        {
            CurrentXp += 2;
            ExperienceText.text = CurrentXp + " / " + TargetXp + " XP";
            xpProgressBar.fillAmount = (CurrentXp / TargetXp);
            
            yield return new WaitForSeconds(DelayBetweenXPGains*Time.deltaTime);

            if (CurrentXp == 100){
                ExperienceController();
                break;
            }
        }
    }

    public void ExperienceController(){
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
        if(Level >= 3){
            return;
        }
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

    public void MachineOperations(){
        if(CurrentXp < 100 && Level == 3){
            CurrentXp += 34;
            ExperienceText.text = CurrentXp + " / " + TargetXp + " XP";
            xpProgressBar.fillAmount = (CurrentXp / TargetXp);
        }
        if(CurrentXp > 100 && Level == 3){
            MaxLevel();
        }
    }
    public void MaxLevel(){
        LevelText.text = "Max Level";
        xpProgressBar.fillAmount = 0;
        ExperienceText.text = "All Missions Complete!";
        unhideEndBtn();
    }

    public void unhideEndBtn(){
        if(endBtn != null){
            bool isActive = endBtn.activeSelf;

            endBtn.SetActive(!isActive);
        }
    }
}
