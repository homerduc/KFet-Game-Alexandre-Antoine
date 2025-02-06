using UnityEngine;

public class VendingButton : MonoBehaviour
{
    VendingMachine vendingMachine;

    // We have to set the value in the Unity editor for each button
    [SerializeField]
    private string buttonValue;

    // Search the parent VendingMachine at start
    void Start()
    {
        vendingMachine = GetComponentInParent<VendingMachine>();
        if (vendingMachine == null)
        {
            Debug.LogError("A VendingButton didn't find it's VendingMachine ON FAIT QUOI POUR LES ERREURS ?????? JSP");
        }
    }

    // The method to call when interacting with the button
    public void OnButtonPressed()
    {
        vendingMachine.HandleButtonPressed(buttonValue);
    }
}
