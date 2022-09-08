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
public class ConfigWwiseString : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19232
{
	// Fields
	private string _text; // 0x10
	private bool _hasConvertedHash; // 0x18
	private uint _hashId; // 0x1C

	// Properties
	public string text { /* [XID] */ /* 0x00000001896986D0-0x00000001896986F0 */ get => default; /* [XID] */ /* 0x0000000189ADD990-0x0000000189ADD9B0 */ private set {} } // 0x00000001811206C0-0x0000000181120760 0x000000018111FAF0-0x000000018111FBA0

	// Constructors
	public ConfigWwiseString() {} // 0x0000000181120800-0x0000000181120860

	// Methods
	// [XID] // 0x0000000189AE52C0-0x0000000189AE52E0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001811204A0-0x0000000181120580
	// [XID] // 0x0000000189AEC8C0-0x0000000189AEC8E0
	public void InitEmpty() {} // 0x000000018111FF20-0x000000018111FFF0
	[BlackList] // 0x0000000189AF42B0-0x0000000189AF42F0
	// [XID] // 0x0000000189AF42B0-0x0000000189AF42F0
	public bool FromJson(JSONNode node) => default; // 0x000000018111FBA0-0x000000018111FF20
	// [XID] // 0x000000018960C520-0x000000018960C540
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018111F2E0-0x000000018111F4C0
	// [XID] // 0x0000000189B06180-0x0000000189B061A0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC61F */, bool useObjectPool = false /* Metadata: 0x00AFC623 */) => default; // 0x000000018111FFF0-0x00000001811202F0
	// [XID] // 0x0000000189B0D930-0x0000000189B0D950
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC624 */, bool useObjectPool = false /* Metadata: 0x00AFC628 */) => default; // 0x000000018111F8E0-0x000000018111FAF0
	[BlackList] // 0x0000000189B14D50-0x0000000189B14D90
	// [XID] // 0x0000000189B14D50-0x0000000189B14D90
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018111F4C0-0x000000018111F790
	// [XID] // 0x0000000189B1F3A0-0x0000000189B1F3C0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001811202F0-0x00000001811204A0
	// [XID] // 0x0000000189B26C00-0x0000000189B26C20
	public static implicit operator uint(ConfigWwiseString wwiseString) => default; // 0x000000018111F150-0x000000018111F2E0
	[BlackList] // 0x0000000189B2DE50-0x0000000189B2DE90
	// [XID] // 0x0000000189B2DE50-0x0000000189B2DE90
	public virtual void AutoAllocTypeFields() {} // 0x000000018111F790-0x000000018111F830
	[BlackList] // 0x0000000189B383B0-0x0000000189B383F0
	// [XID] // 0x0000000189B383B0-0x0000000189B383F0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018111F830-0x000000018111F8E0
	[BlackList] // 0x0000000189B42ED0-0x0000000189B42F10
	// [XID] // 0x0000000189B42ED0-0x0000000189B42F10
	public virtual void ReturnToObjectPool() {} // 0x0000000181120760-0x0000000181120800
	[BlackList] // 0x0000000189B4D630-0x0000000189B4D670
	// [XID] // 0x0000000189B4D630-0x0000000189B4D670
	public virtual void OnPoolAllocated() {} // 0x0000000181120620-0x00000001811206C0
	[BlackList] // 0x0000000189B58020-0x0000000189B58060
	// [XID] // 0x0000000189B58020-0x0000000189B58060
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181120580-0x0000000181120620
}

