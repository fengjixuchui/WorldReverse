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
public class ConfigMusicFixedTimeTransitions : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18744
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigMusicTransitions _transitions; // 0x10
	private SimpleSafeFloat fixedTimeRawNum; // 0x18

	// Properties
	public ConfigMusicTransitions transitions { /* [XID] */ /* 0x0000000189B31C30-0x0000000189B31C50 */ get => default; /* [XID] */ /* 0x00000001896D1FE0-0x00000001896D2000 */ private set {} } // 0x000000018124FD80-0x000000018124FE20 0x000000018124F800-0x000000018124F8B0
	public float fixedTime { /* [XID] */ /* 0x00000001896D9850-0x00000001896D9870 */ get => default; /* [XID] */ /* 0x00000001896E0F70-0x00000001896E0F90 */ private set {} } // 0x0000000181250110-0x00000001812501F0 0x000000018124F3F0-0x000000018124F4D0

	// Constructors
	public ConfigMusicFixedTimeTransitions() {} // 0x0000000181250FC0-0x0000000181251020

	// Methods
	// [XID] // 0x00000001896E81E0-0x00000001896E8200
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181250CC0-0x0000000181250DE0
	// [XID] // 0x00000001896EF8C0-0x00000001896EF8E0
	public void InitEmpty() {} // 0x0000000181250570-0x0000000181250670
	[BlackList] // 0x00000001896F7210-0x00000001896F7250
	// [XID] // 0x00000001896F7210-0x00000001896F7250
	public bool FromJson(JSONNode node) => default; // 0x00000001812501F0-0x0000000181250570
	// [XID] // 0x00000001897017A0-0x00000001897017C0
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018124F4D0-0x000000018124F800
	// [XID] // 0x0000000189708F60-0x0000000189708F80
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAAB9 */, bool useObjectPool = false /* Metadata: 0x00AFAABD */) => default; // 0x0000000181250670-0x0000000181250970
	// [XID] // 0x00000001897108B0-0x00000001897108D0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAABE */, bool useObjectPool = false /* Metadata: 0x00AFAAC2 */) => default; // 0x000000018124FE20-0x0000000181250110
	[BlackList] // 0x0000000189717C30-0x0000000189717C70
	// [XID] // 0x0000000189717C30-0x0000000189717C70
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018124F8B0-0x000000018124FB80
	// [XID] // 0x0000000189722300-0x0000000189722320
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181250A50-0x0000000181250CC0
	// [XID] // 0x0000000189729A60-0x0000000189729A80
	public void BuildGameParamMask(IKeyValueLookup<int, ConfigMusicCondition> conditionLookup) {} // 0x0000000181250970-0x0000000181250A50
	[BlackList] // 0x0000000189731160-0x00000001897311A0
	// [XID] // 0x0000000189731160-0x00000001897311A0
	public virtual void AutoAllocTypeFields() {} // 0x000000018124FB80-0x000000018124FC20
	[BlackList] // 0x000000018973B8D0-0x000000018973B910
	// [XID] // 0x000000018973B8D0-0x000000018973B910
	public virtual void AutoRecycleTypeFields() {} // 0x000000018124FC20-0x000000018124FD80
	[BlackList] // 0x0000000189746200-0x0000000189746240
	// [XID] // 0x0000000189746200-0x0000000189746240
	public virtual void ReturnToObjectPool() {} // 0x0000000181250F20-0x0000000181250FC0
	[BlackList] // 0x00000001897509A0-0x00000001897509E0
	// [XID] // 0x00000001897509A0-0x00000001897509E0
	public virtual void OnPoolAllocated() {} // 0x0000000181250E80-0x0000000181250F20
	[BlackList] // 0x000000018975AE40-0x000000018975AE80
	// [XID] // 0x000000018975AE40-0x000000018975AE80
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181250DE0-0x0000000181250E80
}

