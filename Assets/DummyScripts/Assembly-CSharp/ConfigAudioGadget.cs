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
public class ConfigAudioGadget : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17585
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _paimonSpeedRtpcKey; // 0x10

	// Properties
	public ConfigWwiseString paimonSpeedRtpcKey { /* [XID] */ /* 0x00000001897E0620-0x00000001897E0640 */ get => default; /* [XID] */ /* 0x00000001896DFAC0-0x00000001896DFAE0 */ private set {} } // 0x00000001833B0800-0x00000001833B08A0 0x00000001833B0E70-0x00000001833B0F20

	// Constructors
	public ConfigAudioGadget() {} // 0x00000001833B1790-0x00000001833B17F0

	// Methods
	// [XID] // 0x00000001896E6E60-0x00000001896E6E80
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001833B14D0-0x00000001833B15B0
	// [XID] // 0x00000001896EE310-0x00000001896EE330
	public void InitEmpty() {} // 0x00000001833B0F20-0x00000001833B0FF0
	[BlackList] // 0x00000001896F5C40-0x00000001896F5C80
	// [XID] // 0x00000001896F5C40-0x00000001896F5C80
	public bool FromJson(JSONNode node) => default; // 0x00000001833B0AF0-0x00000001833B0E70
	// [XID] // 0x0000000189700120-0x0000000189700140
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001833B0170-0x00000001833B0370
	// [XID] // 0x0000000189707870-0x0000000189707890
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF73C5 */, bool useObjectPool = false /* Metadata: 0x00AF73C9 */) => default; // 0x00000001833B0FF0-0x00000001833B12F0
	// [XID] // 0x000000018970F220-0x000000018970F240
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF73CA */, bool useObjectPool = false /* Metadata: 0x00AF73CE */) => default; // 0x00000001833B08A0-0x00000001833B0AF0
	[BlackList] // 0x0000000189716660-0x00000001897166A0
	// [XID] // 0x0000000189716660-0x00000001897166A0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001833B0370-0x00000001833B0640
	// [XID] // 0x0000000189720F10-0x0000000189720F30
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001833B12F0-0x00000001833B14D0
	[BlackList] // 0x00000001897285B0-0x00000001897285F0
	// [XID] // 0x00000001897285B0-0x00000001897285F0
	public virtual void AutoAllocTypeFields() {} // 0x00000001833B0640-0x00000001833B06E0
	[BlackList] // 0x0000000189732B60-0x0000000189732BA0
	// [XID] // 0x0000000189732B60-0x0000000189732BA0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001833B06E0-0x00000001833B0800
	[BlackList] // 0x000000018973D690-0x000000018973D6D0
	// [XID] // 0x000000018973D690-0x000000018973D6D0
	public virtual void ReturnToObjectPool() {} // 0x00000001833B16F0-0x00000001833B1790
	[BlackList] // 0x0000000189747D80-0x0000000189747DC0
	// [XID] // 0x0000000189747D80-0x0000000189747DC0
	public virtual void OnPoolAllocated() {} // 0x00000001833B1650-0x00000001833B16F0
	[BlackList] // 0x0000000189752250-0x0000000189752290
	// [XID] // 0x0000000189752250-0x0000000189752290
	public virtual void OnBeforePoolRecycled() {} // 0x00000001833B15B0-0x00000001833B1650
}

