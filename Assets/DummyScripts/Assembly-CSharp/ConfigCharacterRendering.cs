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
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigCharacterRendering : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17960
{
	// Fields
	private bool _overrideLightDir; // 0x10
	private MoleMole.Config.Vector _overrideLightEulerAngle; // 0x14

	// Properties
	public bool overrideLightDir { /* [XID] */ /* 0x0000000189BB0FD0-0x0000000189BB0FF0 */ get => default; /* [XID] */ /* 0x0000000189BB81A0-0x0000000189BB81C0 */ private set {} } // 0x000000018304BBB0-0x000000018304BC50 0x000000018304B5F0-0x000000018304B6A0
	public MoleMole.Config.Vector overrideLightEulerAngle { /* [XID] */ /* 0x0000000189BBF890-0x0000000189BBF8B0 */ get => default; /* [XID] */ /* 0x0000000189BC74E0-0x0000000189BC7500 */ private set {} } // 0x000000018304B140-0x000000018304B220 0x000000018304AA80-0x000000018304AB50

	// Constructors
	public ConfigCharacterRendering() {} // 0x000000018304BCF0-0x000000018304BD60

	// Methods
	// [XID] // 0x0000000189BCF1D0-0x0000000189BCF1F0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018304B940-0x000000018304BA70
	// [XID] // 0x0000000189BD64C0-0x0000000189BD64E0
	public void InitEmpty() {} // 0x000000018304B220-0x000000018304B2F0
	[BlackList] // 0x0000000189BDE020-0x0000000189BDE060
	// [XID] // 0x0000000189BDE020-0x0000000189BDE060
	public bool FromJson(JSONNode node) => default; // 0x000000018304ADC0-0x000000018304B140
	// [XID] // 0x00000001895EDAB0-0x00000001895EDAD0
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018304A3B0-0x000000018304A660
	// [XID] // 0x00000001895F5310-0x00000001895F5330
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF84E7 */, bool useObjectPool = false /* Metadata: 0x00AF84EB */) => default; // 0x000000018304B2F0-0x000000018304B5F0
	// [XID] // 0x00000001895FC910-0x00000001895FC930
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF84EC */, bool useObjectPool = false /* Metadata: 0x00AF84F0 */) => default; // 0x000000018304AB50-0x000000018304ADC0
	[BlackList] // 0x0000000189604290-0x00000001896042D0
	// [XID] // 0x0000000189604290-0x00000001896042D0
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018304A660-0x000000018304A930
	// [XID] // 0x000000018960EAA0-0x000000018960EAC0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018304B6A0-0x000000018304B940
	[BlackList] // 0x0000000189616080-0x00000001896160C0
	// [XID] // 0x0000000189616080-0x00000001896160C0
	public virtual void AutoAllocTypeFields() {} // 0x000000018304A930-0x000000018304A9D0
	[BlackList] // 0x00000001896208A0-0x00000001896208E0
	// [XID] // 0x00000001896208A0-0x00000001896208E0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018304A9D0-0x000000018304AA80
	[BlackList] // 0x000000018962AF00-0x000000018962AF40
	// [XID] // 0x000000018962AF00-0x000000018962AF40
	public virtual void ReturnToObjectPool() {} // 0x000000018304BC50-0x000000018304BCF0
	[BlackList] // 0x0000000189635B70-0x0000000189635BB0
	// [XID] // 0x0000000189635B70-0x0000000189635BB0
	public virtual void OnPoolAllocated() {} // 0x000000018304BB10-0x000000018304BBB0
	[BlackList] // 0x000000018963FF30-0x000000018963FF70
	// [XID] // 0x000000018963FF30-0x000000018963FF70
	public virtual void OnBeforePoolRecycled() {} // 0x000000018304BA70-0x000000018304BB10
}

