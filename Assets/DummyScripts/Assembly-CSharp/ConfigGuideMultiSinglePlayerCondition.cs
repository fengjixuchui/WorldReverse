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
public class ConfigGuideMultiSinglePlayerCondition : ConfigGuideCondition, IAutoAllocRecycle // TypeDefIndex: 18242
{
	// Fields
	private bool _isIn; // 0x20
	private NotifyTypes[] _curNotifyList; // 0x28

	// Properties
	public bool isIn { /* [XID] */ /* 0x0000000189AC5610-0x0000000189AC5630 */ get => default; /* [XID] */ /* 0x0000000189ACCA00-0x0000000189ACCA20 */ private set {} } // 0x000000018457CF30-0x000000018457CFD0 0x000000018457B700-0x000000018457B7B0

	// Constructors
	public ConfigGuideMultiSinglePlayerCondition() {} // 0x000000018457D360-0x000000018457D420

	// Methods
	// [XID] // 0x0000000189AD47E0-0x0000000189AD4800
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018457D1D0-0x000000018457D2C0
	// [XID] // 0x0000000189ADC0E0-0x0000000189ADC100
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018457CE00-0x000000018457CEB0
	// [XID] // 0x0000000189AE3AD0-0x0000000189AE3AF0
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF9153 */) => default; // 0x000000018457CA10-0x000000018457CAF0
	// [XID] // 0x0000000189AEB350-0x0000000189AEB370
	public override int GetHashNum() => default; // 0x000000018457B630-0x000000018457B700
	// [XID] // 0x0000000189AF2CD0-0x0000000189AF2CF0
	public override void InitEmpty() {} // 0x000000018457C4A0-0x000000018457C540
	[BlackList] // 0x0000000189AFA580-0x0000000189AFA5C0
	// [XID] // 0x0000000189AFA580-0x0000000189AFA5C0
	public override bool FromJson(JSONNode node) => default; // 0x000000018457BC80-0x000000018457C000
	// [XID] // 0x0000000189B048E0-0x0000000189B04900
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018457AEF0-0x000000018457B0F0
	[BlackList] // 0x0000000189B0C0F0-0x0000000189B0C130
	// [XID] // 0x0000000189B0C0F0-0x0000000189B0C130
	public static new ConfigGuideMultiSinglePlayerCondition ParseFromJson(JSONNode node) => default; // 0x000000018457CB50-0x000000018457CDA0
	// [XID] // 0x0000000189B16410-0x0000000189B16430
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9154 */, bool useObjectPool = false /* Metadata: 0x00AF9158 */) => default; // 0x000000018457C710-0x000000018457CA10
	// [XID] // 0x0000000189B1DB10-0x0000000189B1DB30
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9159 */, bool useObjectPool = false /* Metadata: 0x00AF915D */) => default; // 0x000000018457B890-0x000000018457BAC0
	// [XID] // 0x0000000189B25320-0x0000000189B25340
	public static new ConfigGuideMultiSinglePlayerCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF915E */, bool useObjectPool = false /* Metadata: 0x00AF9162 */) => default; // 0x000000018457C000-0x000000018457C220
	[BlackList] // 0x0000000189B2C870-0x0000000189B2C8B0
	// [XID] // 0x0000000189B2C870-0x0000000189B2C8B0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018457B0F0-0x000000018457B3C0
	// [XID] // 0x0000000189B36DF0-0x0000000189B36E10
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018457CFD0-0x000000018457D1D0
	[BlackList] // 0x0000000189B3E680-0x0000000189B3E6C0
	// [XID] // 0x0000000189B3E680-0x0000000189B3E6C0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018457C620-0x000000018457C710
	// [XID] // 0x0000000189B492E0-0x0000000189B49300
	protected override bool Prepare(GuideManager manager) => default; // 0x000000018457BBC0-0x000000018457BC80
	// [XID] // 0x0000000189B508C0-0x0000000189B508E0
	public override bool Ready(object body = null) => default; // 0x000000018457C290-0x000000018457C420
	[BlackList] // 0x0000000189B581C0-0x0000000189B58200
	// [XID] // 0x0000000189B581C0-0x0000000189B58200
	public override void AutoAllocTypeFields() {} // 0x000000018457B3C0-0x000000018457B460
	[BlackList] // 0x0000000189B62450-0x0000000189B62490
	// [XID] // 0x0000000189B62450-0x0000000189B62490
	public override void AutoRecycleTypeFields() {} // 0x000000018457B460-0x000000018457B510
	[BlackList] // 0x0000000189B6CCC0-0x0000000189B6CD00
	// [XID] // 0x0000000189B6CCC0-0x0000000189B6CD00
	public override void ReturnToObjectPool() {} // 0x000000018457D2C0-0x000000018457D360
}

