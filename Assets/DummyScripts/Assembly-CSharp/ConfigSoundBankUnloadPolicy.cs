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
public class ConfigSoundBankUnloadPolicy : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19007
{
	// Fields
	private SoundBankUnloadPolicy _policy; // 0x10
	private SimpleSafeFloat parameterRawNum; // 0x14

	// Properties
	public SoundBankUnloadPolicy policy { /* [XID] */ /* 0x0000000189AD2CE0-0x0000000189AD2D00 */ get => default; /* [XID] */ /* 0x0000000189ADA700-0x0000000189ADA720 */ private set {} } // 0x0000000181B21B60-0x0000000181B21C00 0x0000000181B21AB0-0x0000000181B21B60
	public float parameter { /* [XID] */ /* 0x0000000189AE1FA0-0x0000000189AE1FC0 */ get => default; /* [XID] */ /* 0x0000000189AE9790-0x0000000189AE97B0 */ private set {} } // 0x0000000181B22300-0x0000000181B223E0 0x0000000181B21C00-0x0000000181B21CE0

	// Constructors
	public ConfigSoundBankUnloadPolicy() {} // 0x0000000181B22CE0-0x0000000181B22D40

	// Methods
	// [XID] // 0x0000000189AF15F0-0x0000000189AF1610
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181B229F0-0x0000000181B22B00
	// [XID] // 0x0000000189AF8BC0-0x0000000189AF8BE0
	public void InitEmpty() {} // 0x0000000181B223E0-0x0000000181B224B0
	[BlackList] // 0x0000000189B00110-0x0000000189B00150
	// [XID] // 0x0000000189B00110-0x0000000189B00150
	public bool FromJson(JSONNode node) => default; // 0x0000000181B21F80-0x0000000181B22300
	// [XID] // 0x0000000189B0A8F0-0x0000000189B0A910
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181B21350-0x0000000181B21670
	// [XID] // 0x0000000189B11FC0-0x0000000189B11FE0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB71F */, bool useObjectPool = false /* Metadata: 0x00AFB723 */) => default; // 0x0000000181B224B0-0x0000000181B227B0
	// [XID] // 0x0000000189B19350-0x0000000189B19370
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB724 */, bool useObjectPool = false /* Metadata: 0x00AFB728 */) => default; // 0x0000000181B21CE0-0x0000000181B21F80
	[BlackList] // 0x0000000189B20930-0x0000000189B20970
	// [XID] // 0x0000000189B20930-0x0000000189B20970
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181B21670-0x0000000181B21940
	// [XID] // 0x0000000189B2AF80-0x0000000189B2AFA0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181B227B0-0x0000000181B229F0
	[BlackList] // 0x0000000189B32560-0x0000000189B325A0
	// [XID] // 0x0000000189B32560-0x0000000189B325A0
	public virtual void AutoAllocTypeFields() {} // 0x0000000181B21940-0x0000000181B219E0
	[BlackList] // 0x0000000189B3CB60-0x0000000189B3CBA0
	// [XID] // 0x0000000189B3CB60-0x0000000189B3CBA0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181B219E0-0x0000000181B21AB0
	[BlackList] // 0x0000000189B476A0-0x0000000189B476E0
	// [XID] // 0x0000000189B476A0-0x0000000189B476E0
	public virtual void ReturnToObjectPool() {} // 0x0000000181B22C40-0x0000000181B22CE0
	[BlackList] // 0x0000000189B51F60-0x0000000189B51FA0
	// [XID] // 0x0000000189B51F60-0x0000000189B51FA0
	public virtual void OnPoolAllocated() {} // 0x0000000181B22BA0-0x0000000181B22C40
	[BlackList] // 0x0000000189B5C890-0x0000000189B5C8D0
	// [XID] // 0x0000000189B5C890-0x0000000189B5C8D0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181B22B00-0x0000000181B22BA0
}

