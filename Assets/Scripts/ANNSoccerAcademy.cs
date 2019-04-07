using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAgents;

public class ANNSoccerAcademy : Academy
{
    public Brain brainGoalie;
    public Brain brainStriker;
    public Material redMaterial;
    public Material blueMaterial;
    public float spawnAreaMarginMultiplier;
    public float gravityMultiplier = 1;
    public bool randomizePlayersTeamForTraining = true;
    public int maxAgentSteps;
    public float agentRunSpeed;
    public float agentRotationSpeed;
    public float strikerPunish;
    public float strikerReward;
    public float goaliePunish;
    public float goalieReward;

    void Start()
    {
        Physics.gravity *= gravityMultiplier;
    }

    public override void AcademyReset()
    {
        //base.AcademyReset();
    }

    public override void AcademyStep()
    {
        //base.AcademyStep();
    }
}
