using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Logic_script : MonoBehaviour
{
    public int right_player_score;
    public int left_player_score;
    public int points_to_win;

    public Text right_player_text;
    public Text left_player_text;
    public Text winner;

    public GameObject game_over_screen;
    public GameObject right_racket;
    public GameObject left_racket;
    public GameObject ball_finish;

    public ball_script ball;
    
    public void Start()
    {
        points_to_win = 5;
    }
    public void addScore(int player)
    {
        
        if (player == 1)
        {
            left_player_score += 1;
            left_player_text.text = left_player_score.ToString();
            if (left_player_score >= points_to_win)
            {
                
                win(1);
            }

            
        }
        if (player == 2)
        {

            right_player_score += 1;
            right_player_text.text = right_player_score.ToString();
            if (right_player_score >= points_to_win)
            {
                win(2);
            }

        }
        ball.Resetball();
    }

    public void win(int player)
    {
        if (player == 1)
        {
            winner.text = "right player wins";
        }
        if (player == 2)
        {
            winner.text = "left player wins";
        }
        game_over_screen.SetActive(true);
        right_racket.SetActive(false);
        left_racket.SetActive(false);
        ball_finish.SetActive(false);
        

    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}