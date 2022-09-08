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

namespace MultiplayerWithBindingsExample
{
	public class PlayerManager : MonoBehaviour // TypeDefIndex: 7581
	{
		// Fields
		public GameObject playerPrefab; // 0x18
		private const int maxPlayers = 4; // Metadata: 0x00ADED56
		private List<Vector3> playerPositions; // 0x20
		private List<Player> players; // 0x28
		private PlayerActions keyboardListener; // 0x30
		private PlayerActions joystickListener; // 0x38
	
		// Constructors
		public PlayerManager() {} // 0x00000001853DF350-0x00000001853DF570
	
		// Methods
		// [XID] // 0x00000001898C65A0-0x00000001898C65C0
		private void OnEnable() {} // 0x00000001853DE140-0x00000001853DE260
		// [XID] // 0x00000001899DC860-0x00000001899DC880
		private void OnDisable() {} // 0x00000001853DE010-0x00000001853DE140
		// [XID] // 0x000000018987D3B0-0x000000018987D3D0
		private void Update() {} // 0x00000001853DF220-0x00000001853DF350
		// [XID] // 0x00000001899EB6F0-0x00000001899EB710
		private bool JoinButtonWasPressedOnListener(PlayerActions actions) => default; // 0x00000001853DDCD0-0x00000001853DDE10
		// [XID] // 0x00000001899F33C0-0x00000001899F33E0
		private Player FindPlayerUsingJoystick(InputDevice inputDevice) => default; // 0x00000001853DD880-0x00000001853DDA10
		// [XID] // 0x00000001899FAB50-0x00000001899FAB70
		private bool ThereIsNoPlayerUsingJoystick(InputDevice inputDevice) => default; // 0x00000001853DEF50-0x00000001853DF040
		// [XID] // 0x000000018992E910-0x000000018992E930
		private Player FindPlayerUsingKeyboard() => default; // 0x00000001853DDA10-0x00000001853DDB70
		// [XID] // 0x0000000189927160-0x0000000189927180
		private bool ThereIsNoPlayerUsingKeyboard() => default; // 0x00000001853DF040-0x00000001853DF120
		// [XID] // 0x0000000189A10CD0-0x0000000189A10CF0
		private void OnDeviceDetached(InputDevice inputDevice) {} // 0x00000001853DDE10-0x00000001853DDF10
		// [XID] // 0x0000000189A181F0-0x0000000189A18210
		private Player CreatePlayer(InputDevice inputDevice) => default; // 0x00000001853DD270-0x00000001853DD4E0
		// [XID] // 0x00000001898E4AA0-0x00000001898E4AC0
		private void RemovePlayer(Player player) {} // 0x00000001853DE9E0-0x00000001853DEBA0
		// [XID] // 0x0000000189A26CE0-0x0000000189A26D00
		private void OnGUI() {} // 0x00000001853DE620-0x00000001853DE9E0
	}
}
