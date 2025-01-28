using UnityEngine;
using UnityEngine.InputSystem;

public class BreakOutScript : MonoBehaviour
{
    public InputActionReference action;
    public GameObject Player;
    public GameObject BreakOutPosition;

    private bool BrokeOut = false;
    private Vector3 OldPosition;

    void Start()
    {
        action.action.Enable();
    }

    
    void Update()
    {
        if (action.action.triggered && BrokeOut == false)
        {
            Vector3 OldPosition = Player.transform.position;
            BrokeOut = true;
            Player.transform.position = BreakOutPosition.transform.position;
        } 
        else if (action.action.triggered)
        {
            BrokeOut = false;
            Player.transform.position = OldPosition;
        }
    }
}
