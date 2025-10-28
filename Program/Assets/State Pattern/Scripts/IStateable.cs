using UnityEngine;
using UnityEngine.TextCore.Text;

public interface IStateable
{
    public void Enter(Character character);

    public void Update(Character character);

    public void Exit(Character character);
}
