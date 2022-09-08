/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
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
public class ConfigBuffDebuffAddition : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 16848
{
	// Fields
	private AbilityState[] _AdditionBuffDebuffs; // 0x10
	private SimpleSafeFloat AdditionRatioRawNum; // 0x18

	// Properties
	public AbilityState[] AdditionBuffDebuffs { /* [XID] */ /* 0x000000018977B0F0-0x000000018977B110 */ get => default; /* [XID] */ /* 0x000000018991F000-0x000000018991F020 */ private set {} } // 0x0000000181C95520-0x0000000181C955C0 0x0000000181C95070-0x0000000181C95120
	public float AdditionRatio { /* [XID] */ /* 0x00000001897A3C90-0x00000001897A3CB0 */ get => default; /* [XID] */ /* 0x000000018992E090-0x000000018992E0B0 */ private set {} } // 0x0000000181C956A0-0x0000000181C95780 0x0000000181C955C0-0x0000000181C956A0

	// Constructors
	public ConfigBuffDebuffAddition() {} // 0x0000000181C95CE0-0x0000000181C95D40
	public ConfigBuffDebuffAddition(AbilityState[] abilityStates, float fAdditionTime) {} // 0x0000000181C95D40-0x0000000181C95ED0

	// Methods
	// [XID] // 0x0000000189935410-0x0000000189935430
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181C959F0-0x0000000181C95B00
	// [XID] // 0x000000018993CFD0-0x000000018993CFF0
	public void InitEmpty() {} // 0x0000000181C95120-0x0000000181C95220
	[BlackList] // 0x00000001899445C0-0x0000000189944600
	// [XID] // 0x00000001899445C0-0x0000000189944600
	public bool FromJson(JSONNode node) => default; // 0x0000000181C94CF0-0x0000000181C95070
	// [XID] // 0x000000018994EBE0-0x000000018994EC00
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181C942B0-0x0000000181C945D0
	// [XID] // 0x0000000189956140-0x0000000189956160
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF487A */, bool useObjectPool = false /* Metadata: 0x00AF487E */) => default; // 0x0000000181C95220-0x0000000181C95520
	// [XID] // 0x000000018995DC70-0x000000018995DC90
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF487F */, bool useObjectPool = false /* Metadata: 0x00AF4883 */) => default; // 0x0000000181C94A20-0x0000000181C94CF0
	[BlackList] // 0x0000000189965490-0x00000001899654D0
	// [XID] // 0x0000000189965490-0x00000001899654D0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181C945D0-0x0000000181C948A0
	// [XID] // 0x000000018996F7C0-0x000000018996F7E0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181C95780-0x0000000181C959F0
	[BlackList] // 0x0000000189977460-0x00000001899774A0
	// [XID] // 0x0000000189977460-0x00000001899774A0
	public virtual void AutoAllocTypeFields() {} // 0x0000000181C948A0-0x0000000181C94940
	[BlackList] // 0x0000000189981E40-0x0000000189981E80
	// [XID] // 0x0000000189981E40-0x0000000189981E80
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181C94940-0x0000000181C94A20
	[BlackList] // 0x000000018998C4F0-0x000000018998C530
	// [XID] // 0x000000018998C4F0-0x000000018998C530
	public virtual void ReturnToObjectPool() {} // 0x0000000181C95C40-0x0000000181C95CE0
	[BlackList] // 0x0000000189996FE0-0x0000000189997020
	// [XID] // 0x0000000189996FE0-0x0000000189997020
	public virtual void OnPoolAllocated() {} // 0x0000000181C95BA0-0x0000000181C95C40
	[BlackList] // 0x00000001899A1BF0-0x00000001899A1C30
	// [XID] // 0x00000001899A1BF0-0x00000001899A1C30
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181C95B00-0x0000000181C95BA0
}

