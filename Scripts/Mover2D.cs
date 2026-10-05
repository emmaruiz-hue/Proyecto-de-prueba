using UnityEngine;
using UnityEngine.InputSystem;

public class Mover2D : MonoBehaviour
{
    public float speed;
    void Start () 
    {
        
    }

    void Update () 
    {
        Vector3 direction = new Vector3(0, 0);

        if (Keyboard.current.wKey.isPressed) 
        {
            direction.y = 1;
        }
        if (Keyboard.current.aKey.isPressed)
        {
            direction.x = -1;
        }
        if (Keyboard.current.sKey.isPressed)
        {
            direction.y = -1;
        }
        if (Keyboard.current.dKey.isPressed)
        {
            direction.x = 1;
        }

        transform.position = transform.position + direction * speed;

        // Transform.position
        // 1st step: Read user input
        // 2nd step: generate a direction
        // 3rd step: apply the movement
    }

}
