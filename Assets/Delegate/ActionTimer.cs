using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class ActionTimer : MonoBehaviour
{
    private Action timerCallBack;


    private float timer;

    public void SetTimer(float timer,Action timerCallBack)
    {
        this.timer = timer;
        this.timerCallBack = timerCallBack;
    }

    void Update()
    {
        if (timer >= 0)
        {
            timer -= Time.deltaTime;

            if (IsTimerComplete())
            {
                timerCallBack();
            }
        }
    }
    public bool IsTimerComplete()
    {
        return timer <= 0;
    }
}
