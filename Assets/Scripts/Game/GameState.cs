using System;
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public static GameState instance;
    public int fase_idx;

    const int QTD_FASES = 3;

    Action actPerder, actProxFase, actGanharJogo;

    CatshipControl catshipCtrl;

    void Awake() {
        instance = this;
        catshipCtrl = FindObjectOfType<CatshipControl>();
    }

    public void Setup(Action actionPerder, Action actionProxFase, Action actionGanharJogo) {
        actPerder = actionPerder;
        actProxFase = actionProxFase;
        actGanharJogo = actionGanharJogo;
    }

    public void Perder() {
        if (actPerder != null)
            actPerder.Invoke();
        Destroy(gameObject);
    }

    public void Ganhar() {
        if (fase_idx + 1 < QTD_FASES) {
            if (actProxFase != null)
                actProxFase.Invoke();
        } else {
            if (actGanharJogo != null)
                actGanharJogo.Invoke();
        }
        Destroy(gameObject);
    }

    public void GanharJogo() {
        if (actGanharJogo != null)
            actGanharJogo.Invoke();
    }

}
