using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitPhase : GamePhase
{
    [SerializeField, Header("Dependencies")]
    private PlayerMovement playerMovement;
    [SerializeField, Header("Settings")]
    private Vector2Int startPosition;

    public override void EnterPhase(GamePhaseStateMachine statemachine) {
        playerMovement.SetInstantLocation(startPosition);
        //TODO fly camera over level
        statemachine.SetState(GamePhaseType.STARTROUND);
    }
    public override void LeavePhase(){}

    public override void UpdateState(GamePhaseStateMachine statemachine)
    {
    }
}
