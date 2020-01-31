using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputControls : MonoBehaviour, GeneralInput.IKeyboardInputActions
{
    private GeneralInput controls;
    public PlayerController playerController;

    void GeneralInput.IKeyboardInputActions.OnSpace(InputAction.CallbackContext context)
    {
        playerController.Fly(context.ReadValue<float>());//This is to call whatever function from the space button
    }

    void GeneralInput.IKeyboardInputActions.OnArrowKeys(InputAction.CallbackContext context)
    {
        playerController.Move(context.ReadValue<Vector2>()); //This is to call whatever function from the arrow keys (IE Moving the player)
    }
    void Awake()
    {
        Debug.Log("General Input Ready");
        controls = new GeneralInput();
        controls.KeyboardInput.SetCallbacks(this);
    }
    void OnEnable()
    {
        if(controls != null)
        {
            controls.KeyboardInput.Enable();
        }
    }
    void OnDisable()
    {
        if (controls != null)
        {
            controls.KeyboardInput.Disable();
        }
    }
}
