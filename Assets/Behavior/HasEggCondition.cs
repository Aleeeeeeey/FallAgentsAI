using System;
using Unity.Behavior;
using UnityEngine;

[Serializable, Unity.Properties.GeneratePropertyBag]
[Condition(name: "Has Egg", story: "[Agent] Has Egg", category: "Conditions", id: "496ce6352c5bd9c44685c3362745a7bf")]
public partial class HasEggCondition : Condition
{
    [SerializeReference] public BlackboardVariable<GameObject> Agent;

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
