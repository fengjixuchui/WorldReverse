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
public class ConfigExternalVoiceSound : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18073
{
	// Fields
	private string _sourceFileName; // 0x10
	private SimpleSafeFloat rateRawNum; // 0x18
	private string _avatarName; // 0x20
	private string _emotion; // 0x28
	private SimpleSafeInt32 genderRawNum; // 0x30

	// Properties
	public string sourceFileName { /* [XID] */ /* 0x0000000189AA9C60-0x0000000189AA9C80 */ get => default; /* [XID] */ /* 0x0000000189AB1BE0-0x0000000189AB1C00 */ private set {} } // 0x0000000182AC9810-0x0000000182AC98B0 0x0000000182ACA9B0-0x0000000182ACAA60
	public float rate { /* [XID] */ /* 0x00000001897A2520-0x00000001897A2540 */ get => default; /* [XID] */ /* 0x0000000189AC09D0-0x0000000189AC09F0 */ private set {} } // 0x0000000182AC9DF0-0x0000000182AC9ED0 0x0000000182ACAE60-0x0000000182ACAF40
	public string avatarName { /* [XID] */ /* 0x00000001897D00D0-0x00000001897D00F0 */ get => default; /* [XID] */ /* 0x0000000189ACFB70-0x0000000189ACFB90 */ private set {} } // 0x0000000182AC8D10-0x0000000182AC8DB0 0x0000000182AC9ED0-0x0000000182AC9F80
	public string emotion { /* [XID] */ /* 0x0000000189AD7840-0x0000000189AD7860 */ get => default; /* [XID] */ /* 0x0000000189ADF350-0x0000000189ADF370 */ private set {} } // 0x0000000182AC98B0-0x0000000182AC9950 0x0000000182ACA300-0x0000000182ACA3B0
	public int gender { /* [XID] */ /* 0x00000001897C10D0-0x00000001897C10F0 */ get => default; /* [XID] */ /* 0x0000000189AEE6A0-0x0000000189AEE6C0 */ private set {} } // 0x0000000182ACA490-0x0000000182ACA560 0x0000000182ACA3B0-0x0000000182ACA490

	// Constructors
	public ConfigExternalVoiceSound() {} // 0x0000000182ACB280-0x0000000182ACB2E0

	// Methods
	// [XID] // 0x0000000189AF5C10-0x0000000189AF5C30
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182ACAF40-0x0000000182ACB0A0
	// [XID] // 0x0000000189AFD190-0x0000000189AFD1B0
	public void InitEmpty() {} // 0x0000000182ACA560-0x0000000182ACA6B0
	[BlackList] // 0x0000000189B04960-0x0000000189B049A0
	// [XID] // 0x0000000189B04960-0x0000000189B049A0
	public bool FromJson(JSONNode node) => default; // 0x0000000182AC9F80-0x0000000182ACA300
	// [XID] // 0x0000000189831260-0x0000000189831280
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182AC8DB0-0x0000000182AC9390
	// [XID] // 0x00000001897AE2E0-0x00000001897AE300
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8A19 */, bool useObjectPool = false /* Metadata: 0x00AF8A1D */) => default; // 0x0000000182ACA6B0-0x0000000182ACA9B0
	// [XID] // 0x00000001897BE200-0x00000001897BE220
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8A1E */, bool useObjectPool = false /* Metadata: 0x00AF8A22 */) => default; // 0x0000000182AC9950-0x0000000182AC9DF0
	[BlackList] // 0x0000000189B25360-0x0000000189B253A0
	// [XID] // 0x0000000189B25360-0x0000000189B253A0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182AC9390-0x0000000182AC9660
	// [XID] // 0x0000000189B2F5D0-0x0000000189B2F5F0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182ACAA60-0x0000000182ACAE60
	[BlackList] // 0x0000000189B36EB0-0x0000000189B36EF0
	// [XID] // 0x0000000189B36EB0-0x0000000189B36EF0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182AC9660-0x0000000182AC9700
	[BlackList] // 0x0000000189B41970-0x0000000189B419B0
	// [XID] // 0x0000000189B41970-0x0000000189B419B0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182AC9700-0x0000000182AC9810
	[BlackList] // 0x0000000189B4C1A0-0x0000000189B4C1E0
	// [XID] // 0x0000000189B4C1A0-0x0000000189B4C1E0
	public virtual void ReturnToObjectPool() {} // 0x0000000182ACB1E0-0x0000000182ACB280
	[BlackList] // 0x0000000189B569F0-0x0000000189B56A30
	// [XID] // 0x0000000189B569F0-0x0000000189B56A30
	public virtual void OnPoolAllocated() {} // 0x0000000182ACB140-0x0000000182ACB1E0
	[BlackList] // 0x0000000189B61130-0x0000000189B61170
	// [XID] // 0x0000000189B61130-0x0000000189B61170
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182ACB0A0-0x0000000182ACB140
}

