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
public class ConfigMusicParameterCondition : ConfigMusicCondition, IAutoAllocRecycle // TypeDefIndex: 18656
{
	// Fields
	private MusicGameParam _gameParam; // 0x18

	// Properties
	public MusicGameParam gameParam { /* [XID] */ /* 0x00000001896118E0-0x0000000189611900 */ get => default; /* [XID] */ /* 0x0000000189619220-0x0000000189619240 */ private set {} } // 0x0000000186574090-0x0000000186574130 0x0000000186574EA0-0x0000000186574F50

	// Constructors
	public ConfigMusicParameterCondition() {} // 0x0000000186574FF0-0x0000000186575050

	// Methods
	// [XID] // 0x00000001896207A0-0x00000001896207C0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000186574DB0-0x0000000186574EA0
	// [XID] // 0x0000000189627C90-0x0000000189627CB0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000186574B00-0x0000000186574BB0
	// [XID] // 0x000000018962F5E0-0x000000018962F600
	public override ConfigMusicCondition Clone(bool useObjectPool = false /* Metadata: 0x00AFA7EB */) => default; // 0x0000000186574710-0x00000001865747F0
	// [XID] // 0x0000000189637180-0x00000001896371A0
	public override int GetHashNum() => default; // 0x00000001865734D0-0x00000001865735A0
	// [XID] // 0x000000018963E6A0-0x000000018963E6C0
	public override void InitEmpty() {} // 0x00000001865741A0-0x0000000186574240
	[BlackList] // 0x0000000189645E00-0x0000000189645E40
	// [XID] // 0x0000000189645E00-0x0000000189645E40
	public override bool FromJson(JSONNode node) => default; // 0x0000000186573A70-0x0000000186573DF0
	// [XID] // 0x0000000189650490-0x00000001896504B0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000186572D70-0x0000000186572F90
	[BlackList] // 0x0000000189657D90-0x0000000189657DD0
	// [XID] // 0x0000000189657D90-0x0000000189657DD0
	public static new ConfigMusicParameterCondition ParseFromJson(JSONNode node) => default; // 0x0000000186574850-0x0000000186574AA0
	// [XID] // 0x0000000189662300-0x0000000189662320
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA7EC */, bool useObjectPool = false /* Metadata: 0x00AFA7F0 */) => default; // 0x0000000186574410-0x0000000186574710
	// [XID] // 0x0000000189669EE0-0x0000000189669F00
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA7F1 */, bool useObjectPool = false /* Metadata: 0x00AFA7F5 */) => default; // 0x0000000186573740-0x0000000186573970
	// [XID] // 0x0000000189671BA0-0x0000000189671BC0
	public static new ConfigMusicParameterCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA7F6 */, bool useObjectPool = false /* Metadata: 0x00AFA7FA */) => default; // 0x0000000186573E70-0x0000000186574090
	[BlackList] // 0x0000000189679390-0x00000001896793D0
	// [XID] // 0x0000000189679390-0x00000001896793D0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000186572F90-0x0000000186573260
	// [XID] // 0x0000000189683870-0x0000000189683890
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000186574BB0-0x0000000186574DB0
	[BlackList] // 0x000000018968B510-0x000000018968B550
	// [XID] // 0x000000018968B510-0x000000018968B550
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000186574320-0x0000000186574410
	// [XID] // 0x00000001896960B0-0x00000001896960D0
	public override MusicGameParam GetMusicGameParam(IKeyValueLookup<int, ConfigMusicCondition> conditionLookup) => default; // 0x00000001865735A0-0x0000000186573660
	protected virtual bool GetParamValue<TValue>(MusicGameParam gameParam, IGameParamLookup<MusicGameParam> paramLookup, out TValue value) {
		value = default;
		return default;
	}
	[BlackList] // 0x000000018969D770-0x000000018969D7B0
	// [XID] // 0x000000018969D770-0x000000018969D7B0
	public override void AutoAllocTypeFields() {} // 0x0000000186573260-0x0000000186573300
	[BlackList] // 0x00000001896A77E0-0x00000001896A7820
	// [XID] // 0x00000001896A77E0-0x00000001896A7820
	public override void AutoRecycleTypeFields() {} // 0x0000000186573300-0x00000001865733B0
	[BlackList] // 0x00000001896B1670-0x00000001896B16B0
	// [XID] // 0x00000001896B1670-0x00000001896B16B0
	public override void ReturnToObjectPool() {} // 0x0000000186574F50-0x0000000186574FF0
}

