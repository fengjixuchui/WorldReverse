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

namespace HedgehogTeam.EasyTouch
{
	public class EasyTouchInput // TypeDefIndex: 7344
	{
		// Fields
		private Vector2[] oldMousePosition; // 0x10
		private int[] tapCount; // 0x18
		private float[] startActionTime; // 0x20
		private float[] deltaTime; // 0x28
		private float[] tapeTime; // 0x30
		private bool bComplex; // 0x38
		private Vector2 deltaFingerPosition; // 0x3C
		private Vector2 oldFinger2Position; // 0x44
		private Vector2 complexCenter; // 0x4C
	
		// Constructors
		public EasyTouchInput() {} // 0x0000000180B2E830-0x0000000180B2E940
	
		// Methods
		// [XID] // 0x00000001897843D0-0x00000001897843F0
		public int TouchCount() => default; // 0x0000000180B2E780-0x0000000180B2E830
		// [XID] // 0x000000018978BA50-0x000000018978BA70
		private int getTouchCount(bool realTouch) => default; // 0x0000000180B2E940-0x0000000180B2ED70
		// [XID] // 0x0000000189B60430-0x0000000189B60450
		public Finger GetMouseTouch(int fingerIndex, Finger myFinger) => default; // 0x0000000180B2D4E0-0x0000000180B2DFA0
		// [XID] // 0x000000018979A5F0-0x000000018979A610
		public Vector2 GetSecondFingerPosition() => default; // 0x0000000180B2E350-0x0000000180B2E780
		// [XID] // 0x0000000189B67C70-0x0000000189B67C90
		private Vector2 GetPointerPosition(int index) => default; // 0x0000000180B2E210-0x0000000180B2E350
		// [XID] // 0x00000001897A9BF0-0x00000001897A9C10
		private Vector2 GetPinchTwist2Finger(bool newSim = false /* Metadata: 0x00ADE99E */) => default; // 0x0000000180B2DFA0-0x0000000180B2E210
		// [XID] // 0x00000001897B1410-0x00000001897B1430
		private Vector2 GetComplex2finger() => default; // 0x0000000180B2D320-0x0000000180B2D4E0
	}
}
