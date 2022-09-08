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
public class ConfigPoseInitialParam : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17961
{
	// Fields
	private Dictionary<string, string> _intParams; // 0x10
	private Dictionary<string, string> _floatParams; // 0x18
	private Dictionary<string, string> _boolParams; // 0x20

	// Properties
	public Dictionary<string, string> intParams { /* [XID] */ /* 0x0000000189651F60-0x0000000189651F80 */ get => default; /* [XID] */ /* 0x0000000189659630-0x0000000189659650 */ private set {} } // 0x0000000184CF6570-0x0000000184CF6610 0x0000000184CF6710-0x0000000184CF67C0
	public Dictionary<string, string> floatParams { /* [XID] */ /* 0x0000000189660DB0-0x0000000189660DD0 */ get => default; /* [XID] */ /* 0x00000001896686E0-0x0000000189668700 */ private set {} } // 0x0000000184CF6E20-0x0000000184CF6EC0 0x0000000184CF7120-0x0000000184CF71D0
	public Dictionary<string, string> boolParams { /* [XID] */ /* 0x0000000189690BE0-0x0000000189690C00 */ get => default; /* [XID] */ /* 0x0000000189677AF0-0x0000000189677B10 */ private set {} } // 0x0000000184CF5DF0-0x0000000184CF5E90 0x0000000184CF5D40-0x0000000184CF5DF0

	// Constructors
	public ConfigPoseInitialParam() {} // 0x0000000184CF7270-0x0000000184CF72D0

	// Methods
	// [XID] // 0x000000018967F040-0x000000018967F060
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184CF6EC0-0x0000000184CF6FE0
	// [XID] // 0x0000000189686950-0x0000000189686970
	public void InitEmpty() {} // 0x0000000184CF6610-0x0000000184CF6710
	[BlackList] // 0x000000018968E7B0-0x000000018968E7F0
	// [XID] // 0x000000018968E7B0-0x000000018968E7F0
	public bool FromJson(JSONNode node) => default; // 0x0000000184CF61F0-0x0000000184CF6570
	// [XID] // 0x0000000189698F40-0x0000000189698F60
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184CF5570-0x0000000184CF5920
	// [XID] // 0x00000001896A0470-0x00000001896A0490
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF84F1 */, bool useObjectPool = false /* Metadata: 0x00AF84F5 */) => default; // 0x0000000184CF67C0-0x0000000184CF6AC0
	// [XID] // 0x00000001896A79E0-0x00000001896A7A00
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF84F6 */, bool useObjectPool = false /* Metadata: 0x00AF84FA */) => default; // 0x0000000184CF5E90-0x0000000184CF61F0
	[BlackList] // 0x00000001896AED90-0x00000001896AEDD0
	// [XID] // 0x00000001896AED90-0x00000001896AEDD0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184CF5920-0x0000000184CF5BF0
	// [XID] // 0x00000001896B9210-0x00000001896B9230
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184CF6AC0-0x0000000184CF6E20
	[BlackList] // 0x00000001896C0680-0x00000001896C06C0
	// [XID] // 0x00000001896C0680-0x00000001896C06C0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184CF5BF0-0x0000000184CF5C90
	[BlackList] // 0x00000001896CA9F0-0x00000001896CAA30
	// [XID] // 0x00000001896CA9F0-0x00000001896CAA30
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184CF5C90-0x0000000184CF5D40
	[BlackList] // 0x00000001896D51A0-0x00000001896D51E0
	// [XID] // 0x00000001896D51A0-0x00000001896D51E0
	public virtual void ReturnToObjectPool() {} // 0x0000000184CF71D0-0x0000000184CF7270
	[BlackList] // 0x00000001896DF960-0x00000001896DF9A0
	// [XID] // 0x00000001896DF960-0x00000001896DF9A0
	public virtual void OnPoolAllocated() {} // 0x0000000184CF7080-0x0000000184CF7120
	[BlackList] // 0x00000001896E9E20-0x00000001896E9E60
	// [XID] // 0x00000001896E9E20-0x00000001896E9E60
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184CF6FE0-0x0000000184CF7080
}

