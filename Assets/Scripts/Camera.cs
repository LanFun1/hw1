using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private GameObject Player;

    private Vector3 offset;

    private void Start()
    {
        offset = transform.position + Player.transform.position;
    }

    private void Update()
    {
        transform.position = Player.transform.position + (offset / 10);
    }
}
