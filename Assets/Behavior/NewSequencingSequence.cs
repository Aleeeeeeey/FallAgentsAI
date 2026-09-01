using System;
using Unity.Behavior;
using UnityEngine;
using Composite = Unity.Behavior.Composite;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "New Sequencing", story: "Execute Children Constantly", category: "Flow/Repeat", id: "8cc1d3b897345cf15a2e03f4e58db519")]
public partial class NewSequencingSequence : Composite
{

    protected override Status OnStart()
    {
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

