using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;
public class TestingEvents : MonoBehaviour
{

    public event EventHandler<OnSpacePressedEventArg> OnSpacePressed;

    public class OnSpacePressedEventArg : EventArgs
    {
        public int spaceCount;
    }


    public event TestEventDelegate onFloatEvent;

    public delegate void TestEventDelegate(float f);

    public event Action<bool, int> OnActionEvent;

    public UnityEvent onUnityEvent;

    private int spaceCount;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spaceCount++;
            OnSpacePressed?.Invoke(this, new OnSpacePressedEventArg { spaceCount= spaceCount });
            onFloatEvent?.Invoke(5.3f);
            OnActionEvent?.Invoke(true, 5);
            onUnityEvent?.Invoke();
        }
    }
}
