using UnityEngine;

public class UIDirectionControl : MonoBehaviour {

    // This class is used to make sure world space UI
    // elements such as the health bar face the correct direction.
    public bool m_UseRelativeRotation = true; // Use relative rotation should be usedfor this gameObject ?
    private Quaternion m_RelativeRotation; // The local rotation at the start of the scene.

	// Use this for initialization
	void Start () {
        m_RelativeRotation = transform.parent.localRotation;
	}
	
	// Update is called once per frame
	void Update () {
        if (m_UseRelativeRotation)
            transform.rotation = m_RelativeRotation;
	}
}
