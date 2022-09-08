/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
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
	public class PlayerMouseSpriteExample : MonoBehaviour // TypeDefIndex: 9786
	{
		// Fields
		// [Tooltip] // 0x000000018974BA50-0x000000018974BA80
		public int playerId; // 0x18
		// [Tooltip] // 0x0000000189754870-0x00000001897548A0
		public string horizontalAction; // 0x20
		// [Tooltip] // 0x000000018975D2A0-0x000000018975D2D0
		public string verticalAction; // 0x28
		// [Tooltip] // 0x0000000189766250-0x0000000189766280
		public string wheelAction; // 0x30
		// [Tooltip] // 0x000000018976EF70-0x000000018976EFA0
		public string leftButtonAction; // 0x38
		// [Tooltip] // 0x0000000189778180-0x00000001897781B0
		public string rightButtonAction; // 0x40
		// [Tooltip] // 0x0000000189781360-0x0000000189781390
		public string middleButtonAction; // 0x48
		// [Tooltip] // 0x0000000189789EB0-0x0000000189789EE0
		public float distanceFromCamera; // 0x50
		// [Tooltip] // 0x0000000189792D10-0x0000000189792D40
		public float spriteScale; // 0x54
		// [Tooltip] // 0x000000018979C6E0-0x000000018979C710
		public GameObject pointerPrefab; // 0x58
		// [Tooltip] // 0x00000001897A55F0-0x00000001897A5620
		public GameObject clickEffectPrefab; // 0x60
		// [Tooltip] // 0x00000001897AE300-0x00000001897AE330
		public bool hideHardwarePointer; // 0x68
		[NonSerialized]
		private GameObject pointer; // 0x70
		[NonSerialized]
		private PlayerMouse mouse; // 0x78
	
		// Constructors
		public PlayerMouseSpriteExample() {} // 0x0000000186559400-0x00000001865594C0
	
		// Methods
		// [XID] // 0x00000001897B7AA0-0x00000001897B7AC0
		private void Awake() {} // 0x0000000186558820-0x0000000186558C80
		// [XID] // 0x000000018982BF70-0x000000018982BF90
		private void Update() {} // 0x00000001865590D0-0x0000000186559400
		// [XID] // 0x00000001898244A0-0x00000001898244C0
		private void CreateClickEffect(Color color) {} // 0x0000000186558C80-0x0000000186558F40
		// [XID] // 0x00000001897FF050-0x00000001897FF070
		private void OnScreenPositionChanged(Vector2 position) {} // 0x0000000186558F40-0x00000001865590D0
	}
}
