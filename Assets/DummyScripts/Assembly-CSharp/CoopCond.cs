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
public class CoopCond : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17744
{
	// Fields
	private CoopCondType _type; // 0x10
	private int[] _param; // 0x18

	// Properties
	public CoopCondType type { /* [XID] */ /* 0x00000001897C3490-0x00000001897C34B0 */ get => default; /* [XID] */ /* 0x00000001897CAC70-0x00000001897CAC90 */ private set {} } // 0x0000000180CB64B0-0x0000000180CB6550 0x0000000180CB5F40-0x0000000180CB5FF0
	public int[] param { /* [XID] */ /* 0x00000001897D22F0-0x00000001897D2310 */ get => default; /* [XID] */ /* 0x00000001897DA0B0-0x00000001897DA0D0 */ private set {} } // 0x0000000180CB6600-0x0000000180CB66A0 0x0000000180CB6550-0x0000000180CB6600

	// Constructors
	public CoopCond() {} // 0x0000000180CB6740-0x0000000180CB67A0

	// Methods
	// [XID] // 0x00000001897E1460-0x00000001897E1480
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000180CB6260-0x0000000180CB6370
	// [XID] // 0x00000001897E8CB0-0x00000001897E8CD0
	public void InitEmpty() {} // 0x0000000180CB5B70-0x0000000180CB5C40
	[BlackList] // 0x00000001897F08C0-0x00000001897F0900
	// [XID] // 0x00000001897F08C0-0x00000001897F0900
	public bool FromJson(JSONNode node) => default; // 0x0000000180CB57F0-0x0000000180CB5B70
	// [XID] // 0x00000001897FB2B0-0x00000001897FB2D0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000180CB4E80-0x0000000180CB5140
	// [XID] // 0x0000000189802700-0x0000000189802720
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7AA7 */, bool useObjectPool = false /* Metadata: 0x00AF7AAB */) => default; // 0x0000000180CB5C40-0x0000000180CB5F40
	// [XID] // 0x0000000189809CF0-0x0000000189809D10
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7AAC */, bool useObjectPool = false /* Metadata: 0x00AF7AB0 */) => default; // 0x0000000180CB5550-0x0000000180CB57F0
	[BlackList] // 0x0000000189811480-0x00000001898114C0
	// [XID] // 0x0000000189811480-0x00000001898114C0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000180CB5140-0x0000000180CB5410
	// [XID] // 0x000000018981BDA0-0x000000018981BDC0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000180CB5FF0-0x0000000180CB6260
	[BlackList] // 0x0000000189823250-0x0000000189823290
	// [XID] // 0x0000000189823250-0x0000000189823290
	public virtual void AutoAllocTypeFields() {} // 0x0000000180CB5410-0x0000000180CB54B0
	[BlackList] // 0x000000018982D8E0-0x000000018982D920
	// [XID] // 0x000000018982D8E0-0x000000018982D920
	public virtual void AutoRecycleTypeFields() {} // 0x0000000180CB54B0-0x0000000180CB5550
	[BlackList] // 0x0000000189837F20-0x0000000189837F60
	// [XID] // 0x0000000189837F20-0x0000000189837F60
	public virtual void ReturnToObjectPool() {} // 0x0000000180CB66A0-0x0000000180CB6740
	[BlackList] // 0x00000001898426C0-0x0000000189842700
	// [XID] // 0x00000001898426C0-0x0000000189842700
	public virtual void OnPoolAllocated() {} // 0x0000000180CB6410-0x0000000180CB64B0
	[BlackList] // 0x000000018984CA40-0x000000018984CA80
	// [XID] // 0x000000018984CA40-0x000000018984CA80
	public virtual void OnBeforePoolRecycled() {} // 0x0000000180CB6370-0x0000000180CB6410
}

