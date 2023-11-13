using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UIScript : MonoBehaviour
{
    [SerializeField]
    private GameState gameState;

    [SerializeField]
    private TextMeshProUGUI playerNameText;
    // Start is called before the first frame update
    void Start()
    {
        playerNameText.text = gameState.playerName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
