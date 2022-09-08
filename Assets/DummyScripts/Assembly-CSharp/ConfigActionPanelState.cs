/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigActionPanelState : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18799
{
	// Fields
	private Dictionary<ActionSlotType, ConfigActionButton[]> _slotMap; // 0x10
	private Dictionary<ActionSlotType, ConfigActionButton[]> _slotMapJoypadOverride; // 0x18

	// Properties
	public Dictionary<ActionSlotType, ConfigActionButton[]> slotMap { /* [XID] */ /* 0x0000000189A7A3B0-0x0000000189A7A3D0 */ get => default; /* [XID] */ /* 0x0000000189A81810-0x0000000189A81830 */ private set {} } // 0x0000000182309EC0-0x0000000182309F60 0x000000018230AA40-0x000000018230AAF0
	public Dictionary<ActionSlotType, ConfigActionButton[]> slotMapJoypadOverride { /* [XID] */ /* 0x0000000189A89330-0x0000000189A89350 */ get => default; /* [XID] */ /* 0x0000000189A90BB0-0x0000000189A90BD0 */ private set {} } // 0x000000018230A230-0x000000018230A2D0 0x000000018230AFE0-0x000000018230B090

	// Constructors
	public ConfigActionPanelState() {} // 0x000000018230B130-0x000000018230B190

	// Methods
	// [XID] // 0x0000000189A98300-0x0000000189A98320
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018230AD90-0x000000018230AEA0
	// [XID] // 0x0000000189A9F6D0-0x0000000189A9F6F0
	public void InitEmpty() {} // 0x000000018230A650-0x000000018230A740
	[BlackList] // 0x0000000189AA6FA0-0x0000000189AA6FE0
	// [XID] // 0x0000000189AA6FA0-0x0000000189AA6FE0
	public bool FromJson(JSONNode node) => default; // 0x000000018230A2D0-0x000000018230A650
	// [XID] // 0x0000000189AB1A60-0x0000000189AB1A80
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001823097E0-0x0000000182309AB0
	// [XID] // 0x0000000189AB8CE0-0x0000000189AB8D00
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAD13 */, bool useObjectPool = false /* Metadata: 0x00AFAD17 */) => default; // 0x000000018230A740-0x000000018230AA40
	// [XID] // 0x0000000189AC0870-0x0000000189AC0890
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAD18 */, bool useObjectPool = false /* Metadata: 0x00AFAD1C */) => default; // 0x0000000182309F60-0x000000018230A230
	[BlackList] // 0x0000000189AC8230-0x0000000189AC8270
	// [XID] // 0x0000000189AC8230-0x0000000189AC8270
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182309AB0-0x0000000182309D80
	// [XID] // 0x0000000189AD2D00-0x0000000189AD2D20
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018230AAF0-0x000000018230AD90
	[BlackList] // 0x0000000189ADA720-0x0000000189ADA760
	// [XID] // 0x0000000189ADA720-0x0000000189ADA760
	public virtual void AutoAllocTypeFields() {} // 0x0000000182309D80-0x0000000182309E20
	[BlackList] // 0x0000000189AE53A0-0x0000000189AE53E0
	// [XID] // 0x0000000189AE53A0-0x0000000189AE53E0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182309E20-0x0000000182309EC0
	[BlackList] // 0x0000000189AEFE00-0x0000000189AEFE40
	// [XID] // 0x0000000189AEFE00-0x0000000189AEFE40
	public virtual void ReturnToObjectPool() {} // 0x000000018230B090-0x000000018230B130
	[BlackList] // 0x0000000189AFA4C0-0x0000000189AFA500
	// [XID] // 0x0000000189AFA4C0-0x0000000189AFA500
	public virtual void OnPoolAllocated() {} // 0x000000018230AF40-0x000000018230AFE0
	[BlackList] // 0x0000000189B04700-0x0000000189B04740
	// [XID] // 0x0000000189B04700-0x0000000189B04740
	public virtual void OnBeforePoolRecycled() {} // 0x000000018230AEA0-0x000000018230AF40
}

