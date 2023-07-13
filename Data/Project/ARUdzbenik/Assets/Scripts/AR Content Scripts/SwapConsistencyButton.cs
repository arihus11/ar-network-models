using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SwapConsistencyButton : MonoBehaviour
{
    [SerializeField]
    public GameObject WeakConsistencyModel, StrongConsistencyMode, ButtonTextObject;
    private bool swapModel = false; 

    private TextMeshProUGUI ButtonText;
    void Awake() 
    {
        ButtonText = ButtonTextObject.gameObject.transform.GetComponent<TextMeshProUGUI>();
        ButtonText.text = "SLABA KONZISTENTNOST";
        StrongConsistencyMode.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        switch (swapModel) {
            case false:
                WeakConsistencyModel.SetActive(true);
                StrongConsistencyMode.SetActive(false);
                ButtonText.text = "SLABA KONZISTENTNOST";
                break;
            case true:
                WeakConsistencyModel.SetActive(false);
                StrongConsistencyMode.SetActive(true);
                ButtonText.text = "JAKA KONZISTENTNOST";
                break; 
            default:
                break; 
        }
    }

    public void SwapButtonClicked() 
    {
        swapModel = !swapModel;
    }
}
