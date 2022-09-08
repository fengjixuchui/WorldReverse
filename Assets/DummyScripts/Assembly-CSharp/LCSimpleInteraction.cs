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

public sealed class LCSimpleInteraction : LCBase // TypeDefIndex: 11767
{
	// Fields
	public bool autoClose; // 0x130
	public bool enableInteraction; // 0x131
	public Action customCallBack; // 0x138
	private LCTrigger _trigger; // 0x140
	private AvatarEntity _avatar; // 0x148
	private float _lastTime; // 0x150
	private List<uint> _optionList; // 0x158

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001897DD470-0x00000001897DD490 */ get => default; } // 0x0000000181BD1F20-0x0000000181BD1FC0 
	public List<uint> optionList { /* [XID] */ /* 0x00000001897E4DB0-0x00000001897E4DD0 */ get => default; } // 0x0000000181BD15B0-0x0000000181BD16D0 

	// Constructors
	public LCSimpleInteraction() {} // 0x0000000181BD1EB0-0x0000000181BD1F20

	// Methods
	// [XID] // 0x00000001897EC990-0x00000001897EC9B0
	public override void PreInit() {} // 0x0000000181BD1B10-0x0000000181BD1CE0
	// [XID] // 0x00000001897F4200-0x00000001897F4220
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x0000000181BD1CE0-0x0000000181BD1EB0
	// [XID] // 0x00000001899BECC0-0x00000001899BECE0
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x0000000181BD0740-0x0000000181BD0940
	// [XID] // 0x00000001899CDBC0-0x00000001899CDBE0
	public override void Destroy() {} // 0x0000000181BD0D90-0x0000000181BD0F60
	// [XID] // 0x000000018980A600-0x000000018980A620
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000181BD1100-0x0000000181BD11E0
	// [XID] // 0x00000001899DC7C0-0x00000001899DC7E0
	protected override bool OnEvent(BaseEvent e) => default; // 0x0000000181BD1A00-0x0000000181BD1B10
	// [XID] // 0x00000001899FA900-0x00000001899FA920
	public void UpdateOptionList(IList<uint> options) {} // 0x0000000181BD1790-0x0000000181BD18A0
	// [XID] // 0x0000000189821130-0x0000000189821150
	private void OpenUI() {} // 0x0000000181BD11E0-0x0000000181BD15B0
	// [XID] // 0x00000001898FB370-0x00000001898FB390
	private void CloseUI() {} // 0x0000000181BD0F60-0x0000000181BD1100
	// [XID] // 0x00000001898F3F80-0x00000001898F3FA0
	private void DoCallback(uint optionId) {} // 0x0000000181BD0940-0x0000000181BD0A60
	// [XID] // 0x0000000189837270-0x0000000189837290
	public void OnUICallback(uint optionId) {} // 0x0000000181BD0A60-0x0000000181BD0D90
	// [XID] // 0x000000018983E7F0-0x000000018983E810
	private void OnFieldEnter(BaseEntity entity) {} // 0x0000000181BD0640-0x0000000181BD0740
	// [XID] // 0x0000000189845E70-0x0000000189845E90
	private void OnFieldExit(BaseEntity entity) {} // 0x0000000181BD0550-0x0000000181BD0640
}

