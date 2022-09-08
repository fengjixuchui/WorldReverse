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
public class CoopSelectNodeContent : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17752
{
	// Fields
	private uint _dialogId; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private CoopCondGroup _showCond; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private CoopCondGroup _enableCond; // 0x20

	// Properties
	public uint dialogId { /* [XID] */ /* 0x0000000189601160-0x0000000189601180 */ get => default; /* [XID] */ /* 0x0000000189608B70-0x0000000189608B90 */ private set {} } // 0x0000000184EDBCF0-0x0000000184EDBD90 0x0000000184EDC3D0-0x0000000184EDC480
	public CoopCondGroup showCond { /* [XID] */ /* 0x0000000189610390-0x00000001896103B0 */ get => default; /* [XID] */ /* 0x0000000189617630-0x0000000189617650 */ private set {} } // 0x0000000184EDADB0-0x0000000184EDAE50 0x0000000184EDBD90-0x0000000184EDBE40
	public CoopCondGroup enableCond { /* [XID] */ /* 0x000000018961F1C0-0x000000018961F1E0 */ get => default; /* [XID] */ /* 0x0000000189626600-0x0000000189626620 */ private set {} } // 0x0000000184EDB0A0-0x0000000184EDB140 0x0000000184EDB850-0x0000000184EDB900

	// Constructors
	public CoopSelectNodeContent() {} // 0x0000000184EDC520-0x0000000184EDC5D0

	// Methods
	// [XID] // 0x000000018962DEF0-0x000000018962DF10
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184EDC140-0x0000000184EDC290
	// [XID] // 0x0000000189635BD0-0x0000000189635BF0
	public void InitEmpty() {} // 0x0000000184EDB900-0x0000000184EDB9F0
	[BlackList] // 0x000000018963D270-0x000000018963D2B0
	// [XID] // 0x000000018963D270-0x000000018963D2B0
	public bool FromJson(JSONNode node) => default; // 0x0000000184EDB4D0-0x0000000184EDB850
	// [XID] // 0x0000000189647810-0x0000000189647830
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184EDA730-0x0000000184EDAAE0
	// [XID] // 0x000000018964EDC0-0x000000018964EDE0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7AF5 */, bool useObjectPool = false /* Metadata: 0x00AF7AF9 */) => default; // 0x0000000184EDB9F0-0x0000000184EDBCF0
	// [XID] // 0x0000000189656690-0x00000001896566B0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7AFA */, bool useObjectPool = false /* Metadata: 0x00AF7AFE */) => default; // 0x0000000184EDB140-0x0000000184EDB4D0
	[BlackList] // 0x000000018965DD90-0x000000018965DDD0
	// [XID] // 0x000000018965DD90-0x000000018965DDD0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184EDAAE0-0x0000000184EDADB0
	// [XID] // 0x0000000189668720-0x0000000189668740
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184EDBE40-0x0000000184EDC140
	[BlackList] // 0x0000000189670290-0x00000001896702D0
	// [XID] // 0x0000000189670290-0x00000001896702D0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184EDAE50-0x0000000184EDAEF0
	[BlackList] // 0x000000018967A8E0-0x000000018967A920
	// [XID] // 0x000000018967A8E0-0x000000018967A920
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184EDAEF0-0x0000000184EDB0A0
	[BlackList] // 0x0000000189685160-0x00000001896851A0
	// [XID] // 0x0000000189685160-0x00000001896851A0
	public virtual void ReturnToObjectPool() {} // 0x0000000184EDC480-0x0000000184EDC520
	[BlackList] // 0x000000018968FFC0-0x0000000189690000
	// [XID] // 0x000000018968FFC0-0x0000000189690000
	public virtual void OnPoolAllocated() {} // 0x0000000184EDC330-0x0000000184EDC3D0
	[BlackList] // 0x000000018969A510-0x000000018969A550
	// [XID] // 0x000000018969A510-0x000000018969A550
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184EDC290-0x0000000184EDC330
}

