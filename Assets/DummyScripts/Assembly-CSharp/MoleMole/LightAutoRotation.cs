/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class LightAutoRotation : MonoBehaviour // TypeDefIndex: 26499
	{
		// Fields
		// [Header] // 0x000000018998A5D0-0x000000018998A600
		public float VerticalDirectionStep; // 0x18
		// [Header] // 0x0000000189993A20-0x0000000189993A50
		public float HorizonDirectionStep; // 0x1C
		// [Header] // 0x000000018999CBA0-0x000000018999CBD0
		public AngleRange VerticalAngleRange; // 0x20
		private Vector3 _curAngle; // 0x28
		private bool _isInHorizonUpdate; // 0x34
		private int _verticalStepSign; // 0x38
	
		// Nested types
		[Serializable]
		public class AngleRange // TypeDefIndex: 26500
		{
			// Fields
			public float MinValue; // 0x10
			public float MaxValue; // 0x14
	
			// Constructors
			public AngleRange() {} // 0x0000000183A27250-0x0000000183A272C0
			public AngleRange(float min, float max) {} // 0x0000000183A271C0-0x0000000183A27250
		}
	
		// Constructors
		public LightAutoRotation() {} // 0x0000000183A38CC0-0x0000000183A38D40
	
		// Methods
		// [XID] // 0x00000001899A5E50-0x00000001899A5E70
		private void Start() {} // 0x0000000183A38B80-0x0000000183A38C20
		// [XID] // 0x00000001899AD470-0x00000001899AD490
		private void UpdateRotation() {} // 0x0000000183A387A0-0x0000000183A389D0
		// [XID] // 0x00000001899B4D70-0x00000001899B4D90
		private void Update() {} // 0x0000000183A38C20-0x0000000183A38CC0
		// [IDTag] // 0x00000001899BC470-0x00000001899BC4B0
		// [XID] // 0x00000001899BC470-0x00000001899BC4B0
		public static float NormalizeAngle(float angle) => default; // 0x0000000183A38AA0-0x0000000183A38B80
		// [IDTag] // 0x00000001899C6E30-0x00000001899C6E70
		// [XID] // 0x00000001899C6E30-0x00000001899C6E70
		public static void NormalizeAngle(ref Vector3 angle) {} // 0x0000000183A389D0-0x0000000183A38AA0
	}
}
