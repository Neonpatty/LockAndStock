using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerUIList : MonoBehaviour


{
    [SerializeField] GameObject _target;
    [SerializeField] bool _show;
    void OnTriggerEnter(Collider other)
    {
      _target.SetActive(_show);
    }
}