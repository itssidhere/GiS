using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private TouchControls touchControls;

    private void Awake()
    {
        touchControls = new TouchControls();

    }
    private void onEnable()
    {
        touchControls.Enable();

    }
    private void OnDisable()
    {
        touchControls.Disable();
    }

    private void Start()
    {
        touchControls.Touch.TouchPress.started += ctx => StartTouch(ctx);
        touchControls.Touch.TouchPress.canceled += ctx => EndTouch(ctx);
    }
    private void StartTouch(InputAction.CallbackContext context){
        Debug.Log(" Touch started " + touchControls.Touch.TouchPosition.ReadValue<Vector2>());
    }

    private void EndTouch(InputAction.CallbackContext context)
    {

    }
}
