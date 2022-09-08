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
public class ConfigWidgetWaterSprite : ConfigBaseWidget, IAutoAllocRecycle // TypeDefIndex: 19153
{
	// Fields
	private string _abilityGroupName; // 0x30
	private string _abilityTriggerName; // 0x38
	private string _abilityTriggerNameSecond; // 0x40

	// Properties
	public string abilityGroupName { /* [XID] */ /* 0x000000018995EFB0-0x000000018995EFD0 */ get => default; /* [XID] */ /* 0x00000001899667F0-0x0000000189966810 */ private set {} } // 0x0000000181E9B340-0x0000000181E9B3E0 0x0000000181E9A0D0-0x0000000181E9A180
	public string abilityTriggerName { /* [XID] */ /* 0x000000018996DC40-0x000000018996DC60 */ get => default; /* [XID] */ /* 0x0000000189975890-0x00000001899758B0 */ private set {} } // 0x0000000181E99BB0-0x0000000181E99C50 0x0000000181E9AB60-0x0000000181E9AC10
	public string abilityTriggerNameSecond { /* [XID] */ /* 0x000000018997C930-0x000000018997C950 */ get => default; /* [XID] */ /* 0x0000000189984730-0x0000000189984750 */ private set {} } // 0x0000000181E9B050-0x0000000181E9B0F0 0x0000000181E9B860-0x0000000181E9B910

	// Constructors
	public ConfigWidgetWaterSprite() {} // 0x0000000181E9BAE0-0x0000000181E9BB40

	// Methods
	// [XID] // 0x000000018998C150-0x000000018998C170
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181E9B910-0x0000000181E9BA40
	// [XID] // 0x0000000189993E90-0x0000000189993EB0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181E9B440-0x0000000181E9B550
	// [XID] // 0x000000018999B6C0-0x000000018999B6E0
	public override ConfigBaseWidget Clone(bool useObjectPool = false /* Metadata: 0x00AFC38D */) => default; // 0x0000000181E9AF10-0x0000000181E9AFF0
	// [XID] // 0x00000001899A2DB0-0x00000001899A2DD0
	public override int GetHashNum() => default; // 0x0000000181E99AE0-0x0000000181E99BB0
	// [XID] // 0x00000001899AA920-0x00000001899AA940
	public override void InitEmpty() {} // 0x0000000181E9A890-0x0000000181E9A990
	[BlackList] // 0x00000001899B22B0-0x00000001899B22F0
	// [XID] // 0x00000001899B22B0-0x00000001899B22F0
	public override bool FromJson(JSONNode node) => default; // 0x0000000181E9A280-0x0000000181E9A600
	// [XID] // 0x00000001899BC790-0x00000001899BC7B0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181E991B0-0x0000000181E995A0
	[BlackList] // 0x00000001899C4140-0x00000001899C4180
	// [XID] // 0x00000001899C4140-0x00000001899C4180
	public static new ConfigWidgetWaterSprite ParseFromJson(JSONNode node) => default; // 0x0000000181E9B0F0-0x0000000181E9B340
	// [XID] // 0x00000001899CE760-0x00000001899CE780
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC38E */, bool useObjectPool = false /* Metadata: 0x00AFC392 */) => default; // 0x0000000181E9AC10-0x0000000181E9AF10
	// [XID] // 0x00000001899D5DF0-0x00000001899D5E10
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC393 */, bool useObjectPool = false /* Metadata: 0x00AFC397 */) => default; // 0x0000000181E99D30-0x0000000181E9A0D0
	// [XID] // 0x00000001899DD300-0x00000001899DD320
	public static new ConfigWidgetWaterSprite ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC398 */, bool useObjectPool = false /* Metadata: 0x00AFC39C */) => default; // 0x0000000181E9A600-0x0000000181E9A820
	[BlackList] // 0x00000001899E4EE0-0x00000001899E4F20
	// [XID] // 0x00000001899E4EE0-0x00000001899E4F20
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181E995A0-0x0000000181E99870
	// [XID] // 0x00000001899EF310-0x00000001899EF330
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181E9B550-0x0000000181E9B860
	[BlackList] // 0x00000001899F6C70-0x00000001899F6CB0
	// [XID] // 0x00000001899F6C70-0x00000001899F6CB0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181E9AA70-0x0000000181E9AB60
	[BlackList] // 0x0000000189A00EB0-0x0000000189A00EF0
	// [XID] // 0x0000000189A00EB0-0x0000000189A00EF0
	public override void AutoAllocTypeFields() {} // 0x0000000181E99870-0x0000000181E99910
	[BlackList] // 0x0000000189A0B770-0x0000000189A0B7B0
	// [XID] // 0x0000000189A0B770-0x0000000189A0B7B0
	public override void AutoRecycleTypeFields() {} // 0x0000000181E99910-0x0000000181E999C0
	[BlackList] // 0x0000000189A15D80-0x0000000189A15DC0
	// [XID] // 0x0000000189A15D80-0x0000000189A15DC0
	public override void ReturnToObjectPool() {} // 0x0000000181E9BA40-0x0000000181E9BAE0
}

