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

public sealed class LCGadgetMisc : LCBase // TypeDefIndex: 11734
{
	// Fields
	public const string GADGET_STATE = "GadgetState"; // Metadata: 0x00AEA761
	public ConfigGadgetMisc config; // 0x130
	public GadgetState curGadgetState; // 0x138
	private GadgetDataItem _dataItem; // 0x140
	private LCPose _lcPos; // 0x148
	private LCChestPlugin _chestPlugin; // 0x150

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001898DED90-0x00000001898DEDB0 */ get => default; } // 0x0000000183E736C0-0x0000000183E73760 

	// Constructors
	public LCGadgetMisc() {} // Dummy constructor
	public LCGadgetMisc(ConfigGadgetMisc config) {} // 0x0000000183E73630-0x0000000183E736C0

	// Methods
	// [XID] // 0x00000001898F3FA0-0x00000001898F3FC0
	public override void Init() {} // 0x0000000183E72AF0-0x0000000183E72E10
	// [XID] // 0x000000018973E440-0x000000018973E460
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x0000000183E733F0-0x0000000183E73630
	// [XID] // 0x00000001898F5630-0x00000001898F5650
	public override void PostReInit() {} // 0x0000000183E732F0-0x0000000183E733F0
	// [XID] // 0x00000001898FCD40-0x00000001898FCD60
	public override void OnEntityReady() {} // 0x0000000183E730F0-0x0000000183E731F0
	// [XID] // 0x00000001899046E0-0x0000000189904700
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000183E729B0-0x0000000183E72A90
	// [XID] // 0x000000018990BEA0-0x000000018990BEC0
	protected override bool OnEvent(BaseEvent evt) => default; // 0x0000000183E731F0-0x0000000183E732F0
	// [XID] // 0x000000018974D210-0x000000018974D230
	private void OnStateChanged(EvtGadgetState evt) {} // 0x0000000183E728C0-0x0000000183E729B0
	// [XID] // 0x000000018991B1E0-0x000000018991B200
	public override void OnEnable() {} // 0x0000000183E73030-0x0000000183E730F0
	// [XID] // 0x000000018979F6F0-0x000000018979F710
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x0000000183E725E0-0x0000000183E727A0
	// [XID] // 0x00000001897A6BC0-0x00000001897A6BE0
	public override void Destroy() {} // 0x0000000183E72800-0x0000000183E728C0
}

