using UnityEngine;
using System.Collections;

public class PoolObject : MonoBehaviour {

	//generic 
	public virtual void OnObjectReuse() {

	}

	protected void Destroy() {
		gameObject.SetActive (false);
	}
}
