using System;
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public static GameState instance;
    public GameObject[] fases;
    Action actPerder;

    void Awake() {
        instance = this;
    }

    public void Perder() {
        Debug.Log("Perder");
        if (actPerder != null)
            actPerder.Invoke();
    }

    public void Ganhar() {
        Debug.Log("Ganhar");
    }

    public void GanharJogo() {
        Debug.Log("Ganhar Jogo");
    }
}
