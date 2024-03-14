using UnityEngine;
using UnityEngine.InputSystem;
using EnhancedTouch = UnityEngine.InputSystem.EnhancedTouch;


public class TouchManager : MonoBehaviour
{

    private void Awake()
    {

    }

    private void onEnable()
    {
        EnhancedTouch.TouchSimulation.Enable();
        EnhancedTouch.EnhancedTouchSupport.Enable();
        EnhancedTouch.Touch.onFingerDown += FingerDown;
    }

    private void onDisable()
    {
        EnhancedTouch.TouchSimulation.Enable();
        EnhancedTouch.EnhancedTouchSupport.Enable();
        EnhancedTouch.Touch.onFingerDown -= FingerDown;
    }

    private void TouchPressed(InputAction.CallbackContext context)
    {
        Debug.Log("Touch Pressed");
    }

    private void FingerDown(EnhancedTouch.Finger finger)
    {
        Debug.Log("Finger Down");

        if (finger.index != 0) return;


    }
    

}
