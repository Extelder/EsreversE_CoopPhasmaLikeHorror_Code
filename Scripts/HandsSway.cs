using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class HandsSway : MonoBehaviour
{
    [SerializeField] private float rotateSpeed = 4f;
    [SerializeField] private float maxTurn = 3f;

    private CompositeDisposable _disposable = new CompositeDisposable();


    private void OnEnable()
    {
        Observable.EveryUpdate().Subscribe(_ =>
        {
            Vector2 mouseInput = new Vector2(-Input.GetAxis("Mouse X"), -Input.GetAxis("Mouse Y"));

            ApplyRotation(GetRotation(mouseInput));
        }).AddTo(_disposable);
    }

    private void OnDisable()
    {
        _disposable.Clear();
    }

    private Quaternion GetRotation(Vector2 mouse)
    {
        mouse = Vector2.ClampMagnitude(mouse, maxTurn);

        Quaternion rotX = Quaternion.AngleAxis(-mouse.y, Vector3.right);
        Quaternion rotY = Quaternion.AngleAxis(mouse.x, Vector3.up);

        Quaternion targetRot = rotX * rotY;

        return targetRot;
    }

    private void ApplyRotation(Quaternion targetRot)
    {
        transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRot, rotateSpeed * Time.deltaTime);
    }
}