/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace InControl
{
	public class Touch // TypeDefIndex: 7829
	{
		// Fields
		public static readonly int FingerID_None; // 0x00
		public static readonly int FingerID_Mouse; // 0x04
		public int fingerId; // 0x10
		public TouchPhase phase; // 0x14
		public int tapCount; // 0x18
		public Vector2 position; // 0x1C
		public Vector2 deltaPosition; // 0x24
		public Vector2 lastPosition; // 0x2C
		public float deltaTime; // 0x34
		public ulong updateTick; // 0x38
		public TouchType type; // 0x40
		public float altitudeAngle; // 0x44
		public float azimuthAngle; // 0x48
		public float maximumPossiblePressure; // 0x4C
		public float pressure; // 0x50
		public float radius; // 0x54
		public float radiusVariance; // 0x58
	
		// Properties
		public float normalizedPressure { /* [XID] */ /* 0x0000000189628B60-0x0000000189628B80 */ get => default; } // 0x00000001877E9EA0-0x00000001877E9FB0 
	
		// Constructors
		internal Touch() {} // 0x00000001877E9E00-0x00000001877E9EA0
		static Touch() {} // 0x00000001877E9D80-0x00000001877E9E00
	
		// Methods
		// [XID] // 0x0000000189621270-0x0000000189621290
		internal void Reset() {} // 0x00000001877E9690-0x00000001877E97D0
		// [XID] // 0x0000000189950D50-0x0000000189950D70
		internal void SetWithTouchData(UnityEngine.Touch touch, ulong updateTick, float deltaTime) {} // 0x00000001877E9B00-0x00000001877E9D80
		// [XID] // 0x0000000189638080-0x00000001896380A0
		internal bool SetWithMouseData(ulong updateTick, float deltaTime) => default; // 0x00000001877E97D0-0x00000001877E9B00
	}
}
