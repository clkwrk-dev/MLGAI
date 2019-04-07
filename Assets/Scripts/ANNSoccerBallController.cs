using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ANNSoccerBallController : MonoBehaviour
{

    [HideInInspector]
    public ANNSoccerFieldArea area;
    public AgentSoccer lastTouchedBy; //who was the last to touch the ball
    public string agentTag; //will be used to check if collided with a agent
    public string redGoalTag; //will be used to check if collided with red goal
    public string blueGoalTag; //will be used to check if collided with blue goal
    public string wallTag; //will be used to check if collided with blue goal

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        //Debug.Log("Ball hit.");
        if (col.gameObject.CompareTag(redGoalTag)) //ball touched orange goal
        {
            area.GoalTouched(AgentSoccer.Team.blue);
        }
        if (col.gameObject.CompareTag(blueGoalTag)) //ball touched sky blue goal
        {
            area.GoalTouched(AgentSoccer.Team.red);
        }
        if (col.gameObject.CompareTag(wallTag))
        {
            Debug.Log("Wall touched.");
            area.WallTouched();
        }
    }
}
