using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InTimerAction : MonoBehaviour
{
    [SerializeField]private ActionTimer _actiontimer;
    public ActionTimer actiontimer => _actiontimer;
    private bool hastimerElapsed=true;
    void Start()
    {
        actiontimer.SetTimer(1f, () => { Debug.Log("Time is Expired"); });
    }

    void Update()
    {
     
       
    }
}
