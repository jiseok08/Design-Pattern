using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    [SerializeField] Text timeText;

    [SerializeField] float time;

    [SerializeField] int minute;
    [SerializeField] int second;
    [SerializeField] int microsecond;

    [SerializeField] bool state = true;

    private void OnEnable()
    {
        EventManager.Subscribe(Condition.START, Excute);
        EventManager.Subscribe(Condition.PAUSE, Pause);
        EventManager.Subscribe(Condition.FINISH, Exit);
    }

    void Excute()
    {
        StartCoroutine(Measure());
    }

    private void Pause()
    {
        state = false;
    }

    public IEnumerator Measure()
    { 
        while (state)
        {
            if(time <= 0)
            {
                EventManager.Pubish(Condition.FINISH);

                yield break;
            }

            time -= Time.deltaTime;

            minute = (int)time / 60;
            second = (int)time % 60;
            microsecond = (int)(time * 100) % 100;

            timeText.text = string.Format("{0:D2} : {1:D2} : {2:D2}", minute, second, microsecond);
            
            yield return null;
        }
    }

    void Exit()
    {
        timeText.text = "GAME OVER";
    }

    private void OnDisable()
    {
        EventManager.Unsubscribe(Condition.START, Excute);
        EventManager.Unsubscribe(Condition.PAUSE, Pause);
        EventManager.Unsubscribe(Condition.FINISH, Exit);
    }
}
