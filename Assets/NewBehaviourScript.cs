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
        yield return new WaitForSeconds(Random.Range(0.5f, 5.0f));
        GetComponent<Animator>().SetBool("isCanSwitchAnimToScale", true);
        GetComponent<Animator>().SetBool("isCanSwitchAnimToMove", false);
        yield return new WaitForSeconds(Random.Range(0.5f, 5.0f));
        GetComponent<Animator>().SetBool("isCanSwitchAnimToMove", true);
        GetComponent<Animator>().SetBool("isCanSwitchAnimToScale", false);
        canSwitchAnim = true; 
    }
}
