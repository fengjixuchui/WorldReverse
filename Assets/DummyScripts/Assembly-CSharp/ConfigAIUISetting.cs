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
public class ConfigAIUISetting : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17502
{
	// Fields
	private bool _hasDirectionIndicator; // 0x10

	// Properties
	public bool hasDirectionIndicator { /* [XID] */ /* 0x000000018980D660-0x000000018980D680 */ get => default; /* [XID] */ /* 0x00000001897C96C0-0x00000001897C96E0 */ private set {} } // 0x0000000182E1C480-0x0000000182E1C520 0x0000000182E1C520-0x0000000182E1C5D0

	// Constructors
	public ConfigAIUISetting() {} // 0x0000000182E1CA50-0x0000000182E1CAC0

	// Methods
	// [XID] // 0x0000000189B91530-0x0000000189B91550
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182E1C780-0x0000000182E1C870
	// [XID] // 0x00000001897D8A90-0x00000001897D8AB0
	public void InitEmpty() {} // 0x0000000182E1C0E0-0x0000000182E1C180
	[BlackList] // 0x00000001897DFC70-0x00000001897DFCB0
	// [XID] // 0x00000001897DFC70-0x00000001897DFCB0
	public bool FromJson(JSONNode node) => default; // 0x0000000182E1BD60-0x0000000182E1C0E0
	// [XID] // 0x00000001897EA600-0x00000001897EA620
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182E1B5C0-0x0000000182E1B780
	// [XID] // 0x00000001897F22D0-0x00000001897F22F0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF70E5 */, bool useObjectPool = false /* Metadata: 0x00AF70E9 */) => default; // 0x0000000182E1C180-0x0000000182E1C480
	// [XID] // 0x00000001897F9980-0x00000001897F99A0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF70EA */, bool useObjectPool = false /* Metadata: 0x00AF70EE */) => default; // 0x0000000182E1BB90-0x0000000182E1BD60
	[BlackList] // 0x0000000189800EC0-0x0000000189800F00
	// [XID] // 0x0000000189800EC0-0x0000000189800F00
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182E1B780-0x0000000182E1BA50
	// [XID] // 0x000000018980B420-0x000000018980B440
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182E1C5D0-0x0000000182E1C780
	[BlackList] // 0x0000000189812AC0-0x0000000189812B00
	// [XID] // 0x0000000189812AC0-0x0000000189812B00
	public virtual void AutoAllocTypeFields() {} // 0x0000000182E1BA50-0x0000000182E1BAF0
	[BlackList] // 0x000000018981D690-0x000000018981D6D0
	// [XID] // 0x000000018981D690-0x000000018981D6D0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182E1BAF0-0x0000000182E1BB90
	[BlackList] // 0x0000000189827E40-0x0000000189827E80
	// [XID] // 0x0000000189827E40-0x0000000189827E80
	public virtual void ReturnToObjectPool() {} // 0x0000000182E1C9B0-0x0000000182E1CA50
	[BlackList] // 0x0000000189832170-0x00000001898321B0
	// [XID] // 0x0000000189832170-0x00000001898321B0
	public virtual void OnPoolAllocated() {} // 0x0000000182E1C910-0x0000000182E1C9B0
	[BlackList] // 0x000000018983C7F0-0x000000018983C830
	// [XID] // 0x000000018983C7F0-0x000000018983C830
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182E1C870-0x0000000182E1C910
}

