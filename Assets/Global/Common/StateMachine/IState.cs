using System;
using System.Net.NetworkInformation;

public interface IState<TStateType, TContext>
where TStateType : Enum
where TContext : class
{
    public event Action<TStateType> ChangeState;
    public void Enter();
    public void Exit();
    public void Update();
    public void FixedUpdate();
}
