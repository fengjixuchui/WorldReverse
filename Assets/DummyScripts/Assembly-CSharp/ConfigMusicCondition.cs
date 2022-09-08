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
using MoleMole.Audio.Music.Miiha;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigMusicCondition : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18644
{
	// Fields
	private SimpleSafeInt32 idRawNum; // 0x10

	// Properties
	public int id { /* [XID] */ /* 0x00000001897DB430-0x00000001897DB450 */ get => default; /* [XID] */ /* 0x00000001897E2AE0-0x00000001897E2B00 */ private set {} } // 0x0000000183799790-0x0000000183799860 0x0000000183798B30-0x0000000183798C10

	// Constructors
	public ConfigMusicCondition() {} // 0x0000000183799900-0x0000000183799960

	// Methods
	// [XID] // 0x00000001897EA280-0x00000001897EA2A0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183799570-0x0000000183799650
	// [XID] // 0x00000001897F1EF0-0x00000001897F1F10
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001837992E0-0x0000000183799390
	// [XID] // 0x00000001897F97C0-0x00000001897F97E0
	public virtual ConfigMusicCondition Clone(bool useObjectPool = false /* Metadata: 0x00AFA78B */) => default; // 0x0000000183799000-0x00000001837990E0
	// [XID] // 0x0000000189800CE0-0x0000000189800D00
	public virtual int GetHashNum() => default; // 0x0000000183798180-0x0000000183798250
	// [XID] // 0x0000000189808260-0x0000000189808280
	public virtual void InitEmpty() {} // 0x0000000183798A60-0x0000000183798B30
	[BlackList] // 0x000000018980FC30-0x000000018980FC70
	// [XID] // 0x000000018980FC30-0x000000018980FC70
	public virtual bool FromJson(JSONNode node) => default; // 0x0000000183798510-0x0000000183798890
	// [XID] // 0x000000018981A580-0x000000018981A5A0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183797A50-0x0000000183797C70
	[BlackList] // 0x0000000189821CF0-0x0000000189821D30
	// [XID] // 0x0000000189821CF0-0x0000000189821D30
	public static ConfigMusicCondition ParseFromJson(JSONNode node) => default; // 0x00000001837990E0-0x00000001837992E0
	// [XID] // 0x000000018982C3F0-0x000000018982C410
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA78C */, bool useObjectPool = false /* Metadata: 0x00AFA790 */) => default; // 0x0000000183798D00-0x0000000183799000
	// [XID] // 0x00000001898338C0-0x00000001898338E0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA791 */, bool useObjectPool = false /* Metadata: 0x00AFA795 */) => default; // 0x0000000183798300-0x0000000183798510
	// [XID] // 0x000000018983AE00-0x000000018983AE20
	public static ConfigMusicCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA796 */, bool useObjectPool = false /* Metadata: 0x00AFA79A */) => default; // 0x0000000183798890-0x0000000183798A60
	[BlackList] // 0x0000000189842480-0x00000001898424C0
	// [XID] // 0x0000000189842480-0x00000001898424C0
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x0000000183797C70-0x0000000183797F40
	// [XID] // 0x000000018984C8E0-0x000000018984C900
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183799390-0x0000000183799570
	[BlackList] // 0x0000000189853A00-0x0000000189853A40
	// [XID] // 0x0000000189853A00-0x0000000189853A40
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183798C10-0x0000000183798D00
	// [XID] // 0x000000018985DC10-0x000000018985DC30
	public virtual MusicGameParam GetMusicGameParam(IKeyValueLookup<int, ConfigMusicCondition> conditionLookup) => default; // 0x0000000183798250-0x0000000183798300
	// [XID] // 0x00000001899CADB0-0x00000001899CADD0
	public virtual bool IsMet(IKeyValueLookup<int, ConfigMusicCondition> conditionLookup, IGameParamLookup<MusicGameParam> paramLookup) => default; // 0x00000001837980B0-0x0000000183798180
	[BlackList] // 0x000000018986CAD0-0x000000018986CB10
	// [XID] // 0x000000018986CAD0-0x000000018986CB10
	public virtual void AutoAllocTypeFields() {} // 0x0000000183797F40-0x0000000183797FE0
	[BlackList] // 0x0000000189877130-0x0000000189877170
	// [XID] // 0x0000000189877130-0x0000000189877170
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183797FE0-0x00000001837980B0
	[BlackList] // 0x00000001898817C0-0x0000000189881800
	// [XID] // 0x00000001898817C0-0x0000000189881800
	public virtual void ReturnToObjectPool() {} // 0x0000000183799860-0x0000000183799900
	[BlackList] // 0x000000018988BBE0-0x000000018988BC20
	// [XID] // 0x000000018988BBE0-0x000000018988BC20
	public virtual void OnPoolAllocated() {} // 0x00000001837996F0-0x0000000183799790
	[BlackList] // 0x0000000189895E40-0x0000000189895E80
	// [XID] // 0x0000000189895E40-0x0000000189895E80
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183799650-0x00000001837996F0
}

