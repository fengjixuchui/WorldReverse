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
	public class DummyActionPoint // TypeDefIndex: 21075
	{
		// Fields
		public DummyPoint dummypoint; // 0x10
		public int action; // 0x18
		public float time; // 0x1C
		public int freestyle; // 0x20
		public int actionPointType; // 0x24
		public uint actionPointId; // 0x28
	
		// Properties
		public LevelActionPoint ActionPointData { /* [XID] */ /* 0x00000001898A91D0-0x00000001898A9210 */ get; /* [XID] */ /* 0x00000001898B3700-0x00000001898B3740 */ private set; } // 0x0000000184D97100-0x0000000184D97160 0x0000000184D973A0-0x0000000184D97400
		public Vector3 Position { /* [XID] */ /* 0x00000001898BDFA0-0x00000001898BDFC0 */ get => default; /* [XID] */ /* 0x00000001898C5830-0x00000001898C5850 */ set {} } // 0x0000000184D97160-0x0000000184D97280 0x0000000184D97400-0x0000000184D974D0
		public Vector3 Rotation { /* [XID] */ /* 0x00000001898CCF10-0x00000001898CCF30 */ get => default; /* [XID] */ /* 0x00000001898D48B0-0x00000001898D48D0 */ set {} } // 0x0000000184D97280-0x0000000184D973A0 0x0000000184D974D0-0x0000000184D975A0
	
		// Constructors
		public DummyActionPoint() {} // 0x0000000184D970A0-0x0000000184D97100
	
		// Methods
		// [XID] // 0x00000001898DC270-0x00000001898DC290
		public void Reset() {} // 0x0000000184D96DE0-0x0000000184D96F50
		// [XID] // 0x00000001898E3C40-0x00000001898E3C60
		public void CopyTo(DummyActionPoint targetPoint) {} // 0x0000000184D969F0-0x0000000184D96BA0
		// [XID] // 0x00000001898EB7F0-0x00000001898EB810
		public static bool IsSame(DummyActionPoint left, DummyActionPoint right) => default; // 0x0000000184D96BA0-0x0000000184D96DE0
		// [XID] // 0x00000001898F3040-0x00000001898F3060
		public void ApplyFromLevelActionPoint(LevelActionPoint levelActionPoint) {} // 0x0000000184D96880-0x0000000184D969F0
		// [XID] // 0x00000001898FA720-0x00000001898FA740
		public void TryRefreshFreeStyle() {} // 0x0000000184D96F50-0x0000000184D970A0
	}
}
