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
public class ConfigBillboard : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17710
{
	// Fields
	private string _attachPoint; // 0x10
	private MoleMole.Config.Vector _offset; // 0x18
	private BillboardOffsetType _offsetType; // 0x24
	private SimpleSafeFloat radiusOffsetRawNum; // 0x28
	private bool _enableSelfAdapt; // 0x2C
	private SimpleSafeFloat showDistanceRawNum; // 0x30
	private SimpleSafeFloat markShowDistanceRawNum; // 0x34
	private SimpleSafeFloat nameShowDistanceRawNum; // 0x38

	// Properties
	public string attachPoint { /* [XID] */ /* 0x00000001898C5000-0x00000001898C5020 */ get => default; /* [XID] */ /* 0x0000000189764080-0x00000001897640A0 */ private set {} } // 0x000000018377EB80-0x000000018377EC20 0x000000018377F250-0x000000018377F300
	public MoleMole.Config.Vector offset { /* [XID] */ /* 0x00000001898CC440-0x00000001898CC460 */ get => default; /* [XID] */ /* 0x0000000189772DC0-0x0000000189772DE0 */ private set {} } // 0x000000018377EC20-0x000000018377ED00 0x000000018377FC50-0x000000018377FD20
	public BillboardOffsetType offsetType { /* [XID] */ /* 0x000000018977A500-0x000000018977A520 */ get => default; /* [XID] */ /* 0x00000001898D3E70-0x00000001898D3E90 */ set {} } // 0x00000001837800A0-0x0000000183780140 0x00000001837809F0-0x0000000183780AA0
	public float radiusOffset { /* [XID] */ /* 0x00000001897894A0-0x00000001897894C0 */ get => default; /* [XID] */ /* 0x0000000189790B90-0x0000000189790BB0 */ set {} } // 0x000000018377F440-0x000000018377F520 0x000000018377E9C0-0x000000018377EAA0
	public bool enableSelfAdapt { /* [XID] */ /* 0x0000000189AF9920-0x0000000189AF9940 */ get => default; /* [XID] */ /* 0x00000001897A0330-0x00000001897A0350 */ private set {} } // 0x000000018377FBB0-0x000000018377FC50 0x000000018377FFF0-0x00000001837800A0
	public float showDistance { /* [XID] */ /* 0x00000001897A78C0-0x00000001897A78E0 */ get => default; /* [XID] */ /* 0x00000001897AF310-0x00000001897AF330 */ private set {} } // 0x000000018377F9F0-0x000000018377FAD0 0x000000018377EAA0-0x000000018377EB80
	public float markShowDistance { /* [XID] */ /* 0x00000001897B71B0-0x00000001897B71D0 */ get => default; /* [XID] */ /* 0x00000001897BEF90-0x00000001897BEFB0 */ private set {} } // 0x000000018377E1D0-0x000000018377E2B0 0x000000018377E2B0-0x000000018377E390
	public float nameShowDistance { /* [XID] */ /* 0x00000001897C65A0-0x00000001897C65C0 */ get => default; /* [XID] */ /* 0x00000001897CDE00-0x00000001897CDE20 */ private set {} } // 0x000000018377FAD0-0x000000018377FBB0 0x000000018377E390-0x000000018377E470

	// Constructors
	public ConfigBillboard() {} // 0x0000000183780B40-0x0000000183780C30

	// Methods
	// [XID] // 0x00000001897D52D0-0x00000001897D52F0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183780710-0x00000001837808B0
	// [XID] // 0x00000001897DCA30-0x00000001897DCA50
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018377FF20-0x000000018377FFF0
	// [XID] // 0x00000001897E4450-0x00000001897E4470
	public virtual ConfigBillboard Clone(bool useObjectPool = false /* Metadata: 0x00AF788D */) => default; // 0x000000018377F910-0x000000018377F9F0
	// [XID] // 0x00000001897EBF80-0x00000001897EBFA0
	public virtual int GetHashNum() => default; // 0x000000018377E100-0x000000018377E1D0
	// [XID] // 0x00000001897F3930-0x00000001897F3950
	public virtual void InitEmpty() {} // 0x000000018377F300-0x000000018377F440
	[BlackList] // 0x00000001897FB2D0-0x00000001897FB310
	// [XID] // 0x00000001897FB2D0-0x00000001897FB310
	public virtual bool FromJson(JSONNode node) => default; // 0x000000018377ED00-0x000000018377F080
	// [XID] // 0x0000000189805450-0x0000000189805470
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018377D430-0x000000018377DC60
	[BlackList] // 0x000000018980C9F0-0x000000018980CA30
	// [XID] // 0x000000018980C9F0-0x000000018980CA30
	public static ConfigBillboard ParseFromJson(JSONNode node) => default; // 0x000000018377FD20-0x000000018377FF20
	// [XID] // 0x0000000189817440-0x0000000189817460
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF788E */, bool useObjectPool = false /* Metadata: 0x00AF7892 */) => default; // 0x000000018377F610-0x000000018377F910
	// [XID] // 0x000000018981EDC0-0x000000018981EDE0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7893 */, bool useObjectPool = false /* Metadata: 0x00AF7897 */) => default; // 0x000000018377E470-0x000000018377E9C0
	// [XID] // 0x0000000189826330-0x0000000189826350
	public static ConfigBillboard ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7898 */, bool useObjectPool = false /* Metadata: 0x00AF789C */) => default; // 0x000000018377F080-0x000000018377F250
	[BlackList] // 0x000000018982D920-0x000000018982D960
	// [XID] // 0x000000018982D920-0x000000018982D960
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x000000018377DC60-0x000000018377DF30
	// [XID] // 0x0000000189837F60-0x0000000189837F80
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183780140-0x0000000183780710
	[BlackList] // 0x000000018983F670-0x000000018983F6B0
	// [XID] // 0x000000018983F670-0x000000018983F6B0
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018377F520-0x000000018377F610
	[BlackList] // 0x0000000189849A30-0x0000000189849A70
	// [XID] // 0x0000000189849A30-0x0000000189849A70
	public virtual void AutoAllocTypeFields() {} // 0x000000018377DF30-0x000000018377DFD0
	[BlackList] // 0x0000000189853B00-0x0000000189853B40
	// [XID] // 0x0000000189853B00-0x0000000189853B40
	public virtual void AutoRecycleTypeFields() {} // 0x000000018377DFD0-0x000000018377E100
	[BlackList] // 0x000000018985DD10-0x000000018985DD50
	// [XID] // 0x000000018985DD10-0x000000018985DD50
	public virtual void ReturnToObjectPool() {} // 0x0000000183780AA0-0x0000000183780B40
	[BlackList] // 0x0000000189868830-0x0000000189868870
	// [XID] // 0x0000000189868830-0x0000000189868870
	public virtual void OnPoolAllocated() {} // 0x0000000183780950-0x00000001837809F0
	[BlackList] // 0x0000000189872B70-0x0000000189872BB0
	// [XID] // 0x0000000189872B70-0x0000000189872BB0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001837808B0-0x0000000183780950
}

