using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    public GameObject coub;
    private bool canSwitchAnim = true;

	void Start () {
        
	}
	
	void Update () {
        if (canSwitchAnim) 
        {
            canSwitchAnim = false;
            StartCoroutine(AnimDelay());

        }
    }

    IEnumerator AnimDelay()
    {
        if (GetComponent<Animator>().GetInteger("changeAnim") < 3)
        {
            yield return new WaitForSeconds(Random.Range(0.5f, 5.0f));
            GetComponent<Animator>().SetInteger("changeAnim", GetComponent<Animator>().GetInteger("changeAnim") + 1);
            Debug.Log(GetComponent<Animator>().GetInteger("changeAnim"));
            canSwitchAnim = true;

        }
        else
        {
            GetComponent<Animator>().SetInteger("changeAnim", 0);
            canSwitchAnim = true;
        }
    }
}
