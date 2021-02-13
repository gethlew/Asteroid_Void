using CI.QuickSave;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EasyLev1 : MonoBehaviour
{
    public Text Input1;
    public Text Input2;
    public InputField Input3;
    public InputField Input4;
    


    public void Save()
    {
        //Description of code below//The first strings below are the keys for the items which are stored e.g. Text Input1 has a key of Input1// 
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        int test = currentSceneIndex + 1;
        QuickSaveWriter.Create("InputsLev1")
                       .Write("Inpt1", Input1.text)
                       //.Write("Input2", Input2.text)
                       .Commit();
    }
    //The first strings below are the keys for the items which are stored e.g. Text Input1 has a key of Input1// Input3 is the corresponding field where the resul will appear in//
    public void Load()
    {
        QuickSaveReader.Create("InputsLev1")
                       .Read<string>("Inpt1", (r) => { Input3.text = r; });
        // .Read<string>("Input2", (r) => { Input4.text = r; });


    }

}