using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bonecard : MonoBehaviour {
    public GameObject bonecardprefab;
    public GameObject bonecardStart;
    public GameObject bonecardEnd;
    public int num = 15;
    public float force = 4.0f;
    void Start () {
        Vector3 dir = bonecardEnd.transform.position - bonecardStart.transform.position;
        float interval = dir.magnitude / (num + 1);
        dir.Normalize();
        for (int i = 1; i <= num; i++) {
            GameObject newDom = (GameObject)Instantiate(bonecardprefab);
            newDom.transform.position = bonecardStart.transform.position + dir*interval*i;
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.G)) {
            bonecardStart.GetComponent<Rigidbody>().AddForce(force, 0, 0, ForceMode.Impulse);
        }
	}

}
