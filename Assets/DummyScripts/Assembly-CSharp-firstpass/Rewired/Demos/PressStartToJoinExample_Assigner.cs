/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using Rewired;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Rewired.Demos
{
	// [AddComponentMenu] // 0x0000000189B0FD10-0x0000000189B0FD40
	public class PressStartToJoinExample_Assigner : MonoBehaviour // TypeDefIndex: 9791
	{
		// Fields
		private static PressStartToJoinExample_Assigner instance; // 0x00
		public int maxPlayers; // 0x18
		private List<PlayerMap> playerMap; // 0x20
		private int gamePlayerIdCounter; // 0x28
	
		// Nested types
		private class PlayerMap // TypeDefIndex: 9792
		{
			// Fields
			public int rewiredPlayerId; // 0x10
			public int gamePlayerId; // 0x14
	
			// Constructors
			public PlayerMap() {} // Dummy constructor
			public PlayerMap(int rewiredPlayerId, int gamePlayerId) {} // 0x00000001865587A0-0x0000000186558820
		}
	
		// Constructors
		public PressStartToJoinExample_Assigner() {} // 0x000000018655D820-0x000000018655D890
	
		// Methods
		// [XID] // 0x00000001898F88C0-0x00000001898F88E0
		public static Player GetRewiredPlayer(int gamePlayerId) => default; // 0x000000018655D3F0-0x000000018655D6B0
		// [XID] // 0x00000001899001B0-0x00000001899001D0
		private void Awake() {} // 0x000000018655D260-0x000000018655D340
		// [XID] // 0x0000000189907820-0x0000000189907840
		private void Update() {} // 0x000000018655D6B0-0x000000018655D820
		// [XID] // 0x000000018990F160-0x000000018990F180
		private void AssignNextPlayer(int rewiredPlayerId) {} // 0x000000018655CE50-0x000000018655D260
		// [XID] // 0x00000001896D3380-0x00000001896D33A0
		private int GetNextGamePlayerId() => default; // 0x000000018655D340-0x000000018655D3F0
	}
}
