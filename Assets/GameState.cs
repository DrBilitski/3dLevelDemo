using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="gameState", menuName ="State/Player/GameState")]
public class GameState : ScriptableObject
{
    public string playerName { get; set; }
     
}
