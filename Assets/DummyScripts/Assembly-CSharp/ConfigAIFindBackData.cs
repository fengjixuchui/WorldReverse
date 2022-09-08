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
public class ConfigAIFindBackData : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17451
{
	// Fields
	private SimpleSafeInt32 speedLevelRawNum; // 0x10
	private SimpleSafeFloat turnSpeedOverrideRawNum; // 0x14
	private SimpleSafeFloat cdRawNum; // 0x18
	private SimpleSafeFloat overtimeRawNum; // 0x1C
	private SimpleSafeFloat targetLRSpaceRawNum; // 0x20
	private SimpleSafeFloat targetBackSpaceRawNum; // 0x24

	// Properties
	public int speedLevel { /* [XID] */ /* 0x0000000189A31EE0-0x0000000189A31F00 */ get => default; /* [XID] */ /* 0x0000000189A39890-0x0000000189A398B0 */ private set {} } // 0x0000000181B01AC0-0x0000000181B01B90 0x0000000181B01D50-0x0000000181B01E30
	public float turnSpeedOverride { /* [XID] */ /* 0x0000000189A410F0-0x0000000189A41110 */ get => default; /* [XID] */ /* 0x0000000189A48810-0x0000000189A48830 */ private set {} } // 0x0000000181B01C70-0x0000000181B01D50 0x0000000181B02270-0x0000000181B02350
	public float cd { /* [XID] */ /* 0x0000000189A4FFA0-0x0000000189A4FFC0 */ get => default; /* [XID] */ /* 0x0000000189A57570-0x0000000189A57590 */ private set {} } // 0x0000000181B02F80-0x0000000181B03060 0x0000000181B02890-0x0000000181B02970
	public float overtime { /* [XID] */ /* 0x0000000189A5F050-0x0000000189A5F070 */ get => default; /* [XID] */ /* 0x0000000189A66960-0x0000000189A66980 */ private set {} } // 0x0000000181B01B90-0x0000000181B01C70 0x0000000181B026D0-0x0000000181B027B0
	public float targetLRSpace { /* [XID] */ /* 0x0000000189A6E1A0-0x0000000189A6E1C0 */ get => default; /* [XID] */ /* 0x0000000189A756F0-0x0000000189A75710 */ private set {} } // 0x0000000181B02BA0-0x0000000181B02C80 0x0000000181B027B0-0x0000000181B02890
	public float targetBackSpace { /* [XID] */ /* 0x0000000189A7D410-0x0000000189A7D430 */ get => default; /* [XID] */ /* 0x0000000189A84C00-0x0000000189A84C20 */ private set {} } // 0x0000000181B037B0-0x0000000181B03890 0x0000000181B02AC0-0x0000000181B02BA0

	// Constructors
	public ConfigAIFindBackData() {} // 0x0000000181B03930-0x0000000181B03A50

	// Methods
	// [XID] // 0x0000000189A8C4B0-0x0000000189A8C4D0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181B03500-0x0000000181B03670
	// [XID] // 0x0000000189A93910-0x0000000189A93930
	public void InitEmpty() {} // 0x0000000181B02970-0x0000000181B02AC0
	[BlackList] // 0x0000000189A9B520-0x0000000189A9B560
	// [XID] // 0x0000000189A9B520-0x0000000189A9B560
	public bool FromJson(JSONNode node) => default; // 0x0000000181B02350-0x0000000181B026D0
	// [XID] // 0x0000000189AA59A0-0x0000000189AA59C0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181B00F10-0x0000000181B01600
	// [XID] // 0x0000000189AACFE0-0x0000000189AAD000
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6F13 */, bool useObjectPool = false /* Metadata: 0x00AF6F17 */) => default; // 0x0000000181B02C80-0x0000000181B02F80
	// [XID] // 0x0000000189AB4990-0x0000000189AB49B0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6F18 */, bool useObjectPool = false /* Metadata: 0x00AF6F1C */) => default; // 0x0000000181B01E30-0x0000000181B02270
	[BlackList] // 0x0000000189ABC700-0x0000000189ABC740
	// [XID] // 0x0000000189ABC700-0x0000000189ABC740
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181B01600-0x0000000181B018D0
	// [XID] // 0x0000000189AC6E00-0x0000000189AC6E20
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181B03060-0x0000000181B03500
	[BlackList] // 0x0000000189ACE570-0x0000000189ACE5B0
	// [XID] // 0x0000000189ACE570-0x0000000189ACE5B0
	public virtual void AutoAllocTypeFields() {} // 0x0000000181B018D0-0x0000000181B01970
	[BlackList] // 0x0000000189AD9310-0x0000000189AD9350
	// [XID] // 0x0000000189AD9310-0x0000000189AD9350
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181B01970-0x0000000181B01AC0
	[BlackList] // 0x0000000189AE3C30-0x0000000189AE3C70
	// [XID] // 0x0000000189AE3C30-0x0000000189AE3C70
	public virtual void ReturnToObjectPool() {} // 0x0000000181B03890-0x0000000181B03930
	[BlackList] // 0x0000000189AEE780-0x0000000189AEE7C0
	// [XID] // 0x0000000189AEE780-0x0000000189AEE7C0
	public virtual void OnPoolAllocated() {} // 0x0000000181B03710-0x0000000181B037B0
	[BlackList] // 0x0000000189AF8E70-0x0000000189AF8EB0
	// [XID] // 0x0000000189AF8E70-0x0000000189AF8EB0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181B03670-0x0000000181B03710
}

