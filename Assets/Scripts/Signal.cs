using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Signal : MonoBehaviour
{
    [SerializeField] private UnityEvent _signal;
    [SerializeField] private UnityEvent _finishsignal;


    private void OnTriggerEnter2D()
    {
        _signal.Invoke();
    }

    private void OnTriggerExit2D()
    {
        _finishsignal.Invoke();
    }
}
