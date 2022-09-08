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
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class FeatureTagExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15607
{
	// Fields
	protected SimpleSafeUInt32 tagIDRawNum; // 0x10
	protected string _tagName; // 0x18
	protected string _tagDesp; // 0x20

	// Properties
	public uint tagID { /* [XID] */ /* 0x0000000189A2F490-0x0000000189A2F4B0 */ get => default; /* [XID] */ /* 0x0000000189A36E90-0x0000000189A36EB0 */ protected set {} } // 0x0000000184160760-0x0000000184160830 0x00000001841616D0-0x00000001841617B0
	public string tagName { /* [XID] */ /* 0x0000000189A3E4F0-0x0000000189A3E510 */ get => default; /* [XID] */ /* 0x0000000189A45B40-0x0000000189A45B60 */ protected set {} } // 0x00000001841609B0-0x0000000184160A50 0x00000001841614E0-0x0000000184161590
	public string tagDesp { /* [XID] */ /* 0x0000000189A4D320-0x0000000189A4D340 */ get => default; /* [XID] */ /* 0x0000000189A54A90-0x0000000189A54AB0 */ protected set {} } // 0x0000000184161030-0x00000001841610D0 0x0000000184160A50-0x0000000184160B00

	// Constructors
	public FeatureTagExcelConfig() {} // 0x0000000184161850-0x00000001841618B0

	// Methods
	// [IDTag] // 0x0000000189A5C500-0x0000000189A5C540
	// [XID] // 0x0000000189A5C500-0x0000000189A5C540
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184160B00-0x0000000184160DB0
	// [IDTag] // 0x0000000189A66C60-0x0000000189A66CA0
	// [XID] // 0x0000000189A66C60-0x0000000189A66CA0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184160DB0-0x0000000184161030
	// [XID] // 0x0000000189A71220-0x0000000189A71240
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF206A */, bool useObjectPool = false /* Metadata: 0x00AF206E */) => default; // 0x00000001841610D0-0x00000001841614E0
	[BlackList] // 0x0000000189A78E20-0x0000000189A78E60
	// [XID] // 0x0000000189A78E20-0x0000000189A78E60
	public virtual void AutoAllocTypeFields() {} // 0x0000000184160830-0x00000001841608D0
	[BlackList] // 0x0000000189A837C0-0x0000000189A83800
	// [XID] // 0x0000000189A837C0-0x0000000189A83800
	public virtual void AutoRecycleTypeFields() {} // 0x00000001841608D0-0x00000001841609B0
	[BlackList] // 0x0000000189A8E0B0-0x0000000189A8E0F0
	// [XID] // 0x0000000189A8E0B0-0x0000000189A8E0F0
	public virtual void ReturnToObjectPool() {} // 0x00000001841617B0-0x0000000184161850
	[BlackList] // 0x0000000189A98980-0x0000000189A989C0
	// [XID] // 0x0000000189A98980-0x0000000189A989C0
	public virtual void OnPoolAllocated() {} // 0x0000000184161630-0x00000001841616D0
	[BlackList] // 0x0000000189AA2AE0-0x0000000189AA2B20
	// [XID] // 0x0000000189AA2AE0-0x0000000189AA2B20
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184161590-0x0000000184161630
}

