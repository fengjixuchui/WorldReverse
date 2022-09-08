/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class VortexBuilder // TypeDefIndex: 14733
{
	// Fields
	private BaseEntity _owner; // 0x10
	private uint _triggerNum; // 0x18
	private float _height; // 0x1C
	private Dictionary<uint, Bounds> _grassBounds; // 0x20
	private List<uint> _grassIDToAdd; // 0x28
	private List<Bounds> _grassBoundsToAdd; // 0x30
	private List<uint> _grassIDToRemove; // 0x38
	private List<VortexData> _cachedVortexDatas; // 0x40
	private List<VortexData> _usedVortexDatas; // 0x48
	private HashSet<VortexData> _triggeredVortexDatas; // 0x50

	// Nested types
	private class VortexData // TypeDefIndex: 14734
	{
		// Fields
		private const int VORTEX_RADIUS = 4; // Metadata: 0x00AEBE7A
		private BaseEntity _owner; // 0x10
		private uint _triggerNum; // 0x18
		private float _height; // 0x1C
		private List<uint> _grassIDs; // 0x20
		private Vector3 _pos; // 0x28
		private int _effectIndex; // 0x34

		// Constructors
		public VortexData() {} // Dummy constructor
		public VortexData(BaseEntity owner, uint triggerNum, float height) {} // 0x0000000183229E80-0x0000000183229F80

		// Methods
		// [XID] // 0x00000001897FE360-0x00000001897FE380
		public void Destroy() {} // 0x00000001832292C0-0x0000000183229410
		// [XID] // 0x0000000189805A90-0x0000000189805AB0
		public void AddGrass(uint grassID, Vector3 grassPos) {} // 0x0000000183229410-0x0000000183229820
		// [XID] // 0x000000018980D2C0-0x000000018980D2E0
		public void RemoveGrass(uint grassID, Vector3 grassPos) {} // 0x0000000183229B40-0x0000000183229E80
		// [XID] // 0x00000001898149B0-0x00000001898149D0
		public bool InRange(Vector3 pos) => default; // 0x0000000183229820-0x00000001832299C0
		// [XID] // 0x000000018981C4C0-0x000000018981C4E0
		public bool HasGrass(uint grassID) => default; // 0x00000001832291F0-0x00000001832292C0
		// [XID] // 0x0000000189823A00-0x0000000189823A20
		public bool IsEmpty() => default; // 0x0000000183229A80-0x0000000183229B40
		// [XID] // 0x000000018982B330-0x000000018982B350
		public bool CanTrigger() => default; // 0x00000001832299C0-0x0000000183229A80
	}

	// Constructors
	public VortexBuilder() {} // Dummy constructor
	public VortexBuilder(BaseEntity owner, uint triggerNum, float height) {} // 0x0000000182057ED0-0x0000000182057F80

	// Methods
	// [XID] // 0x00000001897A3950-0x00000001897A3970
	public void Destroy() {} // 0x0000000182056AC0-0x0000000182056B70
	// [XID] // 0x00000001897AACA0-0x00000001897AACC0
	private void InitGrass() {} // 0x0000000182057DA0-0x0000000182057ED0
	// [XID] // 0x00000001897B2950-0x00000001897B2970
	private void DestroyGrass() {} // 0x0000000182056B70-0x0000000182056CA0
	// [XID] // 0x00000001897BA390-0x00000001897BA3B0
	public void AddGrass(uint id, Bounds bounds) {} // 0x00000001820571B0-0x0000000182057340
	// [XID] // 0x00000001897C22B0-0x00000001897C22D0
	public void RemoveGrass(uint id) {} // 0x0000000182057960-0x0000000182057AD0
	// [XID] // 0x00000001897C9AE0-0x00000001897C9B00
	private void InitVortex() {} // 0x00000001820568F0-0x0000000182056A00
	// [XID] // 0x00000001897D1150-0x00000001897D1170
	private void DestroyVortex() {} // 0x0000000182056ED0-0x00000001820571B0
	// [XID] // 0x00000001897D9170-0x00000001897D9190
	private VortexData UseVortexData() => default; // 0x0000000182057AD0-0x0000000182057C70
	// [XID] // 0x00000001897E0440-0x00000001897E0460
	private void ReleaseVortexData(VortexData data) {} // 0x0000000182057C70-0x0000000182057DA0
	// [XID] // 0x00000001897E7B10-0x00000001897E7B30
	public void UpdateVortex() {} // 0x0000000182057340-0x0000000182057960
	// [XID] // 0x00000001897EF660-0x00000001897EF680
	public bool HasVortex() => default; // 0x0000000182056A00-0x0000000182056AC0
	// [XID] // 0x00000001897F6D20-0x00000001897F6D40
	public bool CanTriggerInRange(Vector3 pos) => default; // 0x0000000182056CA0-0x0000000182056ED0
}

