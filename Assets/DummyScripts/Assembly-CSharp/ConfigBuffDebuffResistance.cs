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
public class ConfigBuffDebuffResistance : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 16850
{
	// Fields
	private AbilityState[] _ResistanceBuffDebuffs; // 0x10
	private SimpleSafeFloat ResistanceRatioRawNum; // 0x18
	private SimpleSafeFloat DurationRatioRawNum; // 0x1C

	// Properties
	public AbilityState[] ResistanceBuffDebuffs { /* [XID] */ /* 0x0000000189A5DBC0-0x0000000189A5DBE0 */ get => default; /* [XID] */ /* 0x0000000189A65340-0x0000000189A65360 */ private set {} } // 0x000000018458EE10-0x000000018458EEB0 0x000000018458FC40-0x000000018458FCF0
	public float ResistanceRatio { /* [XID] */ /* 0x0000000189A6CAA0-0x0000000189A6CAC0 */ get => default; /* [XID] */ /* 0x0000000189A741D0-0x0000000189A741F0 */ private set {} } // 0x000000018458F670-0x000000018458F750 0x000000018458FB60-0x000000018458FC40
	public float DurationRatio { /* [XID] */ /* 0x000000018976C450-0x000000018976C470 */ get => default; /* [XID] */ /* 0x0000000189A83460-0x0000000189A83480 */ private set {} } // 0x000000018458F210-0x000000018458F2F0 0x000000018458EBA0-0x000000018458EC80

	// Constructors
	public ConfigBuffDebuffResistance() {} // 0x00000001845904B0-0x0000000184590510
	public ConfigBuffDebuffResistance(List<ulong> abilityStates, float resistRatio, float durationRatio) {} // 0x0000000184590300-0x00000001845904B0

	// Methods
	// [XID] // 0x0000000189A8AD80-0x0000000189A8ADA0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184590000-0x0000000184590120
	// [XID] // 0x0000000189A924F0-0x0000000189A92510
	public void InitEmpty() {} // 0x000000018458F750-0x000000018458F860
	[BlackList] // 0x0000000189A99F40-0x0000000189A99F80
	// [XID] // 0x0000000189A99F40-0x0000000189A99F80
	public bool FromJson(JSONNode node) => default; // 0x000000018458F2F0-0x000000018458F670
	// [XID] // 0x0000000189AA43E0-0x0000000189AA4400
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018458E490-0x000000018458E8D0
	// [XID] // 0x0000000189AAB8D0-0x0000000189AAB8F0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF488E */, bool useObjectPool = false /* Metadata: 0x00AF4892 */) => default; // 0x000000018458F860-0x000000018458FB60
	// [XID] // 0x0000000189AB31E0-0x0000000189AB3200
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4893 */, bool useObjectPool = false /* Metadata: 0x00AF4897 */) => default; // 0x000000018458EEB0-0x000000018458F210
	[BlackList] // 0x0000000189ABAF10-0x0000000189ABAF50
	// [XID] // 0x0000000189ABAF10-0x0000000189ABAF50
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018458E8D0-0x000000018458EBA0
	// [XID] // 0x0000000189AC5890-0x0000000189AC58B0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018458FCF0-0x0000000184590000
	[BlackList] // 0x0000000189ACCDA0-0x0000000189ACCDE0
	// [XID] // 0x0000000189ACCDA0-0x0000000189ACCDE0
	public virtual void AutoAllocTypeFields() {} // 0x000000018458EC80-0x000000018458ED20
	[BlackList] // 0x0000000189AD7B40-0x0000000189AD7B80
	// [XID] // 0x0000000189AD7B40-0x0000000189AD7B80
	public virtual void AutoRecycleTypeFields() {} // 0x000000018458ED20-0x000000018458EE10
	[BlackList] // 0x0000000189AE2240-0x0000000189AE2280
	// [XID] // 0x0000000189AE2240-0x0000000189AE2280
	public virtual void ReturnToObjectPool() {} // 0x0000000184590260-0x0000000184590300
	[BlackList] // 0x0000000189AECBC0-0x0000000189AECC00
	// [XID] // 0x0000000189AECBC0-0x0000000189AECC00
	public virtual void OnPoolAllocated() {} // 0x00000001845901C0-0x0000000184590260
	[BlackList] // 0x0000000189AF7700-0x0000000189AF7740
	// [XID] // 0x0000000189AF7700-0x0000000189AF7740
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184590120-0x00000001845901C0
}

