using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    private State currentState;
    public void SwitchState(State newstate)
    {
        currentState?.Exit();
        currentState = newstate;
        currentState?.Enter();
    }
    private void Update()
    {
        currentState?.Tick(Time.deltaTime);
    }
}
