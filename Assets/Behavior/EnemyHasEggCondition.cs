using System;
using Unity.Behavior;
using UnityEngine;

[Serializable, Unity.Properties.GeneratePropertyBag]
[Condition(name: "Enemy Has Egg", story: "[Enemy] Has Egg", category: "Conditions", id: "1542d53803a3bc509327190728a8dc3f")]
public partial class EnemyHasEggCondition : Condition
{
    [SerializeReference] public BlackboardVariable<GameObject> Enemy;

    public override bool IsTrue()
    {
        return true;
    }

    public override void OnStart()
    {
    }

    public override void OnEnd()
    {
    }
}
