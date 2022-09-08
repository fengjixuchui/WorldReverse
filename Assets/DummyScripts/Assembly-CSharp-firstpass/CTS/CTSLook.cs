/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace CTS
{
	public class CTSLook : MonoBehaviour // TypeDefIndex: 9125
	{
		// Fields
		// [Header] // 0x0000000189AF0A60-0x0000000189AF0A90
		private List<float> _rotArrayX; // 0x18
		private List<float> _rotArrayY; // 0x20
		private float rotAverageX; // 0x28
		private float rotAverageY; // 0x2C
		private float mouseDeltaX; // 0x30
		private float mouseDeltaY; // 0x34
		// [Header] // 0x0000000189AF99A0-0x0000000189AF99D0
		public bool _isLocked; // 0x38
		public float _sensitivityX; // 0x3C
		public float _sensitivityY; // 0x40
		// [Tooltip] // 0x0000000189B027E0-0x0000000189B02810
		public int _averageFromThisManySteps; // 0x44
		// [Header] // 0x0000000189B0B420-0x0000000189B0B480
		// [Tooltip] // 0x0000000189B0B420-0x0000000189B0B480
		public Transform _playerRootT; // 0x48
		// [Tooltip] // 0x0000000189B18A00-0x0000000189B18A30
		public Transform _cameraT; // 0x50
	
		// Constructors
		public CTSLook() {} // 0x000000018756C760-0x000000018756C830
	
		// Methods
		// [XID] // 0x0000000189B21540-0x0000000189B21560
		private void Update() {} // 0x000000018756C6C0-0x000000018756C760
		// [XID] // 0x00000001895F1260-0x00000001895F1280
		private void MouseLookAveraged() {} // 0x000000018756C310-0x000000018756C6C0
	}
}
