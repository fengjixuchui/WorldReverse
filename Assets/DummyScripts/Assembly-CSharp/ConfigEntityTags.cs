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
public class ConfigEntityTags : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17958
{
	// Fields
	private string[] _initTags; // 0x10

	// Properties
	public string[] initTags { /* [XID] */ /* 0x0000000189A2EFF0-0x0000000189A2F010 */ get => default; /* [XID] */ /* 0x0000000189A36990-0x0000000189A369B0 */ private set {} } // 0x0000000183405160-0x0000000183405200 0x0000000183404640-0x00000001834046F0

	// Constructors
	public ConfigEntityTags() {} // 0x00000001834059B0-0x0000000183405A10

	// Methods
	// [XID] // 0x0000000189A3DF90-0x0000000189A3DFB0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001834056F0-0x00000001834057D0
	// [XID] // 0x0000000189A45740-0x0000000189A45760
	public void InitEmpty() {} // 0x0000000183405090-0x0000000183405160
	[BlackList] // 0x0000000189A4CD60-0x0000000189A4CDA0
	// [XID] // 0x0000000189A4CD60-0x0000000189A4CDA0
	public bool FromJson(JSONNode node) => default; // 0x0000000183404D10-0x0000000183405090
	// [XID] // 0x0000000189A574F0-0x0000000189A57510
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183404460-0x0000000183404640
	// [XID] // 0x0000000189A5EFD0-0x0000000189A5EFF0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF84D3 */, bool useObjectPool = false /* Metadata: 0x00AF84D7 */) => default; // 0x0000000183405200-0x0000000183405500
	// [XID] // 0x0000000189A668E0-0x0000000189A66900
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF84D8 */, bool useObjectPool = false /* Metadata: 0x00AF84DC */) => default; // 0x0000000183404B00-0x0000000183404D10
	[BlackList] // 0x0000000189A6E0E0-0x0000000189A6E120
	// [XID] // 0x0000000189A6E0E0-0x0000000189A6E120
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001834046F0-0x00000001834049C0
	// [XID] // 0x0000000189A78AC0-0x0000000189A78AE0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183405500-0x00000001834056F0
	[BlackList] // 0x0000000189A7FE60-0x0000000189A7FEA0
	// [XID] // 0x0000000189A7FE60-0x0000000189A7FEA0
	public virtual void AutoAllocTypeFields() {} // 0x00000001834049C0-0x0000000183404A60
	[BlackList] // 0x0000000189A8AB40-0x0000000189A8AB80
	// [XID] // 0x0000000189A8AB40-0x0000000189A8AB80
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183404A60-0x0000000183404B00
	[BlackList] // 0x0000000189A95170-0x0000000189A951B0
	// [XID] // 0x0000000189A95170-0x0000000189A951B0
	public virtual void ReturnToObjectPool() {} // 0x0000000183405910-0x00000001834059B0
	[BlackList] // 0x0000000189A9F830-0x0000000189A9F870
	// [XID] // 0x0000000189A9F830-0x0000000189A9F870
	public virtual void OnPoolAllocated() {} // 0x0000000183405870-0x0000000183405910
	[BlackList] // 0x0000000189AA9CA0-0x0000000189AA9CE0
	// [XID] // 0x0000000189AA9CA0-0x0000000189AA9CE0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001834057D0-0x0000000183405870
}

