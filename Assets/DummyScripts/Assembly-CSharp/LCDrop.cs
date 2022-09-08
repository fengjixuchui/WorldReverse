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
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LCDrop : LCBase // TypeDefIndex: 11726
{
	// Fields
	private List<GadgetDataItem> _dropItems; // 0x130
	private Vector3 overridePos; // 0x138
	private const float drawnTestHeight = 30f; // Metadata: 0x00AEA75D
	private bool needOverridePos; // 0x144

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189941AF0-0x0000000189941B10 */ get => default; } // 0x000000018378F100-0x000000018378F1A0 

	// Constructors
	public LCDrop() {} // 0x000000018378F060-0x000000018378F100

	// Methods
	// [XID] // 0x00000001896B9B80-0x00000001896B9BA0
	public override void Init() {} // 0x000000018378E6E0-0x000000018378E780
	// [XID] // 0x00000001896E1C60-0x00000001896E1C80
	public override void Destroy() {} // 0x000000018378E1E0-0x000000018378E340
	// [XID] // 0x00000001896E9200-0x00000001896E9220
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x000000018378E070-0x000000018378E1E0
	// [XID] // 0x0000000189715710-0x0000000189715730
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x000000018378E340-0x000000018378E420
	// [XID] // 0x00000001896D7260-0x00000001896D7280
	protected override bool OnEvent(BaseEvent e) => default; // 0x000000018378EF40-0x000000018378F060
	// [XID] // 0x00000001896DEB30-0x00000001896DEB50
	private void OnDie(DieStateFlag dieType) {} // 0x000000018378E7E0-0x000000018378E8A0
	// [XID] // 0x0000000189871F50-0x0000000189871F70
	private void CheckWaterHeight() {} // 0x000000018378E420-0x000000018378E6E0
	// [XID] // 0x00000001896ED3F0-0x00000001896ED410
	public void AddGadget(GadgetDataItem gadgetDataItem, Vector3 pos) {} // 0x000000018378DF40-0x000000018378E070
	// [XID] // 0x00000001896F4D40-0x00000001896F4D60
	public void DropObjects(DieStateFlag flag) {} // 0x000000018378E990-0x000000018378EBD0
	// [XID] // 0x00000001898BD730-0x00000001898BD750
	private void DropObj(GadgetDataItem data, Vector3 serverPos) {} // 0x000000018378EC40-0x000000018378EF40
}

