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
public class ConfigBaseInputAction : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19095
{
	// Fields
	private InputValueType _valueType; // 0x10
	private string _descriptionTextID; // 0x18

	// Properties
	public InputValueType valueType { /* [XID] */ /* 0x000000018998F240-0x000000018998F260 */ get => default; /* [XID] */ /* 0x0000000189996BE0-0x0000000189996C00 */ private set {} } // 0x00000001836135B0-0x0000000183613650 0x00000001836123F0-0x00000001836124A0
	public string descriptionTextID { /* [XID] */ /* 0x000000018999E8B0-0x000000018999E8D0 */ get => default; /* [XID] */ /* 0x00000001899A6250-0x00000001899A6270 */ private set {} } // 0x0000000183613890-0x0000000183613930 0x0000000183612C90-0x0000000183612D40

	// Constructors
	public ConfigBaseInputAction() {} // 0x0000000183613C20-0x0000000183613C80

	// Methods
	// [XID] // 0x00000001899AD7E0-0x00000001899AD800
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183613930-0x0000000183613A40
	// [XID] // 0x00000001899B5120-0x00000001899B5140
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001836134E0-0x00000001836135B0
	// [XID] // 0x00000001899BC7B0-0x00000001899BC7D0
	public virtual ConfigBaseInputAction Clone(bool useObjectPool = false /* Metadata: 0x00AFBEF7 */) => default; // 0x0000000183613200-0x00000001836132E0
	// [XID] // 0x00000001899C4180-0x00000001899C41A0
	public virtual int GetHashNum() => default; // 0x0000000183612320-0x00000001836123F0
	// [XID] // 0x00000001899CB920-0x00000001899CB940
	public virtual void InitEmpty() {} // 0x0000000183612D40-0x0000000183612E10
	[BlackList] // 0x00000001899D2E30-0x00000001899D2E70
	// [XID] // 0x00000001899D2E30-0x00000001899D2E70
	public virtual bool FromJson(JSONNode node) => default; // 0x0000000183612740-0x0000000183612AC0
	// [XID] // 0x00000001899DD320-0x00000001899DD340
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183611C50-0x0000000183611F10
	[BlackList] // 0x00000001899E4F20-0x00000001899E4F60
	// [XID] // 0x00000001899E4F20-0x00000001899E4F60
	public static ConfigBaseInputAction ParseFromJson(JSONNode node) => default; // 0x00000001836132E0-0x00000001836134E0
	// [XID] // 0x00000001899FC2C0-0x00000001899FC2E0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFBEF8 */, bool useObjectPool = false /* Metadata: 0x00AFBEFC */) => default; // 0x0000000183612F00-0x0000000183613200
	// [XID] // 0x00000001899F6CB0-0x00000001899F6CD0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFBEFD */, bool useObjectPool = false /* Metadata: 0x00AFBF01 */) => default; // 0x00000001836124A0-0x0000000183612740
	// [XID] // 0x00000001899ECFC0-0x00000001899ECFE0
	public static ConfigBaseInputAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFBF02 */, bool useObjectPool = false /* Metadata: 0x00AFBF06 */) => default; // 0x0000000183612AC0-0x0000000183612C90
	[BlackList] // 0x0000000189A05BD0-0x0000000189A05C10
	// [XID] // 0x0000000189A05BD0-0x0000000189A05C10
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x0000000183611F10-0x00000001836121E0
	// [XID] // 0x0000000189A0FDF0-0x0000000189A0FE10
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183613650-0x0000000183613890
	[BlackList] // 0x0000000189A17270-0x0000000189A172B0
	// [XID] // 0x0000000189A17270-0x0000000189A172B0
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183612E10-0x0000000183612F00
	[BlackList] // 0x0000000189A218B0-0x0000000189A218F0
	// [XID] // 0x0000000189A218B0-0x0000000189A218F0
	public virtual void AutoAllocTypeFields() {} // 0x00000001836121E0-0x0000000183612280
	[BlackList] // 0x0000000189A2BCD0-0x0000000189A2BD10
	// [XID] // 0x0000000189A2BCD0-0x0000000189A2BD10
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183612280-0x0000000183612320
	[BlackList] // 0x0000000189A36770-0x0000000189A367B0
	// [XID] // 0x0000000189A36770-0x0000000189A367B0
	public virtual void ReturnToObjectPool() {} // 0x0000000183613B80-0x0000000183613C20
	[BlackList] // 0x0000000189A40DB0-0x0000000189A40DF0
	// [XID] // 0x0000000189A40DB0-0x0000000189A40DF0
	public virtual void OnPoolAllocated() {} // 0x0000000183613AE0-0x0000000183613B80
	[BlackList] // 0x0000000189A4B3E0-0x0000000189A4B420
	// [XID] // 0x0000000189A4B3E0-0x0000000189A4B420
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183613A40-0x0000000183613AE0
}

