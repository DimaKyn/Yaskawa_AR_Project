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
    public AudioClip sfxLevelUp;
    [SerializeField] private TextMeshProUGUI LevelText;
    [SerializeField] private TextMeshProUGUI ExperienceText;
    [SerializeField] private int Level;
    public float CurrentXp;
    [SerializeField] private float TargetXp;
    [SerializeField] private Image xpProgressBar;

    [SerializeField] private float DelayBetweenXPGains = 0.1f; // Adjust delay as needed
    [SerializeField] private string scene;

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
            CurrentXp += 10;
            ExperienceText.text = CurrentXp + " / " + TargetXp;
            xpProgressBar.fillAmount = (CurrentXp / TargetXp);

            yield return new WaitForSeconds(DelayBetweenXPGains);

            if (CurrentXp == 100){
                ExperienceController(CurrentXp);
                break;
            }
        }
    }

    public void ExperienceController(float CurrentXp){
        soundEffectsSrc.clip = sfxLevelUp;
        soundEffectsSrc.Play();
        waitForIt(0.5f);
        if(CurrentXp >= TargetXp){
            CurrentXp = 0;
            Level++;
            LevelText.text = "Level : " + Level.ToString();
            xpProgressBar.fillAmount = 0;
            ExperienceText.text = CurrentXp + " / " + TargetXp;
        }
        waitForIt(0.7f);
        MoveToScene();
    }

    IEnumerator waitForIt(float delay){
        yield return new WaitForSeconds(delay);
    }

    public void MoveToScene(){
        SceneManager.LoadScene(scene);
    }
}