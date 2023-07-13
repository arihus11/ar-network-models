using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelect : MonoBehaviour
{
    private Renderer _renderer;
    [SerializeField]
    public GameObject SelectedFrame;
    [SerializeField]
    public GameObject[] SelectableObjects;
    private bool _previouslySelected = false;
    [SerializeField]
    public bool IsCorrectSelection;
    [SerializeField]
    public bool IsSelected = false;
    [SerializeField]
    public bool IsSelectable = true;
    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (IsSelected) {
            case false:
                SelectedFrame.SetActive(false);
                break;
            case true:
                SelectedFrame.SetActive(true);
                break;
            default:
                break;
        }
    }

    private void OnMouseDown() {
        if (IsSelectable) {
            _previouslySelected = !_previouslySelected;
            switch (_previouslySelected) {
                case true:
                    IsSelected = true;
                    foreach (GameObject obj in SelectableObjects)
                    {
                        obj.gameObject.GetComponent<ObjectSelect>().IsSelected = false;
                        if (IsCorrectSelection) {
                            obj.gameObject.GetComponent<ObjectSelect>().IsSelectable = false;
                        }
                    }
                    break;
                case false:
                    if (IsSelected && !IsCorrectSelection) {
                        IsSelected = false;    
                    }        
                    break;
                default: 
                    break;
            }
        }
    }

    public void ResetSelectedState() 
    {
        IsSelected = false;
        IsSelectable = true;
        _previouslySelected = false;
    }
}
