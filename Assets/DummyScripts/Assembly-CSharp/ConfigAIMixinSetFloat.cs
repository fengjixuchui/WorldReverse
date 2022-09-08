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
public class ConfigAIMixinSetFloat : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17509
{
	// Fields
	private string _floatID; // 0x10
	private SimpleSafeFloat valueRawNum; // 0x18

	// Properties
	public string floatID { /* [XID] */ /* 0x0000000189BA8960-0x0000000189BA8980 */ get => default; /* [XID] */ /* 0x0000000189AE21A0-0x0000000189AE21C0 */ private set {} } // 0x0000000182C61B80-0x0000000182C61C20 0x0000000182C61110-0x0000000182C611C0
	public float value { /* [XID] */ /* 0x0000000189AE9A70-0x0000000189AE9A90 */ get => default; /* [XID] */ /* 0x0000000189AF1770-0x0000000189AF1790 */ private set {} } // 0x0000000182C61030-0x0000000182C61110 0x0000000182C60F50-0x0000000182C61030

	// Constructors
	public ConfigAIMixinSetFloat() {} // 0x0000000182C61F10-0x0000000182C61F70

	// Methods
	// [XID] // 0x000000018984D6D0-0x000000018984D6F0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182C61C20-0x0000000182C61D30
	// [XID] // 0x0000000189B00370-0x0000000189B00390
	public void InitEmpty() {} // 0x0000000182C61540-0x0000000182C61640
	[BlackList] // 0x0000000189B07930-0x0000000189B07970
	// [XID] // 0x0000000189B07930-0x0000000189B07970
	public bool FromJson(JSONNode node) => default; // 0x0000000182C611C0-0x0000000182C61540
	// [XID] // 0x0000000189B12260-0x0000000189B12280
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182C60520-0x0000000182C60840
	// [XID] // 0x0000000189B19570-0x0000000189B19590
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF712F */, bool useObjectPool = false /* Metadata: 0x00AF7133 */) => default; // 0x0000000182C61640-0x0000000182C61940
	// [XID] // 0x0000000189B20BB0-0x0000000189B20BD0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7134 */, bool useObjectPool = false /* Metadata: 0x00AF7138 */) => default; // 0x0000000182C60C90-0x0000000182C60F50
	[BlackList] // 0x0000000189B28330-0x0000000189B28370
	// [XID] // 0x0000000189B28330-0x0000000189B28370
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182C60840-0x0000000182C60B10
	// [XID] // 0x0000000189B32840-0x0000000189B32860
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182C61940-0x0000000182C61B80
	[BlackList] // 0x0000000189B3A130-0x0000000189B3A170
	// [XID] // 0x0000000189B3A130-0x0000000189B3A170
	public virtual void AutoAllocTypeFields() {} // 0x0000000182C60B10-0x0000000182C60BB0
	[BlackList] // 0x0000000189B44A90-0x0000000189B44AD0
	// [XID] // 0x0000000189B44A90-0x0000000189B44AD0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182C60BB0-0x0000000182C60C90
	[BlackList] // 0x0000000189B4F190-0x0000000189B4F1D0
	// [XID] // 0x0000000189B4F190-0x0000000189B4F1D0
	public virtual void ReturnToObjectPool() {} // 0x0000000182C61E70-0x0000000182C61F10
	[BlackList] // 0x0000000189B599A0-0x0000000189B599E0
	// [XID] // 0x0000000189B599A0-0x0000000189B599E0
	public virtual void OnPoolAllocated() {} // 0x0000000182C61DD0-0x0000000182C61E70
	[BlackList] // 0x0000000189B640F0-0x0000000189B64130
	// [XID] // 0x0000000189B640F0-0x0000000189B64130
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182C61D30-0x0000000182C61DD0
}

