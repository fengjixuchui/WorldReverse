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
	// [AddComponentMenu] // 0x000000018991E1F0-0x000000018991E270
	// [RequireComponent] // 0x000000018991E1F0-0x000000018991E270
	public class PressStartToJoinExample_GamePlayer : MonoBehaviour // TypeDefIndex: 9793
	{
		// Fields
		public int gamePlayerId; // 0x18
		public float moveSpeed; // 0x1C
		public float bulletSpeed; // 0x20
		public GameObject bulletPrefab; // 0x28
		private CharacterController cc; // 0x30
		private Vector3 moveVector; // 0x38
		private bool fire; // 0x44
	
		// Properties
		private Player player { /* [XID] */ /* 0x000000018992CFA0-0x000000018992CFC0 */ get => default; } // 0x000000018655DF40-0x000000018655DFF0 
	
		// Constructors
		public PressStartToJoinExample_GamePlayer() {} // 0x000000018655DEC0-0x000000018655DF40
	
		// Methods
		// [XID] // 0x0000000189934670-0x0000000189934690
		private void OnEnable() {} // 0x000000018655D9B0-0x000000018655DA60
		// [XID] // 0x000000018993C1D0-0x000000018993C1F0
		private void Update() {} // 0x000000018655DDD0-0x000000018655DEC0
		// [XID] // 0x00000001899435E0-0x0000000189943600
		private void GetInput() {} // 0x000000018655D890-0x000000018655D9B0
		// [XID] // 0x000000018994ACD0-0x000000018994ACF0
		private void ProcessInput() {} // 0x000000018655DA60-0x000000018655DDD0
	}
}
