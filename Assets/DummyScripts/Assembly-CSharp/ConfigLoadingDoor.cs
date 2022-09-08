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
public class ConfigLoadingDoor : ConfigScenePoint, IAutoAllocRecycle // TypeDefIndex: 18934
{
	// Fields
	private SimpleSafeUInt32 room1RawNum; // 0x60
	private SimpleSafeUInt32 room2RawNum; // 0x64

	// Properties
	public uint room1 { /* [XID] */ /* 0x0000000189A1F6D0-0x0000000189A1F6F0 */ get => default; /* [XID] */ /* 0x0000000189A9F6B0-0x0000000189A9F6D0 */ private set {} } // 0x000000018126B570-0x000000018126B640 0x000000018126AB50-0x000000018126AC30
	public uint room2 { /* [XID] */ /* 0x0000000189AA6F80-0x0000000189AA6FA0 */ get => default; /* [XID] */ /* 0x0000000189AAE680-0x0000000189AAE6A0 */ private set {} } // 0x0000000181269F10-0x0000000181269FE0 0x000000018126A3E0-0x000000018126A4C0

	// Constructors
	public ConfigLoadingDoor() {} // 0x000000018126BBF0-0x000000018126BC50

	// Methods
	// [XID] // 0x0000000189AB5EA0-0x0000000189AB5EC0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018126BA40-0x000000018126BB50
	// [XID] // 0x0000000189ABD990-0x0000000189ABD9B0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018126B6A0-0x000000018126B750
	// [XID] // 0x0000000189AC54B0-0x0000000189AC54D0
	public override ConfigScenePoint Clone(bool useObjectPool = false /* Metadata: 0x00AFB41B */) => default; // 0x000000018126B1E0-0x000000018126B2C0
	// [XID] // 0x0000000189ACC8E0-0x0000000189ACC900
	public override int GetHashNum() => default; // 0x0000000181269DE0-0x0000000181269EB0
	// [XID] // 0x0000000189AD4650-0x0000000189AD4670
	public override void InitEmpty() {} // 0x000000018126AC30-0x000000018126AD10
	[BlackList] // 0x0000000189ADC000-0x0000000189ADC040
	// [XID] // 0x0000000189ADC000-0x0000000189ADC040
	public override bool FromJson(JSONNode node) => default; // 0x000000018126A540-0x000000018126A8C0
	// [XID] // 0x0000000189AE6A20-0x0000000189AE6A40
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001812694E0-0x0000000181269860
	[BlackList] // 0x0000000189AEE4A0-0x0000000189AEE4E0
	// [XID] // 0x0000000189AEE4A0-0x0000000189AEE4E0
	public static new ConfigLoadingDoor ParseFromJson(JSONNode node) => default; // 0x000000018126B320-0x000000018126B570
	// [XID] // 0x0000000189AF8C20-0x0000000189AF8C40
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB41C */, bool useObjectPool = false /* Metadata: 0x00AFB420 */) => default; // 0x000000018126AEE0-0x000000018126B1E0
	// [XID] // 0x0000000189B00150-0x0000000189B00170
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB421 */, bool useObjectPool = false /* Metadata: 0x00AFB425 */) => default; // 0x000000018126A060-0x000000018126A360
	// [XID] // 0x0000000189B07710-0x0000000189B07730
	public static new ConfigLoadingDoor ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB426 */, bool useObjectPool = false /* Metadata: 0x00AFB42A */) => default; // 0x000000018126A8C0-0x000000018126AAE0
	[BlackList] // 0x0000000189B0EF30-0x0000000189B0EF70
	// [XID] // 0x0000000189B0EF30-0x0000000189B0EF70
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181269860-0x0000000181269B30
	// [XID] // 0x0000000189B19370-0x0000000189B19390
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018126B750-0x000000018126BA40
	[BlackList] // 0x0000000189B20970-0x0000000189B209B0
	// [XID] // 0x0000000189B20970-0x0000000189B209B0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018126ADF0-0x000000018126AEE0
	[BlackList] // 0x0000000189B2AFC0-0x0000000189B2B000
	// [XID] // 0x0000000189B2AFC0-0x0000000189B2B000
	public override void AutoAllocTypeFields() {} // 0x0000000181269B30-0x0000000181269BD0
	[BlackList] // 0x0000000189B352C0-0x0000000189B35300
	// [XID] // 0x0000000189B352C0-0x0000000189B35300
	public override void AutoRecycleTypeFields() {} // 0x0000000181269BD0-0x0000000181269CC0
	[BlackList] // 0x0000000189B3FEA0-0x0000000189B3FEE0
	// [XID] // 0x0000000189B3FEA0-0x0000000189B3FEE0
	public override void ReturnToObjectPool() {} // 0x000000018126BB50-0x000000018126BBF0
}

