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
public class ConfigAudioEventCullingRuleBase : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17571
{
	// Constructors
	public ConfigAudioEventCullingRuleBase() {} // 0x0000000185082C50-0x0000000185082CB0

	// Methods
	// [XID] // 0x0000000189778FE0-0x0000000189779000
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001850829C0-0x0000000185082A70
	// [XID] // 0x00000001897806E0-0x0000000189780700
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000185082860-0x0000000185082910
	// [XID] // 0x0000000189787EC0-0x0000000189787EE0
	public virtual ConfigAudioEventCullingRuleBase Clone(bool useObjectPool = false /* Metadata: 0x00AF734B */) => default; // 0x0000000185082580-0x0000000185082660
	// [XID] // 0x000000018978F480-0x000000018978F4A0
	public virtual int GetHashNum() => default; // 0x00000001850819F0-0x0000000185081AC0
	// [XID] // 0x0000000189796C50-0x0000000189796C70
	public virtual void InitEmpty() {} // 0x00000001850820F0-0x0000000185082190
	[BlackList] // 0x000000018979ED70-0x000000018979EDB0
	// [XID] // 0x000000018979ED70-0x000000018979EDB0
	public virtual bool FromJson(JSONNode node) => default; // 0x0000000185081BA0-0x0000000185081F20
	// [XID] // 0x00000001897A9180-0x00000001897A91A0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000185081530-0x00000001850815E0
	[BlackList] // 0x00000001897B09E0-0x00000001897B0A20
	// [XID] // 0x00000001897B09E0-0x00000001897B0A20
	public static ConfigAudioEventCullingRuleBase ParseFromJson(JSONNode node) => default; // 0x0000000185082660-0x0000000185082860
	// [XID] // 0x00000001897BBC70-0x00000001897BBC90
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF734C */, bool useObjectPool = false /* Metadata: 0x00AF7350 */) => default; // 0x0000000185082280-0x0000000185082580
	// [XID] // 0x00000001897C34B0-0x00000001897C34D0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7351 */, bool useObjectPool = false /* Metadata: 0x00AF7355 */) => default; // 0x0000000185081AC0-0x0000000185081BA0
	// [XID] // 0x00000001897CACD0-0x00000001897CACF0
	public static ConfigAudioEventCullingRuleBase ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7356 */, bool useObjectPool = false /* Metadata: 0x00AF735A */) => default; // 0x0000000185081F20-0x00000001850820F0
	[BlackList] // 0x00000001897D2310-0x00000001897D2350
	// [XID] // 0x00000001897D2310-0x00000001897D2350
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x00000001850815E0-0x00000001850818B0
	// [XID] // 0x00000001897DCA90-0x00000001897DCAB0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000185082910-0x00000001850829C0
	[BlackList] // 0x00000001897E44B0-0x00000001897E44F0
	// [XID] // 0x00000001897E44B0-0x00000001897E44F0
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000185082190-0x0000000185082280
	[BlackList] // 0x00000001897EEF30-0x00000001897EEF70
	// [XID] // 0x00000001897EEF30-0x00000001897EEF70
	public virtual void AutoAllocTypeFields() {} // 0x00000001850818B0-0x0000000185081950
	[BlackList] // 0x00000001897F9920-0x00000001897F9960
	// [XID] // 0x00000001897F9920-0x00000001897F9960
	public virtual void AutoRecycleTypeFields() {} // 0x0000000185081950-0x00000001850819F0
	[BlackList] // 0x0000000189804030-0x0000000189804070
	// [XID] // 0x0000000189804030-0x0000000189804070
	public virtual void ReturnToObjectPool() {} // 0x0000000185082BB0-0x0000000185082C50
	[BlackList] // 0x000000018980E570-0x000000018980E5B0
	// [XID] // 0x000000018980E570-0x000000018980E5B0
	public virtual void OnPoolAllocated() {} // 0x0000000185082B10-0x0000000185082BB0
	[BlackList] // 0x0000000189818FB0-0x0000000189818FF0
	// [XID] // 0x0000000189818FB0-0x0000000189818FF0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000185082A70-0x0000000185082B10
}

