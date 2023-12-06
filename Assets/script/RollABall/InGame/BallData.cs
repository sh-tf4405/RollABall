using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallData : MonoBehaviour
{
    private Rigidbody ballRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        ballRigidBody = this.GetComponent<Rigidbody>();
        var ballData = new BallData(5);
        Debug.Log(ballData.GetHitPoint);//5
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private int hitPoint;
    public int GetHitPoint
    {
        get { return hitPoint; }
    }
    public int SetHitPoint
    {
        set { hitPoint = value; }
    }
    // BallDataのコンストラクタ
    public BallData(int hitPoint)
    {
        this.hitPoint = hitPoint;
    }

    public void BallMove(Vector3 direction)
    {
        ballRigidBody.AddForce(direction);
    }


}
