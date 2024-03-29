using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    private Camera _mainCamera;

    private void Awake() {
        _mainCamera = Camera.main;
    }

    public void OnClick(InputAction.CallbackContext context) {
        
    }

}
