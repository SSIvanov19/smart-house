using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
using Valve.VR;

public class Pointer : MonoBehaviour
{
    public float m_DefaultLength = 5.0f;
    public GameObject m_Dot;
    public SteamVR_Action_Boolean m_ClickAction;

    private LineRenderer m_LineRenderer = null;

    public Hand hand;
    GameObject attachedObject = null;



    private void Awake()
    {
        m_LineRenderer = GetComponent<LineRenderer>();
    }

    void Update()
    {
        UpdateLine();
        
    }

    private void UpdateLine()
    {
        float targetLength = m_DefaultLength;

        RaycastHit hit = CreateRaycast(targetLength);

        Vector3 endPosition = transform.position + (transform.forward * targetLength);

        if (hit.collider != null)
        {
            endPosition = hit.point;
        }

        if (hit.transform.tag == "Item")
        {
            m_Dot.SetActive(true);
            m_LineRenderer.enabled = true;

            Interactable interactable = hit.collider.gameObject.GetComponent<Interactable>();
            SteamVR_Input_Sources source = hand.handType;

            if (m_ClickAction.stateDown)
            {
                if (interactable != null)
                {
                    interactable.transform.LookAt(transform);
                    interactable.gameObject.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 500, ForceMode.Force);
                    attachedObject = interactable.gameObject;
                   
                    hand.AttachObject(attachedObject, GrabTypes.Pinch);
                    attachedObject = null;
                    
                    m_Dot.SetActive(false);
                    m_LineRenderer.enabled = false;
                }
            }
        }
        else if (hit.transform.tag != "Item")
        {
            m_Dot.SetActive(false);
            m_LineRenderer.enabled = false;
        }
        else 
        {
            m_Dot.SetActive(false);
            m_LineRenderer.enabled = false;
        }

        m_Dot.transform.position = endPosition;

        m_LineRenderer.SetPosition(0, transform.position);
        m_LineRenderer.SetPosition(1, endPosition);
    }

    private RaycastHit CreateRaycast(float length)
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);
        Physics.Raycast(ray, out hit, m_DefaultLength);

        return hit;
    }
}
