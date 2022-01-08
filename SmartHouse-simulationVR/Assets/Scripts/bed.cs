using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bed : MonoBehaviour
{
    public GameObject sleepPoint;
    public GameObject wakeUpPoint;
    public GameObject Player;
    public GameObject Camera;

    public Animator sleepAnimator;

    public DayNightCycle dayNightCycle;

    const float timePass = 0.3333333f;

    void OnMouseOver()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Player.transform.position = sleepPoint.transform.position;
            Player.transform.rotation = sleepPoint.transform.rotation;
            Camera.transform.rotation = new Quaternion(0, 180, 0, 0);

            Player.GetComponent<CharacterController>().enabled = false;
            Camera.GetComponent<MouseLook>().enabled = false;

            sleepAnimator.SetTrigger("Sleep");
            StartCoroutine(ExecuteAfterTime(5));
        }
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSecondsRealtime(time);
        Player.GetComponent<CharacterController>().enabled = true;
        Camera.GetComponent<MouseLook>().enabled = true;

        Player.transform.position = wakeUpPoint.transform.position;
        Player.transform.rotation = wakeUpPoint.transform.rotation;

        dayNightCycle.currentTimeOfDay += timePass;

    }

}
