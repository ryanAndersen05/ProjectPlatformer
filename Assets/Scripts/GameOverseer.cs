﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Keeps track of important references in the game
/// </summary>
public class GameOverseer : MonoBehaviour {
    public enum GameState { GamePlaying, GamePaused }

    public PlayerController player;
    public GameState currentGameState { get; set; }


}
