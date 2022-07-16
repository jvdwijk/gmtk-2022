using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayPhase : GamePhase
{
    [SerializeField]
    private DiceManager dice;

    public override void EnterPhase(GamePhaseStateMachine statemachine)
    {
        StartCoroutine(PlayActions(statemachine));
    }

    public override void LeavePhase(){}

    public override void UpdateState(GamePhaseStateMachine statemachine){}

    private IEnumerator PlayActions(GamePhaseStateMachine statemachine){
        yield return StartCoroutine(dice.PlayDiceActions());
        statemachine.SetState(GamePhaseType.THROW);//TODO might change to npc turn later
    }
}