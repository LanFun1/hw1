using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
            transform.Translate(transform.right * _speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
            transform.Translate(transform.right * _speed * Time.deltaTime*-1);
    }
}
