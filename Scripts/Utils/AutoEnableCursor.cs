using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoEnableCursor : MonoBehaviour
{
    private void Start()
    {
        Cursor.visible = transform;
        Cursor.lockState = CursorLockMode.None;
    }
}