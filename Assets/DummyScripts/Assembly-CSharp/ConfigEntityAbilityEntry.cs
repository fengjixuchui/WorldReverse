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
public class ConfigEntityAbilityEntry : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 16865
{
	// Fields
	private string _abilityID; // 0x10
	private string _abilityName; // 0x18
	private string _abilityOverride; // 0x20

	// Properties
	public string abilityID { /* [XID] */ /* 0x00000001896FA370-0x00000001896FA390 */ get => default; /* [XID] */ /* 0x0000000189701AE0-0x0000000189701B00 */ private set {} } // 0x00000001835CBE10-0x00000001835CBEB0 0x00000001835CCA10-0x00000001835CCAC0
	public string abilityName { /* [XID] */ /* 0x000000018978A000-0x000000018978A020 */ get => default; /* [XID] */ /* 0x0000000189710CD0-0x0000000189710CF0 */ private set {} } // 0x00000001835CC970-0x00000001835CCA10 0x00000001835CCED0-0x00000001835CCF80
	public string abilityOverride { /* [XID] */ /* 0x0000000189717FD0-0x0000000189717FF0 */ get => default; /* [XID] */ /* 0x000000018971F9D0-0x000000018971F9F0 */ private set {} } // 0x00000001835CCAC0-0x00000001835CCB60 0x00000001835CCB60-0x00000001835CCC10

	// Constructors
	public ConfigEntityAbilityEntry() {} // 0x00000001835CD280-0x00000001835CD2E0

	// Methods
	// [XID] // 0x0000000189727020-0x0000000189727040
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001835CCF80-0x00000001835CD0A0
	// [XID] // 0x000000018972E570-0x000000018972E590
	public void InitEmpty() {} // 0x00000001835CC580-0x00000001835CC670
	[BlackList] // 0x0000000189735D20-0x0000000189735D60
	// [XID] // 0x0000000189735D20-0x0000000189735D60
	public bool FromJson(JSONNode node) => default; // 0x00000001835CC200-0x00000001835CC580
	// [XID] // 0x0000000189740B60-0x0000000189740B80
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001835CB650-0x00000001835CB9F0
	// [XID] // 0x0000000189747F80-0x0000000189747FA0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5BC9 */, bool useObjectPool = false /* Metadata: 0x00AF5BCD */) => default; // 0x00000001835CC670-0x00000001835CC970
	// [XID] // 0x000000018974F6D0-0x000000018974F6F0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5BCE */, bool useObjectPool = false /* Metadata: 0x00AF5BD2 */) => default; // 0x00000001835CBEB0-0x00000001835CC200
	[BlackList] // 0x0000000189756D20-0x0000000189756D60
	// [XID] // 0x0000000189756D20-0x0000000189756D60
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001835CB9F0-0x00000001835CBCC0
	// [XID] // 0x00000001897615B0-0x00000001897615D0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001835CCC10-0x00000001835CCED0
	[BlackList] // 0x00000001897688C0-0x0000000189768900
	// [XID] // 0x00000001897688C0-0x0000000189768900
	public virtual void AutoAllocTypeFields() {} // 0x00000001835CBCC0-0x00000001835CBD60
	[BlackList] // 0x0000000189773060-0x00000001897730A0
	// [XID] // 0x0000000189773060-0x00000001897730A0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001835CBD60-0x00000001835CBE10
	[BlackList] // 0x000000018977D960-0x000000018977D9A0
	// [XID] // 0x000000018977D960-0x000000018977D9A0
	public virtual void ReturnToObjectPool() {} // 0x00000001835CD1E0-0x00000001835CD280
	[BlackList] // 0x0000000189787FE0-0x0000000189788020
	// [XID] // 0x0000000189787FE0-0x0000000189788020
	public virtual void OnPoolAllocated() {} // 0x00000001835CD140-0x00000001835CD1E0
	[BlackList] // 0x00000001897926A0-0x00000001897926E0
	// [XID] // 0x00000001897926A0-0x00000001897926E0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001835CD0A0-0x00000001835CD140
}

