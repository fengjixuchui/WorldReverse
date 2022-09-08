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
	public class MonoLadderConfigHelper : MonoBehaviour // TypeDefIndex: 31744
	{
		// Fields
		public const float LADDER_STEP_DISTANCE = 0.3f; // Metadata: 0x00B1350A
		public const float LADDER_COL_LENGHT = 1f; // Metadata: 0x00B1350E
		public const float LADDER_COL_WIDTH = 0.11f; // Metadata: 0x00B13512
		public const float DISTANCE_FROM_TOP_TO_GROUND = 0.3f; // Metadata: 0x00B13516
		private const float DISTANCE_FROM_BOTTOM_TO_GROUND = 0.125f; // Metadata: 0x00B1351A
		private const float DISTANCE_FROM_TOP_TO_GROUND_HORIZONTAL = 0.125f; // Metadata: 0x00B1351E
		public int stepNumber; // 0x38
		public BottomType bottomType; // 0x3C
		private Vector3 position; // 0x40
	
		// Properties
		public float topPos { /* [XID] */ /* 0x00000001897A5AB0-0x00000001897A5AF0 */ get; /* [XID] */ /* 0x00000001897AFFA0-0x00000001897AFFE0 */ private set; } // 0x0000000183F92DA0-0x0000000183F92E10 0x0000000183F92800-0x0000000183F92870
		public float bottomPos { /* [XID] */ /* 0x00000001897BB0B0-0x00000001897BB0F0 */ get; /* [XID] */ /* 0x00000001897C5B70-0x00000001897C5BB0 */ private set; } // 0x0000000183F92C50-0x0000000183F92CC0 0x0000000183F92870-0x0000000183F928E0
		public Vector3 forward { /* [XID] */ /* 0x00000001897D02E0-0x00000001897D0320 */ get; /* [XID] */ /* 0x00000001897DAC30-0x00000001897DAC70 */ private set; } // 0x0000000183F92CC0-0x0000000183F92D30 0x0000000183F92B70-0x0000000183F92BE0
		public Vector3 topGroundPos { /* [XID] */ /* 0x00000001897E5250-0x00000001897E5290 */ get; /* [XID] */ /* 0x00000001897EFBA0-0x00000001897EFBE0 */ private set; } // 0x0000000183F92D30-0x0000000183F92DA0 0x0000000183F923A0-0x0000000183F92410
	
		// Nested types
		public enum BottomType // TypeDefIndex: 31745
		{
			Ground = 0,
			Water = 1,
			Drop = 2
		}
	
		// Constructors
		public MonoLadderConfigHelper() {} // 0x0000000183F92BE0-0x0000000183F92C50
	
		// Methods
		// [XID] // 0x00000001897FA770-0x00000001897FA790
		public void Awake() {} // 0x0000000183F91E00-0x0000000183F923A0
		// [XID] // 0x0000000189801D70-0x0000000189801D90
		public bool CanGetUpOnLadder(Vector3 pos, Vector3 forward, float height, out Vector3 ladderPos) {
			ladderPos = default;
			return default;
		} // 0x0000000183F92410-0x0000000183F92800
		// [XID] // 0x00000001898091C0-0x00000001898091E0
		public Vector3 GetBelowLadderPos(Vector3 curPosition) => default; // 0x0000000183F928E0-0x0000000183F92B70
	}
}
