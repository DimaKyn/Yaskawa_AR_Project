using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using UnityEngine.UI;



public class mainControl : MonoBehaviour
{
    public AudioSource soundEffectsSrc;
    public AudioClip sfx;
    [SerializeField] private string scene;
    
    public void playSfx(){
        soundEffectsSrc.clip = sfx;
        soundEffectsSrc.Play();
        Invoke ("MoveToScene", 1);
        //MoveToScene();
    }
    
    

    public IEnumerator waitForIt(float delay){
        yield return new WaitForSeconds(delay);
    }

    public void MoveToScene(){
        SceneManager.LoadScene(scene);
    }
}