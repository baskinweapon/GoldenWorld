using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class InputSystem : Singleton<InputSystem> {
    private InputActions _actions;
    
    public static Action OnClick;
    public static Action OnRightClick;

    void Start() {
        _actions = new InputActions();
        _actions.Enable();
        
        _actions.UI.Click.performed += Click;
        _actions.UI.RightClick.performed += RightClick;
    }

    #region Callbacks
    
    private void Click(InputAction.CallbackContext ctx) {
        if (EventSystem.current.IsPointerOverGameObject()) return;
        Debug.Log("Click");
        OnClick?.Invoke();
    }

    private void RightClick(InputAction.CallbackContext ctx) {
        if (EventSystem.current.IsPointerOverGameObject()) return;
        Debug.Log("Right Click");
        OnRightClick?.Invoke();
    }

    #endregion

    private void OnDisable() {
        _actions.UI.Click.Disable();
        _actions.UI.RightClick.Disable();
    }
}
