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
public class ConfigDitherByBetweenCameraAndAvatar : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17954
{
	// Fields
	private SimpleSafeFloat detectDitherRangeRawNum; // 0x10

	// Properties
	public float detectDitherRange { /* [XID] */ /* 0x00000001897B9BB0-0x00000001897B9BD0 */ get => default; /* [XID] */ /* 0x00000001897C1CB0-0x00000001897C1CD0 */ private set {} } // 0x0000000184514160-0x0000000184514240 0x0000000184514240-0x0000000184514320

	// Constructors
	public ConfigDitherByBetweenCameraAndAvatar() {} // 0x00000001845147A0-0x0000000184514830

	// Methods
	// [XID] // 0x00000001897C95C0-0x00000001897C95E0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001845144D0-0x00000001845145C0
	// [XID] // 0x00000001897D0BB0-0x00000001897D0BD0
	public void InitEmpty() {} // 0x0000000184513D90-0x0000000184513E60
	[BlackList] // 0x00000001897D8970-0x00000001897D89B0
	// [XID] // 0x00000001897D8970-0x00000001897D89B0
	public bool FromJson(JSONNode node) => default; // 0x0000000184513A10-0x0000000184513D90
	// [XID] // 0x00000001897E2CC0-0x00000001897E2CE0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001845131F0-0x0000000184513400
	// [XID] // 0x00000001897EA500-0x00000001897EA520
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF84AB */, bool useObjectPool = false /* Metadata: 0x00AF84AF */) => default; // 0x0000000184513E60-0x0000000184514160
	// [XID] // 0x00000001897F22B0-0x00000001897F22D0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF84B0 */, bool useObjectPool = false /* Metadata: 0x00AF84B4 */) => default; // 0x0000000184513840-0x0000000184513A10
	[BlackList] // 0x00000001897F98E0-0x00000001897F9920
	// [XID] // 0x00000001897F98E0-0x00000001897F9920
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184513400-0x00000001845136D0
	// [XID] // 0x0000000189803F50-0x0000000189803F70
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184514320-0x00000001845144D0
	[BlackList] // 0x000000018980B320-0x000000018980B360
	// [XID] // 0x000000018980B320-0x000000018980B360
	public virtual void AutoAllocTypeFields() {} // 0x00000001845136D0-0x0000000184513770
	[BlackList] // 0x0000000189815BD0-0x0000000189815C10
	// [XID] // 0x0000000189815BD0-0x0000000189815C10
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184513770-0x0000000184513840
	[BlackList] // 0x00000001898206B0-0x00000001898206F0
	// [XID] // 0x00000001898206B0-0x00000001898206F0
	public virtual void ReturnToObjectPool() {} // 0x0000000184514700-0x00000001845147A0
	[BlackList] // 0x000000018982ABB0-0x000000018982ABF0
	// [XID] // 0x000000018982ABB0-0x000000018982ABF0
	public virtual void OnPoolAllocated() {} // 0x0000000184514660-0x0000000184514700
	[BlackList] // 0x0000000189835050-0x0000000189835090
	// [XID] // 0x0000000189835050-0x0000000189835090
	public virtual void OnBeforePoolRecycled() {} // 0x00000001845145C0-0x0000000184514660
}

