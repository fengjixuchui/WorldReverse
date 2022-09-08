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
public class ConfigWidgetPredict : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19176
{
	// Constructors
	public ConfigWidgetPredict() {} // 0x0000000184D0A360-0x0000000184D0A3C0

	// Methods
	// [XID] // 0x0000000189680A00-0x0000000189680A20
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184D0A0D0-0x0000000184D0A180
	// [XID] // 0x00000001896884E0-0x0000000189688500
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184D09F70-0x0000000184D0A020
	// [XID] // 0x000000018968FD40-0x000000018968FD60
	public virtual ConfigWidgetPredict Clone(bool useObjectPool = false /* Metadata: 0x00AFC457 */) => default; // 0x0000000184D09C90-0x0000000184D09D70
	// [XID] // 0x0000000189697720-0x0000000189697740
	public virtual int GetHashNum() => default; // 0x0000000184D09100-0x0000000184D091D0
	// [XID] // 0x000000018969EBD0-0x000000018969EBF0
	public virtual void InitEmpty() {} // 0x0000000184D09800-0x0000000184D098A0
	[BlackList] // 0x00000001896A5E90-0x00000001896A5ED0
	// [XID] // 0x00000001896A5E90-0x00000001896A5ED0
	public virtual bool FromJson(JSONNode node) => default; // 0x0000000184D092B0-0x0000000184D09630
	// [XID] // 0x00000001896B0130-0x00000001896B0150
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184D08B70-0x0000000184D08C20
	[BlackList] // 0x00000001896B79B0-0x00000001896B79F0
	// [XID] // 0x00000001896B79B0-0x00000001896B79F0
	public static ConfigWidgetPredict ParseFromJson(JSONNode node) => default; // 0x0000000184D09D70-0x0000000184D09F70
	// [XID] // 0x00000001896C18C0-0x00000001896C18E0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC458 */, bool useObjectPool = false /* Metadata: 0x00AFC45C */) => default; // 0x0000000184D09990-0x0000000184D09C90
	// [XID] // 0x00000001896C9010-0x00000001896C9030
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC45D */, bool useObjectPool = false /* Metadata: 0x00AFC461 */) => default; // 0x0000000184D091D0-0x0000000184D092B0
	// [XID] // 0x00000001896D09E0-0x00000001896D0A00
	public static ConfigWidgetPredict ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC462 */, bool useObjectPool = false /* Metadata: 0x00AFC466 */) => default; // 0x0000000184D09630-0x0000000184D09800
	[BlackList] // 0x00000001896D7F30-0x00000001896D7F70
	// [XID] // 0x00000001896D7F30-0x00000001896D7F70
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x0000000184D08C20-0x0000000184D08EF0
	// [XID] // 0x00000001896E2760-0x00000001896E2780
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184D0A020-0x0000000184D0A0D0
	[BlackList] // 0x00000001896E9C60-0x00000001896E9CA0
	// [XID] // 0x00000001896E9C60-0x00000001896E9CA0
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184D098A0-0x0000000184D09990
	[BlackList] // 0x00000001896F40E0-0x00000001896F4120
	// [XID] // 0x00000001896F40E0-0x00000001896F4120
	public virtual void AutoAllocTypeFields() {} // 0x0000000184D08EF0-0x0000000184D08F90
	[BlackList] // 0x00000001896FEAB0-0x00000001896FEAF0
	// [XID] // 0x00000001896FEAB0-0x00000001896FEAF0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184D08F90-0x0000000184D09030
	[BlackList] // 0x0000000189708E60-0x0000000189708EA0
	// [XID] // 0x0000000189708E60-0x0000000189708EA0
	public virtual void ReturnToObjectPool() {} // 0x0000000184D0A2C0-0x0000000184D0A360
	[BlackList] // 0x00000001897136E0-0x0000000189713720
	// [XID] // 0x00000001897136E0-0x0000000189713720
	public virtual void OnPoolAllocated() {} // 0x0000000184D0A220-0x0000000184D0A2C0
	[BlackList] // 0x000000018971DE40-0x000000018971DE80
	// [XID] // 0x000000018971DE40-0x000000018971DE80
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184D0A180-0x0000000184D0A220
	// [XID] // 0x00000001897282F0-0x0000000189728310
	public virtual bool DoPredict(LCWidget lcWidget, QuickWidgetGeneral widget) => default; // 0x0000000184D09030-0x0000000184D09100
}

