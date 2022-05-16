using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ABSTRACTION
public abstract class Shape : MonoBehaviour
{
    // ENCAPSULATION
    private Material shapeMaterial;
    public Material ShapeMaterial { get; private set; }
    // ENCAPSULATION
    private new readonly string name;
    public string Name { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        ShapeMaterial = GetComponent<Renderer>().material;
        Name = gameObject.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        PrintName();
    }

    protected virtual void PrintName()
    {
        Debug.Log(ShapeMaterial.name);
    }

}
