using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Assign Enemy", story: "[Agent] checks [object] tag for [enemy]", category: "Action", id: "786fb3f9e0420b1bcf058621e5bf036c")]
public partial class AssignEnemyAction : Action
{
    [SerializeReference] public BlackboardVariable<GameObject> Agent;
    [SerializeReference] public BlackboardVariable<GameObject> Object;
    [SerializeReference] public BlackboardVariable<GameObject> Enemy;

    protected override Status OnStart()
    {
        switch (Agent.Value.tag)
        {
            case "Yellow":
                if (Object.Value.tag == "Red")
                {
                    Enemy.Value = Object.Value;
                    break;
                }
                else if (Object.Value.tag == "Blue")
                {
                    Enemy.Value = Object.Value;
                    break;
                }
                break;

            case "Red":

                if (Object.Value.tag == "Yellow")
                {
                    Enemy.Value = Object.Value;
                    break;
                }
                else if (Object.Value.tag == "Blue")
                {
                    Enemy.Value = Object.Value;
                    break;
                }
                break;

            case "Blue":

                if (Object.Value.tag == "Red")
                {
                    Enemy.Value = Object.Value;
                    break;
                }
                else if (Object.Value.tag == "Yellow")
                {
                    Enemy.Value = Object.Value;
                    break;
                }
                break;
        }

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

