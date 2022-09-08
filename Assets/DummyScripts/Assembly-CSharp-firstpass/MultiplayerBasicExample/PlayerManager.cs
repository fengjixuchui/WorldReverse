/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using InControl;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MultiplayerBasicExample
{
	public class PlayerManager : MonoBehaviour // TypeDefIndex: 7578
	{
		// Fields
		public GameObject playerPrefab; // 0x18
		private const int maxPlayers = 4; // Metadata: 0x00ADED52
		private List<Vector3> playerPositions; // 0x20
		private List<Player> players; // 0x28
	
		// Constructors
		public PlayerManager() {} // 0x00000001853DF570-0x00000001853DF790
	
		// Methods
		// [XID] // 0x0000000189944E90-0x0000000189944EB0
		private void Start() {} // 0x00000001853DED60-0x00000001853DEE60
		// [XID] // 0x000000018994C540-0x000000018994C560
		private void Update() {} // 0x00000001853DF120-0x00000001853DF220
		// [XID] // 0x0000000189953BF0-0x0000000189953C10
		private bool JoinButtonWasPressedOnDevice(InputDevice inputDevice) => default; // 0x00000001853DDB70-0x00000001853DDCD0
		// [XID] // 0x000000018995B3D0-0x000000018995B3F0
		private Player FindPlayerUsingDevice(InputDevice inputDevice) => default; // 0x00000001853DD710-0x00000001853DD880
		// [XID] // 0x00000001897A3AD0-0x00000001897A3AF0
		private bool ThereIsNoPlayerUsingDevice(InputDevice inputDevice) => default; // 0x00000001853DEE60-0x00000001853DEF50
		// [XID] // 0x000000018996A350-0x000000018996A370
		private void OnDeviceDetached(InputDevice inputDevice) {} // 0x00000001853DDF10-0x00000001853DE010
		// [XID] // 0x0000000189934380-0x00000001899343A0
		private Player CreatePlayer(InputDevice inputDevice) => default; // 0x00000001853DD4E0-0x00000001853DD710
		// [XID] // 0x0000000189979980-0x00000001899799A0
		private void RemovePlayer(Player player) {} // 0x00000001853DEBA0-0x00000001853DED60
		// [XID] // 0x0000000189892320-0x0000000189892340
		private void OnGUI() {} // 0x00000001853DE260-0x00000001853DE620
	}
}
