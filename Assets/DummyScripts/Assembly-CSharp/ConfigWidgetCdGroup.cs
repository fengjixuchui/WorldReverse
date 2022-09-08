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
public class ConfigWidgetCdGroup : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19191
{
	// Fields
	private bool _isUnderTimeScale; // 0x10
	private SimpleSafeUInt32 coolDownSuccessRawNum; // 0x14
	private SimpleSafeUInt32 coolDownFailRawNum; // 0x18

	// Properties
	public bool isUnderTimeScale { /* [XID] */ /* 0x00000001896E3E30-0x00000001896E3E50 */ get => default; /* [XID] */ /* 0x00000001896EB1E0-0x00000001896EB200 */ private set {} } // 0x0000000183C64110-0x0000000183C641B0 0x0000000183C64A20-0x0000000183C64AD0
	public uint coolDownSuccess { /* [XID] */ /* 0x00000001896F25B0-0x00000001896F25D0 */ get => default; /* [XID] */ /* 0x00000001896F9F30-0x00000001896F9F50 */ private set {} } // 0x0000000183C65500-0x0000000183C655D0 0x0000000183C64AD0-0x0000000183C64BB0
	public uint coolDownFail { /* [XID] */ /* 0x0000000189701600-0x0000000189701620 */ get => default; /* [XID] */ /* 0x0000000189708E40-0x0000000189708E60 */ private set {} } // 0x0000000183C651D0-0x0000000183C652A0 0x0000000183C644E0-0x0000000183C645C0

	// Constructors
	public ConfigWidgetCdGroup() {} // 0x0000000183C65670-0x0000000183C656D0

	// Methods
	// [XID] // 0x0000000189710730-0x0000000189710750
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183C652A0-0x0000000183C653C0
	// [XID] // 0x0000000189717B30-0x0000000189717B50
	public void InitEmpty() {} // 0x0000000183C64940-0x0000000183C64A20
	[BlackList] // 0x000000018971F610-0x000000018971F650
	// [XID] // 0x000000018971F610-0x000000018971F650
	public bool FromJson(JSONNode node) => default; // 0x0000000183C645C0-0x0000000183C64940
	// [XID] // 0x0000000189729980-0x00000001897299A0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183C638D0-0x0000000183C63CC0
	// [XID] // 0x0000000189731100-0x0000000189731120
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC4D3 */, bool useObjectPool = false /* Metadata: 0x00AFC4D7 */) => default; // 0x0000000183C64BB0-0x0000000183C64EB0
	// [XID] // 0x00000001897389F0-0x0000000189738A10
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC4D8 */, bool useObjectPool = false /* Metadata: 0x00AFC4DC */) => default; // 0x0000000183C641B0-0x0000000183C644E0
	[BlackList] // 0x0000000189740740-0x0000000189740780
	// [XID] // 0x0000000189740740-0x0000000189740780
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183C63CC0-0x0000000183C63F90
	// [XID] // 0x000000018974AF20-0x000000018974AF40
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183C64EB0-0x0000000183C651D0
	[BlackList] // 0x0000000189752010-0x0000000189752050
	// [XID] // 0x0000000189752010-0x0000000189752050
	public virtual void AutoAllocTypeFields() {} // 0x0000000183C63F90-0x0000000183C64030
	[BlackList] // 0x000000018975C4B0-0x000000018975C4F0
	// [XID] // 0x000000018975C4B0-0x000000018975C4F0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183C64030-0x0000000183C64110
	[BlackList] // 0x0000000189766DE0-0x0000000189766E20
	// [XID] // 0x0000000189766DE0-0x0000000189766E20
	public virtual void ReturnToObjectPool() {} // 0x0000000183C655D0-0x0000000183C65670
	[BlackList] // 0x0000000189771550-0x0000000189771590
	// [XID] // 0x0000000189771550-0x0000000189771590
	public virtual void OnPoolAllocated() {} // 0x0000000183C65460-0x0000000183C65500
	[BlackList] // 0x000000018977BAA0-0x000000018977BAE0
	// [XID] // 0x000000018977BAA0-0x000000018977BAE0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183C653C0-0x0000000183C65460
}

