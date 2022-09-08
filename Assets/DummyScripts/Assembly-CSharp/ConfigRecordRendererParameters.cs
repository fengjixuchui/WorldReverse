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
public class ConfigRecordRendererParameters : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18873
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private RecordRendererGlobalParameters _globalParameter; // 0x10

	// Properties
	public RecordRendererGlobalParameters globalParameter { /* [XID] */ /* 0x0000000189969700-0x0000000189969720 */ get => default; /* [XID] */ /* 0x0000000189971400-0x0000000189971420 */ private set {} } // 0x0000000184739D60-0x0000000184739E00 0x0000000184739BE0-0x0000000184739C90

	// Constructors
	public ConfigRecordRendererParameters() {} // 0x000000018473A5A0-0x000000018473A600

	// Methods
	// [XID] // 0x0000000189978DB0-0x0000000189978DD0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018473A2E0-0x000000018473A3C0
	// [XID] // 0x000000018997FE80-0x000000018997FEA0
	public void InitEmpty() {} // 0x0000000184739C90-0x0000000184739D60
	[BlackList] // 0x0000000189987670-0x00000001899876B0
	// [XID] // 0x0000000189987670-0x00000001899876B0
	public bool FromJson(JSONNode node) => default; // 0x0000000184739860-0x0000000184739BE0
	// [XID] // 0x0000000189992350-0x0000000189992370
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184738F80-0x0000000184739180
	// [XID] // 0x000000018999A110-0x000000018999A130
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB1DF */, bool useObjectPool = false /* Metadata: 0x00AFB1E3 */) => default; // 0x0000000184739E00-0x000000018473A100
	// [XID] // 0x00000001899A1750-0x00000001899A1770
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB1E4 */, bool useObjectPool = false /* Metadata: 0x00AFB1E8 */) => default; // 0x0000000184739610-0x0000000184739860
	[BlackList] // 0x00000001899A90E0-0x00000001899A9120
	// [XID] // 0x00000001899A90E0-0x00000001899A9120
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184739180-0x0000000184739450
	// [XID] // 0x00000001899B3AC0-0x00000001899B3AE0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018473A100-0x000000018473A2E0
	[BlackList] // 0x00000001899BAF50-0x00000001899BAF90
	// [XID] // 0x00000001899BAF50-0x00000001899BAF90
	public virtual void AutoAllocTypeFields() {} // 0x0000000184739450-0x00000001847394F0
	[BlackList] // 0x00000001899C59B0-0x00000001899C59F0
	// [XID] // 0x00000001899C59B0-0x00000001899C59F0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001847394F0-0x0000000184739610
	[BlackList] // 0x00000001899D00F0-0x00000001899D0130
	// [XID] // 0x00000001899D00F0-0x00000001899D0130
	public virtual void ReturnToObjectPool() {} // 0x000000018473A500-0x000000018473A5A0
	[BlackList] // 0x00000001899DA4A0-0x00000001899DA4E0
	// [XID] // 0x00000001899DA4A0-0x00000001899DA4E0
	public virtual void OnPoolAllocated() {} // 0x000000018473A460-0x000000018473A500
	[BlackList] // 0x00000001899E5020-0x00000001899E5060
	// [XID] // 0x00000001899E5020-0x00000001899E5060
	public virtual void OnBeforePoolRecycled() {} // 0x000000018473A3C0-0x000000018473A460
}

