using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Signal : MonoBehaviour
{
    [SerializeField] private UnityEvent _thiefEnter;
    [SerializeField] private UnityEvent _thiefExit;

    private bool _courutineOpener = true;
    private bool _volumeChanger = true;
    private float _volume = 0.3f;

    private void Update()
    {
        if(_courutineOpener == true)
        {
            StartCoroutine(VolumeController());
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

    private IEnumerator VolumeController()
    {
        var waitforsec = new WaitForSeconds(0.2f);
        if (_volume <= 5f && _volumeChanger == true)
        {
            AudioListener.volume = _volume;
            _volume += 0.3f;
        }
        else
        {
            _volumeChanger = false;
        }
        if (_volume >= 0.4f && _volumeChanger == false)
        {
            AudioListener.volume = _volume;
            _volume -= 0.3f;
        }
        else
        {
            _volumeChanger = true;
        }
        yield return waitforsec;
        _courutineOpener = true;
    }
}
