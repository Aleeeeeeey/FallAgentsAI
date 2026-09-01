using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Hit Enemy", story: "[Enemy] gets [BeenHit]", category: "Action", id: "c126fe847f1d9d67ff652360e6da73df")]
public partial class HitEnemyAction : Action
{
    [SerializeReference] public BlackboardVariable<GameObject> Enemy;
    [SerializeReference] public BlackboardVariable<bool> BeenHit;

    protected override Status OnStart()
    {
        BehaviorGraphAgent enemyAgent = Enemy.Value.GetComponent<BehaviorGraphAgent>();
        enemyAgent.BlackboardReference.SetVariableValue<bool>("BeenHit", true);
        return Status.Running;
    }

    protected override Status OnUpdate()
    {
        return Status.Success;
    }

    protected override void OnEnd()
    {
    }
}

