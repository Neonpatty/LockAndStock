using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionController : MonoBehaviour
{
    [SerializeField] GameObject _target;
    [SerializeField] bool _show;

    private void OnMouseDown()
    {
        _target.SetActive(_show);
    }
}
