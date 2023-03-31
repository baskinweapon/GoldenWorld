using System;
using UnityEngine;
using UnityEngine.AI;

public enum VillagerState {
    choosen,
    collectResources,
    build, 
    rest
}

public class VillagerAI : MonoBehaviour
{
    NavMeshAgent agent;
    private VillagerState state;

    private void OnEnable() {
        InputSystem.OnRightClick += MoveToward;
    }

    void Start() {
        agent = GetComponent<NavMeshAgent>();
    }

    private void MoveToward() {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out var hit)) {
            agent.SetDestination(hit.point);
        }
    }

    public void ChangeState(VillagerState _state) {
        if (Equals(state, _state)) return;
        state = _state;
        
        InputSystem.OnRightClick -= MoveToward;
        switch (state) {
            case VillagerState.choosen:
                InputSystem.OnRightClick += MoveToward;
                break;
            case VillagerState.collectResources:
                break;
            case VillagerState.build:
                break;
            case VillagerState.rest:
                break;
        }
    }
    
    private void Update() {
        
    }
}
