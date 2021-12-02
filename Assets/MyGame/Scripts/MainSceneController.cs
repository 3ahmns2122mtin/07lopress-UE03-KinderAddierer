using UnityEngine;
using UnityEngine.UI;

public class MainSceneController : MonoBehaviour
{
    [SerializeField] private InputField inputFieldTermA, inputFieldTermB;
    [SerializeField] private Text txtResult;
    public bool testing;

    public int CheckAddition(int summandA, int summandB)
    {
        int result = 0;
        testing = false;

        result = summandA + summandB;

        return result;
    }

    void Start()
    {
        int val1 = CheckAddition(1,2);
        int val2 = CheckAddition(10,20);
        int val3 = CheckAddition(100,200);
    }

    public void GetValues()
    {
        string termA, termB;
        termA = inputFieldTermA.text;
        termB = inputFieldTermB.text;

        Debug.Log("Methode GetValues wird ausgeführt: " + CheckAddition(int.Parse(termA), int.Parse(termB)));
    }

    void Update()
    {
        if (testing)
        {
            GetValues();
        }
    }
}