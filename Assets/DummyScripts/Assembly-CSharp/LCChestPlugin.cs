/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LCChestPlugin : BaseComponentPlugin // TypeDefIndex: 12056
{
	// Fields
	public ConfigChest config; // 0x58
	private LCGadgetMisc _owner; // 0x60
	private bool _marked; // 0x68
	private bool _isLockByAbility; // 0x69
	private LevelGadget _levelGadget; // 0x70
	private GadgetDataItem.OpenData? _bossChestData; // 0x78
	private EntityTimerReceiver _inteeActiveTimer; // 0xC0

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189B79550-0x0000000189B79570 */ get => default; } // 0x0000000181BD6FA0-0x0000000181BD7040 
	public bool isLock { /* [XID] */ /* 0x0000000189B80930-0x0000000189B80950 */ get => default; } // 0x0000000181BD5A10-0x0000000181BD5AF0 

	// Constructors
	public LCChestPlugin() {} // Dummy constructor
	public LCChestPlugin(ConfigChest config) {} // 0x0000000181BD6EA0-0x0000000181BD6FA0

	// Methods
	// [XID] // 0x0000000189B88580-0x0000000189B885A0
	public override void Init() {} // 0x0000000181BD5DB0-0x0000000181BD6110
	// [XID] // 0x0000000189B8F7A0-0x0000000189B8F7C0
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x0000000181BD6B70-0x0000000181BD6EA0
	// [XID] // 0x0000000189B96D00-0x0000000189B96D20
	public void SetLockByAbility(bool isLock) {} // 0x0000000181BD5C50-0x0000000181BD5D00
	// [XID] // 0x0000000189B9E170-0x0000000189B9E190
	private static new EventID[] GetSelfOnEventResolvedIDsExcludingBase() => default; // 0x0000000181BD5B70-0x0000000181BD5C50
	// [XID] // 0x0000000189BA5A70-0x0000000189BA5A90
	public override bool OnEventResolved(BaseEvent evt) => default; // 0x0000000181BD6740-0x0000000181BD6820
	// [XID] // 0x0000000189BACD80-0x0000000189BACDA0
	private void OnStateChanged(EvtGadgetState evt) {} // 0x0000000181BD5870-0x0000000181BD5A10
	// [XID] // 0x0000000189BB4670-0x0000000189BB4690
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x0000000181BD56F0-0x0000000181BD57B0
	// [XID] // 0x0000000189BBBC50-0x0000000189BBBC70
	private void CheckCutscene() {} // 0x0000000181BD6390-0x0000000181BD66D0
	// [XID] // 0x0000000189BC3B10-0x0000000189BC3B30
	public override void Destroy() {} // 0x0000000181BD57B0-0x0000000181BD5870
	// [XID] // 0x0000000189BCB2A0-0x0000000189BCB2C0
	public void HideIntee() {} // 0x0000000181BD5530-0x0000000181BD5680
	// [XID] // 0x0000000189BD2890-0x0000000189BD28B0
	public void UpdateBossChestData(GadgetDataItem.OpenData? data) {} // 0x0000000181BD6820-0x0000000181BD6B70
	// [XID] // 0x0000000189BD9E10-0x0000000189BD9E30
	public void SetInteeActiveTimer(float lifeTime) {} // 0x0000000181BD6170-0x0000000181BD6320
	// [XID] // 0x00000001895E6910-0x00000001895E6930
	private bool InteeActiveTimeFinished() => default; // 0x0000000181BD5D00-0x0000000181BD5DB0
}

