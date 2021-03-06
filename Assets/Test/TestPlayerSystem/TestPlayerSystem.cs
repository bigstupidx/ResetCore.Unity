﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ResetCore.Data;
using ResetCore.GameSystem;
using UnityEngine;

public class TestPlayerSystem : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
	    TestTimePlayer player1 = new TestTimePlayer("A");
	    player1.Init(new TimePlayerData(0.5f, 0, 1));

	    TestTimePlayer player2 = new TestTimePlayer("B");
	    player2.Init(new TimePlayerData(1, 0, 5));

        SkillPlayer skillPlayer = new SkillPlayer();
	    skillPlayer.Init(new BasePlayerData(1, 0), new BasePlayer[]
	    {
	        player1, player2
        });
	    skillPlayer.Start();

        //Debug.Log(ReXmlSerializer.WriteToXmlDocument("SkillPlayer", skillPlayer).InnerXml);
	    
    }

    // Update is called once per frame
    public void Save(Stream stream)
    {
    }
}
