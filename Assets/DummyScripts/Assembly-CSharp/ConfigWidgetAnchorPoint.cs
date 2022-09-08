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
public class ConfigWidgetAnchorPoint : ConfigBaseWidget, IAutoAllocRecycle // TypeDefIndex: 19126
{
	// Fields
	private SimpleSafeUInt32 lastingTimeRawNum; // 0x30
	private SimpleSafeUInt32 maxCountInSceneRawNum; // 0x34
	private SimpleSafeUInt32 gadgetIdRawNum; // 0x38

	// Properties
	public uint lastingTime { /* [XID] */ /* 0x000000018995A6F0-0x000000018995A710 */ get => default; /* [XID] */ /* 0x0000000189962230-0x0000000189962250 */ private set {} } // 0x0000000183887230-0x0000000183887300 0x0000000183887E80-0x0000000183887F60
	public uint maxCountInScene { /* [XID] */ /* 0x0000000189969620-0x0000000189969640 */ get => default; /* [XID] */ /* 0x0000000189971300-0x0000000189971320 */ private set {} } // 0x0000000183888BD0-0x0000000183888CA0 0x0000000183886CC0-0x0000000183886DA0
	public uint gadgetId { /* [XID] */ /* 0x0000000189978CB0-0x0000000189978CD0 */ get => default; /* [XID] */ /* 0x000000018997FD80-0x000000018997FDA0 */ private set {} } // 0x0000000183887AF0-0x0000000183887BC0 0x00000001838879A0-0x0000000183887A80

	// Constructors
	public ConfigWidgetAnchorPoint() {} // 0x0000000183888D40-0x0000000183888DA0

	// Methods
	// [XID] // 0x0000000189987610-0x0000000189987630
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183888AA0-0x0000000183888BD0
	// [XID] // 0x000000018998F220-0x000000018998F240
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183888650-0x0000000183888700
	// [XID] // 0x0000000189996BC0-0x0000000189996BE0
	public override ConfigBaseWidget Clone(bool useObjectPool = false /* Metadata: 0x00AFC2B3 */) => default; // 0x0000000183888260-0x0000000183888340
	// [XID] // 0x000000018999E890-0x000000018999E8B0
	public override int GetHashNum() => default; // 0x0000000183886BF0-0x0000000183886CC0
	// [XID] // 0x00000001899A6230-0x00000001899A6250
	public override void InitEmpty() {} // 0x0000000183887BC0-0x0000000183887CB0
	[BlackList] // 0x00000001899AD7A0-0x00000001899AD7E0
	// [XID] // 0x00000001899AD7A0-0x00000001899AD7E0
	public override bool FromJson(JSONNode node) => default; // 0x0000000183887400-0x0000000183887780
	// [XID] // 0x00000001899B7E10-0x00000001899B7E30
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001838861E0-0x0000000183886660
	[BlackList] // 0x00000001899BF9F0-0x00000001899BFA30
	// [XID] // 0x00000001899BF9F0-0x00000001899BFA30
	public static new ConfigWidgetAnchorPoint ParseFromJson(JSONNode node) => default; // 0x00000001838883A0-0x00000001838885F0
	// [XID] // 0x00000001899C9F80-0x00000001899C9FA0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC2B4 */, bool useObjectPool = false /* Metadata: 0x00AFC2B8 */) => default; // 0x0000000183887F60-0x0000000183888260
	// [XID] // 0x00000001899D1840-0x00000001899D1860
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC2B9 */, bool useObjectPool = false /* Metadata: 0x00AFC2BD */) => default; // 0x0000000183886E80-0x0000000183887230
	// [XID] // 0x00000001899D8D50-0x00000001899D8D70
	public static new ConfigWidgetAnchorPoint ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC2BE */, bool useObjectPool = false /* Metadata: 0x00AFC2C2 */) => default; // 0x0000000183887780-0x00000001838879A0
	[BlackList] // 0x00000001899E0320-0x00000001899E0360
	// [XID] // 0x00000001899E0320-0x00000001899E0360
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183886660-0x0000000183886930
	// [XID] // 0x00000001899EA9A0-0x00000001899EA9C0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183888700-0x0000000183888AA0
	[BlackList] // 0x00000001899F24E0-0x00000001899F2520
	// [XID] // 0x00000001899F24E0-0x00000001899F2520
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183887D90-0x0000000183887E80
	[BlackList] // 0x00000001899FCBB0-0x00000001899FCBF0
	// [XID] // 0x00000001899FCBB0-0x00000001899FCBF0
	public override void AutoAllocTypeFields() {} // 0x0000000183886930-0x00000001838869D0
	[BlackList] // 0x0000000189A07110-0x0000000189A07150
	// [XID] // 0x0000000189A07110-0x0000000189A07150
	public override void AutoRecycleTypeFields() {} // 0x00000001838869D0-0x0000000183886AD0
	[BlackList] // 0x0000000189A11940-0x0000000189A11980
	// [XID] // 0x0000000189A11940-0x0000000189A11980
	public override void ReturnToObjectPool() {} // 0x0000000183888CA0-0x0000000183888D40
}

