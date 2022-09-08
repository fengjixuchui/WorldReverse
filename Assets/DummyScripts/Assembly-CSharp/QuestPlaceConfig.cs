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
public class QuestPlaceConfig : IAutoAllocRecycle // TypeDefIndex: 15994
{
	// Fields
	protected SimpleSafeUInt32 placeIdRawNum; // 0x10

	// Properties
	public uint placeId { /* [XID] */ /* 0x00000001898ED760-0x00000001898ED780 */ get => default; /* [XID] */ /* 0x00000001898F5000-0x00000001898F5020 */ protected set {} } // 0x000000018250A630-0x000000018250A700 0x000000018250A550-0x000000018250A630

	// Constructors
	public QuestPlaceConfig() {} // 0x000000018250A8E0-0x000000018250A940

	// Methods
	// [IDTag] // 0x00000001898FC6B0-0x00000001898FC6F0
	// [XID] // 0x00000001898FC6B0-0x00000001898FC6F0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182509EE0-0x000000018250A0E0
	// [IDTag] // 0x0000000189906FF0-0x0000000189907030
	// [XID] // 0x0000000189906FF0-0x0000000189907030
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018250A0E0-0x000000018250A290
	// [XID] // 0x0000000189911820-0x0000000189911840
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2D3D */, bool useObjectPool = false /* Metadata: 0x00AF2D41 */) => default; // 0x000000018250A290-0x000000018250A550
	[BlackList] // 0x0000000189919380-0x00000001899193C0
	// [XID] // 0x0000000189919380-0x00000001899193C0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182509D70-0x0000000182509E10
	[BlackList] // 0x0000000189923C80-0x0000000189923CC0
	// [XID] // 0x0000000189923C80-0x0000000189923CC0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182509E10-0x0000000182509EE0
	[BlackList] // 0x000000018992E250-0x000000018992E290
	// [XID] // 0x000000018992E250-0x000000018992E290
	public virtual void ReturnToObjectPool() {} // 0x000000018250A840-0x000000018250A8E0
	[BlackList] // 0x0000000189938590-0x00000001899385D0
	// [XID] // 0x0000000189938590-0x00000001899385D0
	public virtual void OnPoolAllocated() {} // 0x000000018250A7A0-0x000000018250A840
	[BlackList] // 0x0000000189942C30-0x0000000189942C70
	// [XID] // 0x0000000189942C30-0x0000000189942C70
	public virtual void OnBeforePoolRecycled() {} // 0x000000018250A700-0x000000018250A7A0
}

