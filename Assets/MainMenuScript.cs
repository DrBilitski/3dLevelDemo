using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuScript : MonoBehaviour
{
    [SerializeField]
    private GameState gameState;

    [SerializeField]
    private TextMeshProUGUI errMessageText;
    private string playerNameInput = "" ;
    

    public void StartGame()
    {

        if (string.IsNullOrEmpty(playerNameInput))
        {
            // error
            errMessageText.text = "Player name cannot be empty";
        }
        else
        {
            if (playerNameInput.Trim().Length == 0)
            {
                // error
                errMessageText.text = "Player name cannot be empty";
            }
            else
            {
                gameState.playerName = playerNameInput;
                SceneManager.LoadSceneAsync(1);
                //SceneManager.LoadSceneAsync("Scene1");

            }
            
        }
        

    }

    public void ReadPlayerInput(string s)
    {
        playerNameInput = s;
        Debug.Log("Player name is " + s);
    }

    public void Start()
    {
        errMessageText.text = "";
    }
    public void Update()
    {
        
    }
}
