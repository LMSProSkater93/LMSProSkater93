using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AgentInput : MonoBehaviour
{

    [field: SerializeField]
    public UnityEvent<Vector2> onMovementKeyPressed { get; set; }

    // Update is called once per frame
    private void Update()
    {
        GetMovementInput();
    }

    private void GetMovementInput()
    {
        onMovementKeyPressed?.Invoke(new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")));
    }
}
