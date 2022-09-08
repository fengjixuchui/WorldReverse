/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LCSelectPickup : LCBase // TypeDefIndex: 11765
{
	// Fields
	private const float CHECK_CD = 0.1f; // Metadata: 0x00AEA7A3
	private float _nextCheckTime; // 0x130
	private BaseShape3d _inShape; // 0x138
	private BaseShape3d _outShape; // 0x140
	private List<uint> _triggerEntities; // 0x148
	private HashSet<uint> _triggerEntitySet; // 0x150
	private List<uint> _tempEntities; // 0x158
	private int _disappearEntityIter; // 0x160
	private int _appearEntityIter; // 0x164
	private Action<uint> _pickupCB; // 0x168
	private State _state; // 0x170
	private SliceFrameWatch _sharedWatcher; // 0x178

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189746F00-0x0000000189746F20 */ get => default; } // 0x000000018215E4D0-0x000000018215E570 
	public List<uint> triggerEntities { /* [XID] */ /* 0x00000001897CE620-0x00000001897CE640 */ get => default; } // 0x000000018215E250-0x000000018215E300 

	// Nested types
	private enum State // TypeDefIndex: 11766
	{
		WaitToBegin = 0,
		BeginToCheckDisappear = 1,
		CheckingDisappear = 2,
		BeginToCheckAppear = 3,
		CheckingAppear = 4
	}

	// Constructors
	public LCSelectPickup() {} // 0x000000018215E410-0x000000018215E4D0

	// Methods
	// [XID] // 0x000000018974E710-0x000000018974E730
	public override void Init() {} // 0x000000018215CDC0-0x000000018215D0E0
	// [XID] // 0x0000000189755DC0-0x0000000189755DE0
	public override void Destroy() {} // 0x000000018215C570-0x000000018215C690
	// [XID] // 0x000000018975D0C0-0x000000018975D0E0
	protected override void Tick(float inDeltaTime) {} // 0x000000018215E300-0x000000018215E410
	// [XID] // 0x0000000189BDBB70-0x0000000189BDBB90
	private void UpdateInShape() {} // 0x000000018215E070-0x000000018215E250
	// [XID] // 0x00000001896422B0-0x00000001896422D0
	private bool IsInPosition(BaseEntity e) => default; // 0x000000018215DD00-0x000000018215DEC0
	// [XID] // 0x0000000189773720-0x0000000189773740
	private void UpdateOutShape() {} // 0x000000018215C1F0-0x000000018215C3D0
	// [XID] // 0x0000000189BC5110-0x0000000189BC5130
	private bool IsOutPosition(BaseEntity e) => default; // 0x000000018215C710-0x000000018215C8D0
	// [XID] // 0x0000000189BCCBA0-0x0000000189BCCBC0
	private bool IsTargetType(BaseEntity e) => default; // 0x000000018215DEC0-0x000000018215E070
	// [XID] // 0x0000000189BBD3D0-0x0000000189BBD3F0
	private bool NeedShowPickUpBtn(BaseEntity e) => default; // 0x000000018215CBE0-0x000000018215CDC0
	// [XID] // 0x0000000189B6BFD0-0x0000000189B6BFF0
	private void WaitToCheck() {} // 0x000000018215C3D0-0x000000018215C4A0
	// [XID] // 0x0000000189B7AD00-0x0000000189B7AD20
	private void BeginToCheckDisappearEntities() {} // 0x000000018215C4A0-0x000000018215C570
	// [XID] // 0x0000000189BB5E10-0x0000000189BB5E30
	private void CheckDisapparEntities() {} // 0x000000018215BE70-0x000000018215C1F0
	// [XID] // 0x00000001897A80E0-0x00000001897A8100
	private void BeginToCheckAppearEntities() {} // 0x000000018215C8D0-0x000000018215CAF0
	// [XID] // 0x00000001897AFBD0-0x00000001897AFBF0
	private void CheckAppearEntities() {} // 0x000000018215D930-0x000000018215DC90
	// [XID] // 0x00000001897B7930-0x00000001897B7950
	private void AddInteeBtnByID(BaseEntity entity) {} // 0x000000018215D0E0-0x000000018215D730
	// [XID] // 0x00000001897BF8E0-0x00000001897BF900
	private void CheckSelectPickup() {} // 0x000000018215CAF0-0x000000018215CBE0
	// [XID] // 0x00000001897C7030-0x00000001897C7050
	public void ForceUpdate() {} // 0x000000018215D790-0x000000018215D930
	// [XID] // 0x00000001897D5CF0-0x00000001897D5D10
	public void ClearTriggerEntities() {} // 0x000000018215BDA0-0x000000018215BE70
}

