using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class GameCursor : MonoBehaviour
{

    private void Start()
    {
        Disable();
    }

    public void Enable()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void Disable()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}