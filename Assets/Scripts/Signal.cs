using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Signal : MonoBehaviour
{
    [SerializeField] private UnityEvent _thiefEnter;
    [SerializeField] private UnityEvent _thiefExit;

    private bool _courutineOpener = true;
    private bool _corutineChanger = true;
    private float _volume = 0.3f;
    private void Update()
    {
        if(_courutineOpener == true && _corutineChanger == true)
        {
            StopCoroutine(VolumeControllerMinus());
            StartCoroutine(VolumeControllerPlus());
        }
        if (_courutineOpener == true && _corutineChanger == false)
        {
            StopCoroutine(VolumeControllerPlus());
            StartCoroutine(VolumeControllerMinus());
        }            
        _courutineOpener = false;
    }
    private void OnTriggerEnter2D()
    {
        _thiefEnter.Invoke();
    }

    private void OnTriggerExit2D()
    {
        _thiefExit.Invoke();
    }
    private IEnumerator VolumeControllerPlus()
    {
        var waitforsec = new WaitForSeconds(0.2f);
        if (_volume <= 5f)
        {
            AudioListener.volume = _volume;
            _volume += 0.3f;
        }
        else
            _corutineChanger = false;
        yield return waitforsec;
        _courutineOpener = true;
    }
    private IEnumerator VolumeControllerMinus()
    {
        var waitforsec = new WaitForSeconds(0.2f);
        if (_volume >= 0.4f)
        {
            AudioListener.volume = _volume;
            _volume -= 0.3f;
        }
        else
            _corutineChanger = true;
        yield return waitforsec;
        _courutineOpener = true;
    }
}
