using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapConsistencyButton : MonoBehaviour
{
    [SerializeField]
    public GameObject WeakConsistencyModel, StrongConsistencyMode;

    private bool _swapModel = false; 
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        switch (_swapModel) {
            case false:
                WeakConsistencyModel.SetActive(true);
                StrongConsistencyMode.SetActive(false);
                break;
            case true:
                WeakConsistencyModel.SetActive(false);
                StrongConsistencyMode.SetActive(true);
                break; 
            default:
                WeakConsistencyModel.SetActive(true);
                StrongConsistencyMode.SetActive(false);
                break; 
        }
    }

    public void SwapButtonClicked() 
    {
        _swapModel = !_swapModel;
    }
}
