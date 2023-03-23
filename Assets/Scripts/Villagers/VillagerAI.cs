using UnityEngine;
using UnityEngine.AI;

public class VillagerAI : MonoBehaviour
{
    NavMeshAgent agent;

    private void OnEnable() {
        InputSystem.OnRightClick += MoveToward;
    }

    void Start() {
        agent = GetComponent<NavMeshAgent>();
    }

    private void MoveToward() {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // Если луч попал в землю, то передвигаем игрока к точке
        if (Physics.Raycast(ray, out hit))
        {
            agent.SetDestination(hit.point);
        }
    }
}
