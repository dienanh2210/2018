using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace Com.MyCompany.MyGame
{
    public class GameControler : MonoBehaviour
    {
          public GameObject canvasRestart;
        public GameObject panel;
        public GameObject pannelrestart;
         public GameObject Win;
         public GameObject Lose;
        public GameObject pause;
        public GameObject pauseol;
        [Header("Canvas")]
        public GameObject CanvasGame;
        public GameObject restartOL;
        public GameObject restart;
        public AudioClip win;
        public AudioClip lose;
        public AudioClip sudioselect;
        public bool checkButton=true;
        
        public bool checkall=true;
        // public GameObject downIntance;
        // public GameObject puckRefabs;
        public enum Score
        {
            AiScore, PlayerScore
        }
        public Text AiScoreTxt, PlayerScoreTxt;
        public int MaxScore;
        #region Scores
        private int aiScore, playerScore;
        void Start()
        {
            Screen.orientation = ScreenOrientation.Portrait;
            canvasRestart.SetActive(false);
            // Instantiate(puckRefabs,downIntance.transform.position,Quaternion.identity);
            SG_AdManager.ads.RequestBanner();
            SG_AdManager.ads.ShowBanner();
        }

       private void OnApplicationFocus(bool focus)
        {
            if (focus)
            {
                SG_AdManager.ads.RequestIntertitial();
                SG_AdManager.ads.ShowIntertitial();
                StartCoroutine(setBanner());
            }
           

        }
        private IEnumerator setBanner() {
            yield return new WaitForSeconds(1f);
            SG_AdManager.ads.RequestBanner();
            SG_AdManager.ads.ShowBanner();
        }
        private int AiScore
        {
            get { return aiScore; }
            set
            {
                aiScore = value;
                if (checkall)
                {
                    if (checkButton)
                    {
                        if (value == MaxScore)
                        {
                            Invoke("aiWin", 1f);
                           // ShowIntertitial();
                           
                        }
                    }
                    else
                    {
                        if (value == MaxScore)
                        {
                            Invoke("aiWinOL", 1f);
                           // ShowIntertitial();
                           
                        }
                    }
                }
               else {
                    if (value == MaxScore)
                    {
                        Invoke("playervsPlayerWin", 1f);
                      //  ShowIntertitial();
                       
                    }
                }
            }
        }
        void ShowIntertitial()
        {
           SG_AdManager.HideAdmobBanner();
            SG_AdManager.ads.RequestIntertitial();
            SG_AdManager.ads.ShowIntertitial();
        }

        void aiWin() {
            Debug.Log("Ai win");
            // uiManager.ShowRestartCanvas(true);
            // Time.timeScale = 0;
            canvasRestart.SetActive(true);
            pannelrestart.SetActive(false);
            panel.SetActive(true);
            Lose.SetActive(true);
            Win.SetActive(false);
            Invoke("slowly", 0.5f);
            restart.SetActive(true);
            restartOL.SetActive(false);
            GetComponent<AudioSource>().PlayOneShot(lose);
            SG_AdManager.ads.RequestBanner();
            SG_AdManager.ads.ShowBanner();
        }
        void aiWinOL() {

            canvasRestart.SetActive(true);
            pannelrestart.SetActive(false);
            panel.SetActive(true);
            Lose.SetActive(true);
            Win.SetActive(false);
            restart.SetActive(false);
            restartOL.SetActive(true);
            Invoke("slowly", 0.5f);
            GetComponent<AudioSource>().PlayOneShot(lose);
            SG_AdManager.ads.RequestBanner();
            SG_AdManager.ads.ShowBanner();
        }
        void playervsPlayerWin() {
            canvasRestart.SetActive(true);
            Lose.SetActive(false);
            Win.SetActive(true);
            //  pannelrestart.GetComponent<Rigidbody2D>().transform.Rotate(0, 0, 180f);
            pannelrestart.SetActive(true);
            panel.SetActive(false);
            restart.SetActive(true);
            restartOL.SetActive(false);
            Invoke("slowly", 0.5f);

            GetComponent<AudioSource>().PlayOneShot(win);
            Debug.Log("180");
            SG_AdManager.ads.RequestBanner();
            SG_AdManager.ads.ShowBanner();
        }
        void playerWin() {

            //  uiManager.ShowRestartCanvas(false);
            // Time.timeScale = 0;
            canvasRestart.SetActive(true);
            pannelrestart.SetActive(false);
            panel.SetActive(true);
            Lose.SetActive(false);
            Win.SetActive(true);
            Invoke("slowly", 0.5f);
            particel.SetActive(true);
            restart.SetActive(true);
            restartOL.SetActive(false);
            GetComponent<AudioSource>().PlayOneShot(win);
            SG_AdManager.ads.RequestBanner();
            SG_AdManager.ads.ShowBanner();
        }
        public void slowly()
        {
            Time.timeScale = 0;
        }
        public GameObject particel;
        private int PlayerScore
        {
            get { return playerScore; }
            set
            {
                playerScore = value;
                if (checkall)
                {
                    if (checkButton)
                    {
                        if (value == MaxScore)
                        {

                            Invoke("playerWin", 1f);
                          //  ShowIntertitial();
                          
                        }
                    }
                    else
                    {
                        if (value == MaxScore)
                        {

                            Invoke("player2Win", 1f);
                          //  ShowIntertitial();
                         

                        }
                    }
                }else               
                {
                    if (value == MaxScore)
                    {
                        Invoke("player2OLwin", 1f);
                       // ShowIntertitial();
                        
                    }
                }
            }
        }
        void player2Win()
        {
            canvasRestart.SetActive(true);
            pannelrestart.SetActive(false);
            panel.SetActive(true);
            Lose.SetActive(false);
            Win.SetActive(true);

            Invoke("slowly", 0.5f);
            particel.SetActive(true);
            restart.SetActive(false);
            restartOL.SetActive(true);
            GetComponent<AudioSource>().PlayOneShot(win);

            SG_AdManager.ads.RequestBanner();
            SG_AdManager.ads.ShowBanner();
        }
        void player2OLwin() {

            canvasRestart.SetActive(true);
            // pannelrestart.GetComponent<Rigidbody2D>().transform.Rotate(0, 0,0);
            pannelrestart.SetActive(false);
            panel.SetActive(true);
            Lose.SetActive(false);
            Win.SetActive(true);
            Invoke("slowly", 0.5f);
            particel.SetActive(true);
            restart.SetActive(true);
            restartOL.SetActive(false);
            GetComponent<AudioSource>().PlayOneShot(win);
            Debug.Log("0");
            SG_AdManager.ads.RequestBanner();
            SG_AdManager.ads.ShowBanner();
        }
        #endregion

        public void Increment(Score whichScore)
        {
            if (whichScore == Score.AiScore)
            {
                AiScoreTxt.text = (++AiScore).ToString();

            }

            else
            {
                PlayerScoreTxt.text = (++PlayerScore).ToString();
            }
        }
       
        public void paused (){
            GetComponent<AudioSource>().PlayOneShot(sudioselect);
            pause.SetActive(true);
            Time.timeScale = 0;

        }
        public void pausedol()
        {
            GetComponent<AudioSource>().PlayOneShot(sudioselect);
            pauseol.SetActive(true);
            Time.timeScale = 0;

        }
        public GameObject playerrestart;
        public GameObject Ai;
        public GameObject playerBlue;



        public void RestartGame()
        {
           
           // SceneManager.LoadScene("PlayBox");
             CanvasGame.SetActive(true);
            canvasRestart.SetActive(false);
            ResetScores();
            ShowIntertitial();
        }
        public void RestartGame2()
        {

            // SceneManager.LoadScene("PlayBox");
            CanvasGame.SetActive(true);
            canvasRestart.SetActive(false);
            ResetScores();
           // ShowIntertitial();
        }
        public void setShowIntertitialOL() {

            ShowIntertitial();

        }
        public void ResetScores()
        {
            Time.timeScale = 1;
            AiScore = PlayerScore = 0;
            AiScoreTxt.text = PlayerScoreTxt.text = "0";
            playerrestart.GetComponent<Rigidbody2D>().transform.position = new Vector2(0, -3f);
            Ai.GetComponent<Rigidbody2D>().transform.position = new Vector2(0, 4f);
            playerBlue.GetComponent<Rigidbody2D>().transform.position = new Vector2(0, 4f);

        }
    }
}
