using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameStateDisplay : MonoBehaviour
{
    #region Serialized Variables
    [SerializeField]
    string ChooseIncidentString;
    [SerializeField]
    string PlayIncidentString;
    [SerializeField]
    string ChooseResponseString;
    [SerializeField]
    string PlayResolutionString;
    #endregion

    // Update is called once per frame
    void Update ()
    {
        string fieldText = "NULLSTRING";
        

        switch(GamePlayManager.instance.currentGameState)
        {
            case (GamePlayManager.GameStates.ChooseIncident):
                fieldText = ChooseIncidentString;
                break;
            case (GamePlayManager.GameStates.PlayIncident):
                fieldText = PlayIncidentString;
                break;
            case (GamePlayManager.GameStates.ChooseResponse):
                fieldText = ChooseResponseString;
                break;
            case (GamePlayManager.GameStates.PlayResolution):
                fieldText = PlayResolutionString;
                break;
        }

        GetComponent<Text>().text = fieldText;
    }
}