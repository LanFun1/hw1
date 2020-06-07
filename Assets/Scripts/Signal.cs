using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Signal : MonoBehaviour
{
    [SerializeField] private UnityEvent _thiefEnter;
    [SerializeField] private UnityEvent _thiefExit;


    private void OnTriggerEnter2D()
    {
        _thiefEnter.Invoke();
    }

    private void OnTriggerExit2D()
    {
        _thiefExit.Invoke();
    }
}
