using System;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class HLODVolume : MonoBehaviour
{

    [SerializeField]
    int m_Area;
    
    public Vector3 size { get { return transform.localScale; }} 
    Bounds m_Bounds;

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireCube(transform.position, transform.localScale);
    }

    public void GenerateHLOD()
    {
        Debug.Log("Generating HLOD");
    }
    
}
