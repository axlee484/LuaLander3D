using System;

public interface IState<TStateType, TContext>
where TStateType : Enum
where TContext : class
{
    public event Action<TStateType> ChangeState;
    public TStateType StateId { get; }
    public TContext Context { get; }
    public void Enter();
    public void Exit();
    public void Update();
    public void FixedUpdate();
}
