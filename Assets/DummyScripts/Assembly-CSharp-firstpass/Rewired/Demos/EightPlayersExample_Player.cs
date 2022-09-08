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
	// [AddComponentMenu] // 0x0000000189ADB2F0-0x0000000189ADB370
	// [RequireComponent] // 0x0000000189ADB2F0-0x0000000189ADB370
	public class EightPlayersExample_Player : MonoBehaviour // TypeDefIndex: 9779
	{
		// Fields
		public int playerId; // 0x18
		public float moveSpeed; // 0x1C
		public float bulletSpeed; // 0x20
		public GameObject bulletPrefab; // 0x28
		private Player player; // 0x30
		private CharacterController cc; // 0x38
		private Vector3 moveVector; // 0x40
		private bool fire; // 0x4C
		[NonSerialized]
		private bool initialized; // 0x4D
	
		// Constructors
		public EightPlayersExample_Player() {} // 0x000000018654D3E0-0x000000018654D460
	
		// Methods
		// [XID] // 0x0000000189AEA5D0-0x0000000189AEA5F0
		private void Awake() {} // 0x000000018654CCF0-0x000000018654CDA0
		// [XID] // 0x0000000189AF1FF0-0x0000000189AF2010
		private void Initialize() {} // 0x000000018654CEA0-0x000000018654CF80
		// [XID] // 0x000000018995E010-0x000000018995E030
		private void Update() {} // 0x000000018654D2F0-0x000000018654D3E0
		// [XID] // 0x00000001899283B0-0x00000001899283D0
		private void GetInput() {} // 0x000000018654CDA0-0x000000018654CEA0
		// [XID] // 0x0000000189B08400-0x0000000189B08420
		private void ProcessInput() {} // 0x000000018654CF80-0x000000018654D2F0
	}
}
