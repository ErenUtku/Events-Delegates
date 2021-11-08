using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TestingEvenSubscriber : MonoBehaviour
{
    void Start()
    {
        TestingEvents testingEventSubscriber = GetComponent<TestingEvents>();
        testingEventSubscriber.OnSpacePressed += TestingEventSubscriber_OnSpacePressed;
        testingEventSubscriber.onFloatEvent += TestingEventSubscriber_onFloatEvent;
        testingEventSubscriber.OnActionEvent += TestingEventSubscriber_OnActionEvent;
    }

    private void TestingEventSubscriber_OnActionEvent(bool arg1, int arg2)
    {
        Debug.Log("arg =  " + arg1 + "  int=  " + arg2);
    }

    private void TestingEventSubscriber_onFloatEvent(float f)
    {
        Debug.Log("Float : " +f);
    }

    private void TestingEventSubscriber_OnSpacePressed(object sender, TestingEvents.OnSpacePressedEventArg e)
    {
        Debug.Log("Space!  =  " +   e.spaceCount );    
    }

    public void TestingUnityEvent()
    {
        Debug.Log("I AM UNITY EVENT FUNCTION");
    }
}
