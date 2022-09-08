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
public class AnimatorFloat : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18862
{
	// Fields
	private string _name; // 0x10
	private SimpleSafeFloat valueRawNum; // 0x18

	// Properties
	public string name { /* [XID] */ /* 0x0000000189821CB0-0x0000000189821CD0 */ get => default; /* [XID] */ /* 0x00000001898291B0-0x00000001898291D0 */ private set {} } // 0x0000000182FD57D0-0x0000000182FD5870 0x0000000182FD4E90-0x0000000182FD4F40
	public float value { /* [XID] */ /* 0x0000000189830760-0x0000000189830780 */ get => default; /* [XID] */ /* 0x0000000189837D20-0x0000000189837D40 */ private set {} } // 0x0000000182FD4A30-0x0000000182FD4B10 0x0000000182FD4950-0x0000000182FD4A30

	// Constructors
	public AnimatorFloat() {} // 0x0000000182FD5910-0x0000000182FD5970

	// Methods
	// [XID] // 0x000000018983F490-0x000000018983F4B0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182FD5580-0x0000000182FD5690
	// [XID] // 0x0000000189846B50-0x0000000189846B70
	public void InitEmpty() {} // 0x0000000182FD4F40-0x0000000182FD5040
	[BlackList] // 0x000000018984E1C0-0x000000018984E200
	// [XID] // 0x000000018984E1C0-0x000000018984E200
	public bool FromJson(JSONNode node) => default; // 0x0000000182FD4B10-0x0000000182FD4E90
	// [XID] // 0x0000000189858560-0x0000000189858580
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182FD3F20-0x0000000182FD4240
	// [XID] // 0x000000018985F570-0x000000018985F590
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB171 */, bool useObjectPool = false /* Metadata: 0x00AFB175 */) => default; // 0x0000000182FD5040-0x0000000182FD5340
	// [XID] // 0x0000000189866DD0-0x0000000189866DF0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB176 */, bool useObjectPool = false /* Metadata: 0x00AFB17A */) => default; // 0x0000000182FD4690-0x0000000182FD4950
	[BlackList] // 0x000000018986E5D0-0x000000018986E610
	// [XID] // 0x000000018986E5D0-0x000000018986E610
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182FD4240-0x0000000182FD4510
	// [XID] // 0x0000000189878B10-0x0000000189878B30
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182FD5340-0x0000000182FD5580
	[BlackList] // 0x0000000189880120-0x0000000189880160
	// [XID] // 0x0000000189880120-0x0000000189880160
	public virtual void AutoAllocTypeFields() {} // 0x0000000182FD4510-0x0000000182FD45B0
	[BlackList] // 0x000000018988A3B0-0x000000018988A3F0
	// [XID] // 0x000000018988A3B0-0x000000018988A3F0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182FD45B0-0x0000000182FD4690
	[BlackList] // 0x0000000189894930-0x0000000189894970
	// [XID] // 0x0000000189894930-0x0000000189894970
	public virtual void ReturnToObjectPool() {} // 0x0000000182FD5870-0x0000000182FD5910
	[BlackList] // 0x000000018989EC20-0x000000018989EC60
	// [XID] // 0x000000018989EC20-0x000000018989EC60
	public virtual void OnPoolAllocated() {} // 0x0000000182FD5730-0x0000000182FD57D0
	[BlackList] // 0x00000001898A94B0-0x00000001898A94F0
	// [XID] // 0x00000001898A94B0-0x00000001898A94F0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182FD5690-0x0000000182FD5730
}

