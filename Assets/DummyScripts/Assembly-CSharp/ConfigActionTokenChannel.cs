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
public class ConfigActionTokenChannel : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 16318
{
	// Fields
	private SimpleSafeInt32 maxNumRawNum; // 0x10

	// Properties
	public int maxNum { /* [XID] */ /* 0x0000000189AAA020-0x0000000189AAA040 */ get => default; /* [XID] */ /* 0x0000000189AB1E40-0x0000000189AB1E60 */ private set {} } // 0x000000018195A4E0-0x000000018195A5B0 0x000000018195A790-0x000000018195A870

	// Constructors
	public ConfigActionTokenChannel() {} // 0x000000018195AB30-0x000000018195AB90

	// Methods
	// [XID] // 0x0000000189AB90F0-0x0000000189AB9110
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018195A870-0x000000018195A950
	// [XID] // 0x0000000189AC0CD0-0x0000000189AC0CF0
	public void InitEmpty() {} // 0x000000018195A110-0x000000018195A1E0
	[BlackList] // 0x0000000189AC86F0-0x0000000189AC8730
	// [XID] // 0x0000000189AC86F0-0x0000000189AC8730
	public bool FromJson(JSONNode node) => default; // 0x0000000181959D90-0x000000018195A110
	// [XID] // 0x0000000189AD3140-0x0000000189AD3160
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181959520-0x0000000181959740
	// [XID] // 0x0000000189ADAB40-0x0000000189ADAB60
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3782 */, bool useObjectPool = false /* Metadata: 0x00AF3786 */) => default; // 0x000000018195A1E0-0x000000018195A4E0
	// [XID] // 0x0000000189AE2380-0x0000000189AE23A0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3787 */, bool useObjectPool = false /* Metadata: 0x00AF378B */) => default; // 0x0000000181959B80-0x0000000181959D90
	[BlackList] // 0x0000000189AE9C30-0x0000000189AE9C70
	// [XID] // 0x0000000189AE9C30-0x0000000189AE9C70
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181959740-0x0000000181959A10
	// [XID] // 0x0000000189AF46B0-0x0000000189AF46D0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018195A5B0-0x000000018195A790
	[BlackList] // 0x0000000189AFBC20-0x0000000189AFBC60
	// [XID] // 0x0000000189AFBC20-0x0000000189AFBC60
	public virtual void AutoAllocTypeFields() {} // 0x0000000181959A10-0x0000000181959AB0
	[BlackList] // 0x0000000189B06680-0x0000000189B066C0
	// [XID] // 0x0000000189B06680-0x0000000189B066C0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181959AB0-0x0000000181959B80
	[BlackList] // 0x0000000189B10EF0-0x0000000189B10F30
	// [XID] // 0x0000000189B10EF0-0x0000000189B10F30
	public virtual void ReturnToObjectPool() {} // 0x000000018195AA90-0x000000018195AB30
	[BlackList] // 0x0000000189B1B0C0-0x0000000189B1B100
	// [XID] // 0x0000000189B1B0C0-0x0000000189B1B100
	public virtual void OnPoolAllocated() {} // 0x000000018195A9F0-0x000000018195AA90
	[BlackList] // 0x0000000189B256E0-0x0000000189B25720
	// [XID] // 0x0000000189B256E0-0x0000000189B25720
	public virtual void OnBeforePoolRecycled() {} // 0x000000018195A950-0x000000018195A9F0
}

