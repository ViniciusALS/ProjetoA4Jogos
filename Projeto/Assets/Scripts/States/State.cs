using UnityEngine;

public abstract class State
{
    public void Setup(){}

    public virtual void Enter(){}
    public virtual void Update(){}
    public virtual void FixedUpdate(){}
    public virtual void Exit(){}
}