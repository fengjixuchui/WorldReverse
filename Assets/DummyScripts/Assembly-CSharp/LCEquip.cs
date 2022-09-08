/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LCEquip : LCItem // TypeDefIndex: 11727
{
	// Fields
	private WeaponDataItem _equipDataItem; // 0x140
	private ItemConfig _equipConfig; // 0x148
	public ulong bagItemGuid; // 0x150

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189703A40-0x0000000189703A60 */ get => default; } // 0x0000000184401B90-0x0000000184401C30 
	public WeaponItem equipItem { /* [XID] */ /* 0x000000018970B1F0-0x000000018970B210 */ get => default; } // 0x0000000184400EE0-0x0000000184401010 
	public ItemConfig equipConfig { /* [XID] */ /* 0x0000000189B957C0-0x0000000189B957E0 */ get => default; /* [XID] */ /* 0x0000000189728C40-0x0000000189728C60 */ set {} } // 0x00000001844010C0-0x0000000184401170 0x0000000184401010-0x00000001844010C0

	// Constructors
	public LCEquip() {} // 0x0000000184401B20-0x0000000184401B90

	// Methods
	// [XID] // 0x0000000189757580-0x00000001897575A0
	public override void PreInit() {} // 0x0000000184401920-0x0000000184401B20
	// [XID] // 0x000000018971A330-0x000000018971A350
	private void OntEntityReadyPost(EvtEntityReadyPost evt) {} // 0x0000000184401590-0x0000000184401660
	// [XID] // 0x0000000189730690-0x00000001897306B0
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x00000001844013F0-0x00000001844014D0
	// [XID] // 0x0000000189737E90-0x0000000189737EB0
	protected override bool OnEvent(BaseEvent e) => default; // 0x0000000184401750-0x0000000184401920
	// [XID] // 0x000000018973F9E0-0x000000018973FA00
	public override void Destroy() {} // 0x0000000184401170-0x0000000184401360
}

