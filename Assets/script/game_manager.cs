using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class game_manager : MonoBehaviour
{
    public int score;
    public Text scoretext;
    public Text highscore;
    public float hiz;
    public GameObject pausebutton;
    public GameObject resumebutton;
    public GameObject ekrankapatma;
    public bool kontrol;
    void Start()
    {
        Time.timeScale = 1;
        score = 0;
        scoretext.text = score.ToString();
        

        highscore.text = PlayerPrefs.GetInt("highscore",0).ToString();
        if (PlayerPrefs.GetInt("kontrol")==1)
        {
            kontrol = true;
        }
         else if (PlayerPrefs.GetInt("kontrol") == 0)
        {
            kontrol = false;
        }
    } 
    
   public void updatescore()
    {

        score++;
        scoretext.text = score.ToString();
        speedkontrol();
        highscorekontrol();


    }
    public void speedkontrol()
    {
       
       
        if (score >= 85)
        {
            Time.timeScale = 3f;
        }
        else if (score >= 80)
        {
            Time.timeScale = 2.9f;
        }
        else if (score >= 75)
        {
            Time.timeScale = 2.8f;
        }
        else if (score >= 70)
        {
            Time.timeScale = 2.7f;
        }
        else if (score >= 65)
        {
            Time.timeScale = 2.6f;
        }
        else if (score >= 60)
        {
            Time.timeScale = 2.5f;
        }
        else if (score >= 55)
        {
            Time.timeScale = 2.4f;
        }
        else if (score>=50)
        {
            Time.timeScale = 2.3f;
        }
        else if (score >= 45)
        {
            Time.timeScale = 2.2f;
        }
        else if (score >= 40)
        {
            Time.timeScale = 2.1f;
        }
        else if (score >= 35)
        {
            Time.timeScale = 2.0f;
        }
        else if (score >= 30)
        {
            Time.timeScale = 1.9f;
        }
        else if (score >= 25)
        {
            Time.timeScale = 1.8f;
        }
        else if (score >= 20)
        {
            Time.timeScale = 1.7f;
        }
        else if (score >= 15)
        {
            Time.timeScale = 1.6f;
        }
        else if (score >= 10)
        {
            Time.timeScale = 1.4f;
        }
        else if (score >= 5)
        {
            Time.timeScale = 1.2f;
        }
      
        else
        {
            Time.timeScale = 1f;
        }

    }
    public void restartgame()
    {
        SceneManager.LoadScene(1);
    }
    public void highscorekontrol()
    {

        if (score>PlayerPrefs.GetInt("highscore",0))
        {
            PlayerPrefs.SetInt("highscore",score);
            highscore.text = score.ToString();
        }



    }
    public void pausegame()
    {
        hiz = Time.timeScale;
        Time.timeScale = 0f;
      
            
        pausebutton.SetActive(false);
        resumebutton.SetActive(true);
        ekrankapatma.SetActive(true);


    }
    public void resume()
    {
       
        Time.timeScale = hiz;

        
        pausebutton.SetActive(true);
        resumebutton.SetActive(false);
        ekrankapatma.SetActive(false);
        


    }
    public void mute()
    {
        kontrol = !kontrol;
        AudioListener.pause = kontrol;
        PlayerPrefs.SetInt("kontrol",kontrol ? 1:0);
    }
  
}
