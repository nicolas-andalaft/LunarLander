using System;
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public static GameState instance;
    public GameObject[] fases;

    int fase_i;
    Action actPerder, actGanharJogo;

    CatshipControl catshipCtrl;

    void Awake() {
        instance = this;
        catshipCtrl = FindObjectOfType<CatshipControl>();
    }

    void Start() {
        fase_i = -1;
        ProximaFase();
    }

    void ProximaFase() {
        if (fase_i >= 0)
            fases[fase_i].SetActive(false);
        ++fase_i;
        fases[fase_i].SetActive(true);
        catshipCtrl.transform.position = (
            GameObject.FindWithTag("StartPoint").GetComponent<Transform>().position
        );
    }

    public void Perder() {
        Debug.Log("Perder");
        if (actPerder != null)
            actPerder.Invoke();
    }

    public void Ganhar() {
        if (fase_i + 1 < fases.Length)
            ProximaFase();
        else
            GanharJogo();
    }

    public void GanharJogo() {
        Debug.Log("Ganhar Jogo");
        if (actGanharJogo != null)
            actGanharJogo.Invoke();
    }
}
