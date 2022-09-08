/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
public class ConfigTextMapLevel : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19078
{
	// Fields
	private Dictionary<SimpleSafeInt32, TextMapLevelStruct> _levelMap; // 0x10
	private Dictionary<TextMapPlatformType, SimpleSafeInt32> _platformMap; // 0x18

	// Properties
	public Dictionary<SimpleSafeInt32, TextMapLevelStruct> levelMap { /* [XID] */ /* 0x0000000189656510-0x0000000189656530 */ get => default; /* [XID] */ /* 0x000000018965DC50-0x000000018965DC70 */ private set {} } // 0x0000000182C89890-0x0000000182C89930 0x0000000182C8A9B0-0x0000000182C8AA60
	public Dictionary<TextMapPlatformType, SimpleSafeInt32> platformMap { /* [XID] */ /* 0x00000001896652D0-0x00000001896652F0 */ get => default; /* [XID] */ /* 0x000000018966CA80-0x000000018966CAA0 */ private set {} } // 0x0000000182C8A420-0x0000000182C8A4C0 0x0000000182C89C00-0x0000000182C89CB0

	// Constructors
	public ConfigTextMapLevel() {} // 0x0000000182C8AB00-0x0000000182C8AB60

	// Methods
	// [XID] // 0x0000000189674850-0x0000000189674870
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182C8A760-0x0000000182C8A870
	// [XID] // 0x000000018967C200-0x000000018967C220
	public void InitEmpty() {} // 0x0000000182C8A030-0x0000000182C8A120
	[BlackList] // 0x00000001896836F0-0x0000000189683730
	// [XID] // 0x00000001896836F0-0x0000000189683730
	public bool FromJson(JSONNode node) => default; // 0x0000000182C89CB0-0x0000000182C8A030
	// [XID] // 0x000000018968E510-0x000000018968E530
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182C891B0-0x0000000182C89480
	// [XID] // 0x0000000189695F10-0x0000000189695F30
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB9D9 */, bool useObjectPool = false /* Metadata: 0x00AFB9DD */) => default; // 0x0000000182C8A120-0x0000000182C8A420
	// [XID] // 0x000000018969D630-0x000000018969D650
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB9DE */, bool useObjectPool = false /* Metadata: 0x00AFB9E2 */) => default; // 0x0000000182C89930-0x0000000182C89C00
	[BlackList] // 0x00000001896A46C0-0x00000001896A4700
	// [XID] // 0x00000001896A46C0-0x00000001896A4700
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182C89480-0x0000000182C89750
	// [XID] // 0x00000001896AEC30-0x00000001896AEC50
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182C8A4C0-0x0000000182C8A760
	[BlackList] // 0x00000001896B6320-0x00000001896B6360
	// [XID] // 0x00000001896B6320-0x00000001896B6360
	public virtual void AutoAllocTypeFields() {} // 0x0000000182C89750-0x0000000182C897F0
	[BlackList] // 0x00000001896C03E0-0x00000001896C0420
	// [XID] // 0x00000001896C03E0-0x00000001896C0420
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182C897F0-0x0000000182C89890
	[BlackList] // 0x00000001896CA830-0x00000001896CA870
	// [XID] // 0x00000001896CA830-0x00000001896CA870
	public virtual void ReturnToObjectPool() {} // 0x0000000182C8AA60-0x0000000182C8AB00
	[BlackList] // 0x00000001896D4F20-0x00000001896D4F60
	// [XID] // 0x00000001896D4F20-0x00000001896D4F60
	public virtual void OnPoolAllocated() {} // 0x0000000182C8A910-0x0000000182C8A9B0
	[BlackList] // 0x00000001896DF7E0-0x00000001896DF820
	// [XID] // 0x00000001896DF7E0-0x00000001896DF820
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182C8A870-0x0000000182C8A910
}

