using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListTarget : MonoBehaviour
{
    public Transform[] targetTranforms;

    public List<Ball> balls;

    public void AddBall(Ball ball)
    {
        balls.Add(ball);
        Debug.Log(balls.IndexOf(ball));
        ball.gameObject.transform.position = targetTranforms[balls.IndexOf(ball)].position;
        
    }
}
