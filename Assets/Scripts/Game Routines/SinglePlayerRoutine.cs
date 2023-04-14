/******************************************************************
 * Created by: Jacob Welch
 * Email: jacobw@virtusense.com
 * Company: Virtusense
 * Project: Cannon Fodder
 * Creation Date: 4/14/2023 4:47:05 PM
 * 
 * Description: TODO
******************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static InspectorValues;
using static ValidCheck;

public class SinglePlayerRoutine : IGameRoutine
{
    #region Fields

    #endregion

    #region Functions
    public override IEnumerator GameplayRoutine()
    {
        var npc = FindObjectOfType<NPCShipMovement>();
        npc.StartNPC();

        while (true)
        {
            yield return new WaitForEndOfFrame();
        }

        npc.StopNPC();
    }

    public override void SetActive(bool shouldBeActive)
    {
        throw new System.NotImplementedException();
    }
    #endregion
}
