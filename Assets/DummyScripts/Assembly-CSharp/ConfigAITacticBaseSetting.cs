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

[RecycleType] // 0x00000001898422C0-0x00000001898422E0
public class ConfigAITacticBaseSetting : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17415
{
	// Fields
	private bool _enable; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAITacticCondition _condition; // 0x18
	private NeuronName[] _nerveTrigger; // 0x20
	public static Action<ConfigAITacticBaseSetting, bool> postProcessData; // 0x00
	public static Action<ConfigAITacticBaseSetting> postInitEmpty; // 0x08

	// Properties
	public bool enable { /* [XID] */ /* 0x0000000189756BE0-0x0000000189756C00 */ get => default; /* [XID] */ /* 0x000000018975E0D0-0x000000018975E0F0 */ set {} } // 0x00000001837E4AD0-0x00000001837E4B70 0x00000001837E56A0-0x00000001837E5750
	public ConfigAITacticCondition condition { /* [XID] */ /* 0x0000000189765810-0x0000000189765830 */ get => default; /* [XID] */ /* 0x000000018976D060-0x000000018976D080 */ private set {} } // 0x00000001837E4580-0x00000001837E4620 0x00000001837E4A20-0x00000001837E4AD0
	public NeuronName[] nerveTrigger { /* [XID] */ /* 0x0000000189A7F120-0x0000000189A7F140 */ get => default; /* [XID] */ /* 0x000000018977BF20-0x000000018977BF40 */ private set {} } // 0x00000001837E5DA0-0x00000001837E5E40 0x00000001837E53F0-0x00000001837E54A0

	// Constructors
	public ConfigAITacticBaseSetting() {} // 0x00000001837E5F50-0x00000001837E5FC0
	static ConfigAITacticBaseSetting() {} // 0x00000001837E5EE0-0x00000001837E5F50

	// Methods
	// [XID] // 0x00000001897837B0-0x00000001897837D0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001837E5B50-0x00000001837E5C60
	// [XID] // 0x000000018978AF40-0x000000018978AF60
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001837E5750-0x00000001837E5840
	// [XID] // 0x00000001897924C0-0x00000001897924E0
	public virtual ConfigAITacticBaseSetting Clone(bool useObjectPool = false /* Metadata: 0x00AF6DD1 */) => default; // 0x00000001837E5310-0x00000001837E53F0
	// [XID] // 0x0000000189799AF0-0x0000000189799B10
	public virtual int GetHashNum() => default; // 0x00000001837E4150-0x00000001837E4220
	// [XID] // 0x00000001897A1960-0x00000001897A1980
	public virtual void InitEmpty() {} // 0x00000001837E4D40-0x00000001837E4EA0
	[BlackList] // 0x00000001897A9240-0x00000001897A9280
	// [XID] // 0x00000001897A9240-0x00000001897A9280
	public virtual bool FromJson(JSONNode node) => default; // 0x00000001837E4620-0x00000001837E4A20
	// [XID] // 0x00000001897B4030-0x00000001897B4050
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001837E3910-0x00000001837E3CB0
	[BlackList] // 0x00000001897BBD50-0x00000001897BBD90
	// [XID] // 0x00000001897BBD50-0x00000001897BBD90
	public static ConfigAITacticBaseSetting ParseFromJson(JSONNode node) => default; // 0x00000001837E54A0-0x00000001837E56A0
	// [XID] // 0x00000001897C6680-0x00000001897C66A0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6DD2 */, bool useObjectPool = false /* Metadata: 0x00AF6DD6 */) => default; // 0x00000001837E4F90-0x00000001837E5310
	// [XID] // 0x00000001897CDEE0-0x00000001897CDF00
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6DD7 */, bool useObjectPool = false /* Metadata: 0x00AF6DDB */) => default; // 0x00000001837E4220-0x00000001837E4580
	// [XID] // 0x00000001897D5410-0x00000001897D5430
	public static ConfigAITacticBaseSetting ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6DDC */, bool useObjectPool = false /* Metadata: 0x00AF6DE0 */) => default; // 0x00000001837E4B70-0x00000001837E4D40
	[BlackList] // 0x00000001897DCB30-0x00000001897DCB70
	// [XID] // 0x00000001897DCB30-0x00000001897DCB70
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x00000001837E3CB0-0x00000001837E3F80
	// [XID] // 0x00000001897E72B0-0x00000001897E72D0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001837E5840-0x00000001837E5B50
	[BlackList] // 0x00000001897EEFB0-0x00000001897EEFF0
	// [XID] // 0x00000001897EEFB0-0x00000001897EEFF0
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001837E4EA0-0x00000001837E4F90
	// [XID] // 0x00000001897F99C0-0x00000001897F99E0
	public virtual void OnPoolAllocated() {} // 0x00000001837E5D00-0x00000001837E5DA0
	[BlackList] // 0x0000000189800F40-0x0000000189800F80
	// [XID] // 0x0000000189800F40-0x0000000189800F80
	public virtual void OnBeforePoolRecycled() {} // 0x00000001837E5C60-0x00000001837E5D00
	[BlackList] // 0x000000018980B440-0x000000018980B480
	// [XID] // 0x000000018980B440-0x000000018980B480
	public virtual void AutoAllocTypeFields() {} // 0x00000001837E3F80-0x00000001837E4020
	[BlackList] // 0x0000000189815D90-0x0000000189815DD0
	// [XID] // 0x0000000189815D90-0x0000000189815DD0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001837E4020-0x00000001837E4150
	[BlackList] // 0x0000000189820850-0x0000000189820890
	// [XID] // 0x0000000189820850-0x0000000189820890
	public virtual void ReturnToObjectPool() {} // 0x00000001837E5E40-0x00000001837E5EE0
}

