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
public class AudioWeatherProperties : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17634
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _stateValue; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _switchValue; // 0x18
	private SimpleSafeFloat rtpcValueRawNum; // 0x20
	private string _surfaceOverride; // 0x28

	// Properties
	public ConfigWwiseString stateValue { /* [XID] */ /* 0x00000001896DFA80-0x00000001896DFAA0 */ get => default; /* [XID] */ /* 0x00000001896E6E20-0x00000001896E6E40 */ private set {} } // 0x00000001830A74D0-0x00000001830A7570 0x00000001830A7420-0x00000001830A74D0
	public ConfigWwiseString switchValue { /* [XID] */ /* 0x000000018975BAB0-0x000000018975BAD0 */ get => default; /* [XID] */ /* 0x00000001896F5C00-0x00000001896F5C20 */ private set {} } // 0x00000001830A6020-0x00000001830A60C0 0x00000001830A6E90-0x00000001830A6F40
	public float rtpcValue { /* [XID] */ /* 0x00000001896FD450-0x00000001896FD470 */ get => default; /* [XID] */ /* 0x0000000189704890-0x00000001897048B0 */ private set {} } // 0x00000001830A6600-0x00000001830A66E0 0x00000001830A60C0-0x00000001830A61A0
	public string surfaceOverride { /* [XID] */ /* 0x000000018970C070-0x000000018970C090 */ get => default; /* [XID] */ /* 0x0000000189713A00-0x0000000189713A20 */ private set {} } // 0x00000001830A6F40-0x00000001830A6FE0 0x00000001830A6FE0-0x00000001830A7090

	// Constructors
	public AudioWeatherProperties() {} // 0x00000001830A78C0-0x00000001830A7920

	// Methods
	// [XID] // 0x000000018971B2A0-0x000000018971B2C0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001830A7570-0x00000001830A76E0
	// [XID] // 0x00000001897225A0-0x00000001897225C0
	public void InitEmpty() {} // 0x00000001830A6A60-0x00000001830A6B90
	[BlackList] // 0x0000000189729C60-0x0000000189729CA0
	// [XID] // 0x0000000189729C60-0x0000000189729CA0
	public bool FromJson(JSONNode node) => default; // 0x00000001830A66E0-0x00000001830A6A60
	// [XID] // 0x0000000189734370-0x0000000189734390
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001830A55D0-0x00000001830A5AD0
	// [XID] // 0x000000018973BC40-0x000000018973BC60
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF758B */, bool useObjectPool = false /* Metadata: 0x00AF758F */) => default; // 0x00000001830A6B90-0x00000001830A6E90
	// [XID] // 0x0000000189743510-0x0000000189743530
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7590 */, bool useObjectPool = false /* Metadata: 0x00AF7594 */) => default; // 0x00000001830A61A0-0x00000001830A6600
	[BlackList] // 0x000000018974B180-0x000000018974B1C0
	// [XID] // 0x000000018974B180-0x000000018974B1C0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001830A5AD0-0x00000001830A5DA0
	// [XID] // 0x0000000189755670-0x0000000189755690
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001830A7090-0x00000001830A7420
	[BlackList] // 0x000000018975C810-0x000000018975C850
	// [XID] // 0x000000018975C810-0x000000018975C850
	public virtual void AutoAllocTypeFields() {} // 0x00000001830A5DA0-0x00000001830A5E40
	[BlackList] // 0x0000000189767160-0x00000001897671A0
	// [XID] // 0x0000000189767160-0x00000001897671A0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001830A5E40-0x00000001830A6020
	[BlackList] // 0x00000001897718B0-0x00000001897718F0
	// [XID] // 0x00000001897718B0-0x00000001897718F0
	public virtual void ReturnToObjectPool() {} // 0x00000001830A7820-0x00000001830A78C0
	[BlackList] // 0x000000018977BE00-0x000000018977BE40
	// [XID] // 0x000000018977BE00-0x000000018977BE40
	public virtual void OnPoolAllocated() {} // 0x00000001830A7780-0x00000001830A7820
	[BlackList] // 0x0000000189786720-0x0000000189786760
	// [XID] // 0x0000000189786720-0x0000000189786760
	public virtual void OnBeforePoolRecycled() {} // 0x00000001830A76E0-0x00000001830A7780
}

