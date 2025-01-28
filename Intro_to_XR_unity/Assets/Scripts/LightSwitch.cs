using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
using static UnityEngine.XR.OpenXR.Features.Interactions.DPadInteraction;

public class LightSwitch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Light light;
    public InputActionReference action;
    public InputActionReference button;
    public float r;
    public float g;
    public float b;
    void Start()
    {
        //light = GetComponent<Light>();

        action.action.Enable();
        button.action.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if (button.action.triggered) 
        {
            {
                Vector2 tPadValue = action.action.ReadValue<Vector2>();

                float r, g, b;
                if (tPadValue.x > 0 && tPadValue.y < 0)
                {
                    r = 1f;
                    g = 0f;
                    b = 0f;
                }
                else if (tPadValue.x > 0 && tPadValue.y > 0)
                {
                    r = 0f;
                    g = 1f;
                    b = 0f;
                }
                else if (tPadValue.x < 0 && tPadValue.y > 0)
                {
                    r = 0f;
                    g = 0f;
                    b = 1f;
                }
                else
                {
                    r = 1f;
                    g = 1f;
                    b = 1f;
                }

                light.color = new Color(r, g, b, 1);
            }

        }
    }
}
