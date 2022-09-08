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
public class ConfigAIOrderSetting : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17400
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIOrderMasterSetting _master; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIOrderServantSetting _servant; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAICommandSetting _commandSetting; // 0x20

	// Properties
	public ConfigAIOrderMasterSetting master { /* [XID] */ /* 0x0000000189686AB0-0x0000000189686AD0 */ get => default; /* [XID] */ /* 0x000000018968E930-0x000000018968E950 */ private set {} } // 0x0000000181EF89D0-0x0000000181EF8A70 0x0000000181EF82A0-0x0000000181EF8350
	public ConfigAIOrderServantSetting servant { /* [XID] */ /* 0x00000001897C9DE0-0x00000001897C9E00 */ get => default; /* [XID] */ /* 0x000000018969D9B0-0x000000018969D9D0 */ private set {} } // 0x0000000181EF9310-0x0000000181EF93B0 0x0000000181EF8350-0x0000000181EF8400
	public ConfigAICommandSetting commandSetting { /* [XID] */ /* 0x00000001896A49E0-0x00000001896A4A00 */ get => default; /* [XID] */ /* 0x00000001896AC1D0-0x00000001896AC1F0 */ private set {} } // 0x0000000181EF8830-0x0000000181EF88D0 0x0000000181EF8780-0x0000000181EF8830

	// Constructors
	public ConfigAIOrderSetting() {} // 0x0000000181EF9450-0x0000000181EF94B0

	// Methods
	// [XID] // 0x0000000189AB9A70-0x0000000189AB9A90
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181EF90A0-0x0000000181EF91D0
	// [XID] // 0x00000001896BAC10-0x00000001896BAC30
	public void InitEmpty() {} // 0x0000000181EF88D0-0x0000000181EF89D0
	[BlackList] // 0x00000001896C1D00-0x00000001896C1D40
	// [XID] // 0x00000001896C1D00-0x00000001896C1D40
	public bool FromJson(JSONNode node) => default; // 0x0000000181EF8400-0x0000000181EF8780
	// [XID] // 0x00000001896CC4D0-0x00000001896CC4F0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181EF7530-0x0000000181EF7920
	// [XID] // 0x00000001896D36C0-0x00000001896D36E0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6D4B */, bool useObjectPool = false /* Metadata: 0x00AF6D4F */) => default; // 0x0000000181EF8A70-0x0000000181EF8D70
	// [XID] // 0x00000001896DB1C0-0x00000001896DB1E0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6D50 */, bool useObjectPool = false /* Metadata: 0x00AF6D54 */) => default; // 0x0000000181EF7EB0-0x0000000181EF82A0
	[BlackList] // 0x00000001896E2920-0x00000001896E2960
	// [XID] // 0x00000001896E2920-0x00000001896E2960
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181EF7920-0x0000000181EF7BF0
	// [XID] // 0x00000001896ECCA0-0x00000001896ECCC0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181EF8D70-0x0000000181EF90A0
	[BlackList] // 0x00000001896F4420-0x00000001896F4460
	// [XID] // 0x00000001896F4420-0x00000001896F4460
	public virtual void AutoAllocTypeFields() {} // 0x0000000181EF7BF0-0x0000000181EF7C90
	[BlackList] // 0x00000001896FEE10-0x00000001896FEE50
	// [XID] // 0x00000001896FEE10-0x00000001896FEE50
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181EF7C90-0x0000000181EF7EB0
	[BlackList] // 0x0000000189709360-0x00000001897093A0
	// [XID] // 0x0000000189709360-0x00000001897093A0
	public virtual void ReturnToObjectPool() {} // 0x0000000181EF93B0-0x0000000181EF9450
	[BlackList] // 0x0000000189713AA0-0x0000000189713AE0
	// [XID] // 0x0000000189713AA0-0x0000000189713AE0
	public virtual void OnPoolAllocated() {} // 0x0000000181EF9270-0x0000000181EF9310
	[BlackList] // 0x000000018971E100-0x000000018971E140
	// [XID] // 0x000000018971E100-0x000000018971E140
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181EF91D0-0x0000000181EF9270
}

