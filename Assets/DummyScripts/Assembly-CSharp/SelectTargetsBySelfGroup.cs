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
public class SelectTargetsBySelfGroup : SelectTargets, IAutoAllocRecycle // TypeDefIndex: 16842
{
	// Fields
	private BitwiseOperator _operation; // 0x28
	private SimpleSafeUInt32 valueRawNum; // 0x2C
	private bool _useBinary; // 0x30
	private RelationalOperator _compareType; // 0x34

	// Properties
	public BitwiseOperator operation { /* [XID] */ /* 0x0000000189854690-0x00000001898546B0 */ get => default; /* [XID] */ /* 0x000000018966E840-0x000000018966E860 */ private set {} } // 0x0000000184825B70-0x0000000184825C10 0x00000001848253A0-0x0000000184825450
	public uint value { /* [XID] */ /* 0x00000001896763C0-0x00000001896763E0 */ get => default; /* [XID] */ /* 0x000000018967DBE0-0x000000018967DC00 */ private set {} } // 0x0000000184824490-0x0000000184824560 0x0000000184824330-0x0000000184824410
	public bool useBinary { /* [XID] */ /* 0x0000000189685340-0x0000000189685360 */ get => default; /* [XID] */ /* 0x000000018968CE60-0x000000018968CE80 */ private set {} } // 0x0000000184823190-0x0000000184823230 0x0000000184824D20-0x0000000184824DD0
	public RelationalOperator compareType { /* [XID] */ /* 0x0000000189863950-0x0000000189863970 */ get => default; /* [XID] */ /* 0x000000018969C120-0x000000018969C140 */ private set {} } // 0x00000001848251C0-0x0000000184825260 0x0000000184823D50-0x0000000184823E00

	// Constructors
	public SelectTargetsBySelfGroup() {} // 0x0000000184825E00-0x0000000184825E80

	// Methods
	// [XID] // 0x00000001896A3560-0x00000001896A3580
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184825C10-0x0000000184825D60
	// [XID] // 0x00000001896AA9B0-0x00000001896AA9D0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184825700-0x00000001848257B0
	// [XID] // 0x00000001896B1970-0x00000001896B1990
	public override SelectTargets Clone(bool useObjectPool = false /* Metadata: 0x00AF4840 */) => default; // 0x0000000184825260-0x0000000184825340
	// [XID] // 0x00000001896B9390-0x00000001896B93B0
	public override int GetHashNum() => default; // 0x0000000184823C80-0x0000000184823D50
	// [XID] // 0x00000001896C07A0-0x00000001896C07C0
	public override void InitEmpty() {} // 0x0000000184824B70-0x0000000184824C40
	[BlackList] // 0x00000001896C7ED0-0x00000001896C7F10
	// [XID] // 0x00000001896C7ED0-0x00000001896C7F10
	public override bool FromJson(JSONNode node) => default; // 0x0000000184824560-0x00000001848248E0
	// [XID] // 0x00000001896D2340-0x00000001896D2360
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184823230-0x0000000184823700
	[BlackList] // 0x00000001896D9CD0-0x00000001896D9D10
	// [XID] // 0x00000001896D9CD0-0x00000001896D9D10
	public static new SelectTargetsBySelfGroup ParseFromJson(JSONNode node) => default; // 0x0000000184825450-0x00000001848256A0
	// [XID] // 0x00000001896E42F0-0x00000001896E4310
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4841 */, bool useObjectPool = false /* Metadata: 0x00AF4845 */) => default; // 0x0000000184824EC0-0x00000001848251C0
	// [XID] // 0x00000001896EB6A0-0x00000001896EB6C0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4846 */, bool useObjectPool = false /* Metadata: 0x00AF484A */) => default; // 0x0000000184823EE0-0x00000001848242B0
	// [XID] // 0x00000001896F2AB0-0x00000001896F2AD0
	public static new SelectTargetsBySelfGroup ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF484B */, bool useObjectPool = false /* Metadata: 0x00AF484F */) => default; // 0x00000001848248E0-0x0000000184824B00
	[BlackList] // 0x00000001896FA390-0x00000001896FA3D0
	// [XID] // 0x00000001896FA390-0x00000001896FA3D0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184823700-0x00000001848239D0
	// [XID] // 0x0000000189704A30-0x0000000189704A50
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001848257B0-0x0000000184825B70
	[BlackList] // 0x000000018970C1B0-0x000000018970C1F0
	// [XID] // 0x000000018970C1B0-0x000000018970C1F0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184824DD0-0x0000000184824EC0
	[BlackList] // 0x0000000189716760-0x00000001897167A0
	// [XID] // 0x0000000189716760-0x00000001897167A0
	public override void AutoAllocTypeFields() {} // 0x00000001848239D0-0x0000000184823A70
	[BlackList] // 0x0000000189721130-0x0000000189721170
	// [XID] // 0x0000000189721130-0x0000000189721170
	public override void AutoRecycleTypeFields() {} // 0x0000000184823A70-0x0000000184823B60
	[BlackList] // 0x000000018972B590-0x000000018972B5D0
	// [XID] // 0x000000018972B590-0x000000018972B5D0
	public override void ReturnToObjectPool() {} // 0x0000000184825D60-0x0000000184825E00
}

