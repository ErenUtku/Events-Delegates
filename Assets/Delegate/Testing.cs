using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Testing : MonoBehaviour
{
    public delegate void TestDelegate();
    public delegate bool TestBoolDelegate(int i);

    private TestDelegate testDelegateFunction;
    private TestBoolDelegate testBoolDelegate;

    public Action testAction;
    private Action<int, float> testIntFloatAction;
    private Func<bool> testFunc;
    private Func<int, bool> testIntBoolFunc;
    private void Start()
    {
        //testDelegateFunction += MytestDelegateFunction;
        //testDelegateFunction += MySecondtestDelegateFunction;    
        

        //testDelegateFunction = delegate () { Debug.Log("Annon"); };
        testDelegateFunction = () => { Debug.Log("I am delegate COPY"); };
        testDelegateFunction();
        testDelegateFunction = () => { Debug.Log("My Second Delegate COPY"); };
        testDelegateFunction();
        testDelegateFunction = () => { Debug.Log("Annon COPY"); };
        testDelegateFunction();
        testIntFloatAction = (int i, float f) => Debug.Log("INT value is : " + i + " ,float value is :" + f);
        testIntFloatAction(8, 4.5f);
        testFunc = () => false;
        Debug.Log(testFunc());
        testIntBoolFunc = (int i) => { return i > 8; };
        Debug.Log(testIntBoolFunc(9));
        

        //testBoolDelegate = (int i) => { return i <= 5; };
        testBoolDelegate = (int i) => i <= 5;
        Debug.Log(testBoolDelegate(6));
        Debug.Log(testBoolDelegate(4));
        //testBoolDelegate = MyBoolTestDelegate;
        
        


    }
    #region LONG
    /*private void MytestDelegateFunction()
    {
        Debug.Log("I am delegate");
    }
    private void MySecondtestDelegateFunction()
    {
        Debug.Log("My Second Delegate");
    }
    private bool MyBoolTestDelegate(int a)
    {
        return a < 5;
    }*/
    #endregion
}
