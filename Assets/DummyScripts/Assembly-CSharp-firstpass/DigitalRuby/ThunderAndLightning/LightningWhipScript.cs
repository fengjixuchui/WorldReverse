/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace DigitalRuby.ThunderAndLightning
{
	// [RequireComponent] // 0x00000001898A29D0-0x00000001898A2A20
	public class LightningWhipScript : MonoBehaviour // TypeDefIndex: 9683
	{
		// Fields
		public AudioClip WhipCrack; // 0x18
		public AudioClip WhipCrackThunder; // 0x20
		private AudioSource audioSource; // 0x28
		private GameObject whipStart; // 0x30
		private GameObject whipEndStrike; // 0x38
		private GameObject whipHandle; // 0x40
		private GameObject whipSpring; // 0x48
		private Vector2 prevDrag; // 0x50
		private bool dragging; // 0x58
		private bool canWhip; // 0x59
	
		// Constructors
		public LightningWhipScript() {} // 0x000000018604A140-0x000000018604A1B0
	
		// Methods
		[DebuggerHidden] // 0x00000001898AEB50-0x00000001898AEB90
		// [XID] // 0x00000001898AEB50-0x00000001898AEB90
		private IEnumerator WhipForward() => default; // 0x000000018604A030-0x000000018604A140
		// [XID] // 0x00000001898B93B0-0x00000001898B93D0
		private void Start() {} // 0x0000000186049B00-0x0000000186049C00
		// [XID] // 0x00000001898C0840-0x00000001898C0860
		private void Update() {} // 0x0000000186049C00-0x000000018604A030
	}
}
