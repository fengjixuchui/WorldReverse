/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class LCBaseMarkable : LCBase // TypeDefIndex: 11715
{
	// Fields
	protected ConfigLBaseMark _cfgLMark; // 0x130
	protected List<VCBaseMarkable> _vcMarkableList; // 0x138
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected Vector3 _position; // 0x140
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected List<MarkInfo> _markList; // 0x150
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected int _updateFramePeriod; // 0x158
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected int _updateFrameRef; // 0x15C
	protected List<int> _needRemoveList; // 0x160

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189A64210-0x0000000189A64230 */ get => default; } // 0x00000001830D4280-0x00000001830D4320 
	public Vector3 position { /* [XID] */ /* 0x0000000189A57EE0-0x0000000189A57F00 */ get => default; } // 0x00000001830D35B0-0x00000001830D3690 

	// Nested types
	[Serializable]
	protected class MarkInfo // TypeDefIndex: 11716
	{
		// Fields
		public MarkType markType; // 0x10
		public uint markID; // 0x14

		// Constructors
		public MarkInfo() {} // Dummy constructor
		public MarkInfo(MarkType markType, uint markID) {} // 0x00000001830E0BC0-0x00000001830E0C40
	}

	// Constructors
	public LCBaseMarkable() {} // 0x00000001830D4140-0x00000001830D4280

	// Methods
	// [XID] // 0x0000000189854630-0x0000000189854650
	public void Add(MarkType markType, uint markID) {} // 0x00000001830D39D0-0x00000001830D3C20
	// [XID] // 0x00000001898F0E80-0x00000001898F0EA0
	public void Remove(MarkType markType, uint markID) {} // 0x00000001830D3260-0x00000001830D3430
	// [XID] // 0x00000001898F8880-0x00000001898F88A0
	protected void PreInitVCMarkable() {} // 0x00000001830D3E10-0x00000001830D3FA0
	// [XID] // 0x0000000189A82400-0x0000000189A82420
	public VCBaseMarkable AddVCMarkableByCfg(ConfigVBaseMark vcMarkCfg) => default; // 0x00000001830D29A0-0x00000001830D2AC0
	// [XID] // 0x000000018990F0D0-0x000000018990F0F0
	public override void PreInit() {} // 0x00000001830D3FA0-0x00000001830D4060
	// [XID] // 0x0000000189A91420-0x0000000189A91440
	public override void Init() {} // 0x00000001830D3430-0x00000001830D34F0
	// [XID] // 0x0000000189A99010-0x0000000189A99030
	protected override void Tick(float inDeltaTime) {} // 0x00000001830D4060-0x00000001830D4140
	// [XID] // 0x0000000189AA0140-0x0000000189AA0160
	public virtual void RefreshMarkState() {} // 0x00000001830D3690-0x00000001830D3730
	// [XID] // 0x0000000189AA7990-0x0000000189AA79B0
	private void RefreshMarkState_Always() {} // 0x00000001830D2AC0-0x00000001830D2B90
	// [XID] // 0x0000000189AAF190-0x0000000189AAF1B0
	public virtual void ShowMark() {} // 0x00000001830D38A0-0x00000001830D39D0
	// [XID] // 0x0000000189AB6A50-0x0000000189AB6A70
	public virtual void HideMark() {} // 0x00000001830D3130-0x00000001830D3260
	// [XID] // 0x0000000189A449C0-0x0000000189A449E0
	public virtual void RemoveVCMarkable(VCBaseMarkable vcMarkable) {} // 0x00000001830D3730-0x00000001830D38A0
	// [XID] // 0x00000001896FF630-0x00000001896FF650
	public override void Destroy() {} // 0x00000001830D2BF0-0x00000001830D2D80
	// [XID] // 0x0000000189ACD640-0x0000000189ACD660
	public override void OnEnable() {} // 0x00000001830D3D50-0x00000001830D3E10
	// [XID] // 0x0000000189AD53C0-0x0000000189AD53E0
	public override void OnDisable() {} // 0x00000001830D3C90-0x00000001830D3D50
	// [XID] // 0x00000001899B5B60-0x00000001899B5B80
	protected virtual void CheckPosition() {} // 0x00000001830D2E60-0x00000001830D3130
}

