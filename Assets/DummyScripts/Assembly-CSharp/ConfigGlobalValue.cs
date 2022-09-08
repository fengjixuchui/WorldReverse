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
public class ConfigGlobalValue : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17957
{
	// Fields
	private string[] _serverGlobalValues; // 0x10

	// Properties
	public string[] serverGlobalValues { /* [XID] */ /* 0x00000001899A2FD0-0x00000001899A2FF0 */ get => default; /* [XID] */ /* 0x00000001899AAAC0-0x00000001899AAAE0 */ private set {} } // 0x0000000183D1E5A0-0x0000000183D1E640 0x0000000183D1DDA0-0x0000000183D1DE50

	// Constructors
	public ConfigGlobalValue() {} // 0x0000000183D1EAF0-0x0000000183D1EB50

	// Methods
	// [XID] // 0x00000001899B24B0-0x00000001899B24D0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183D1E830-0x0000000183D1E910
	// [XID] // 0x00000001899B97D0-0x00000001899B97F0
	public void InitEmpty() {} // 0x0000000183D1E1D0-0x0000000183D1E2A0
	[BlackList] // 0x00000001899C1290-0x00000001899C12D0
	// [XID] // 0x00000001899C1290-0x00000001899C12D0
	public bool FromJson(JSONNode node) => default; // 0x0000000183D1DE50-0x0000000183D1E1D0
	// [XID] // 0x00000001899CBC00-0x00000001899CBC20
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183D1D5A0-0x0000000183D1D780
	// [XID] // 0x00000001899D3050-0x00000001899D3070
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF84C9 */, bool useObjectPool = false /* Metadata: 0x00AF84CD */) => default; // 0x0000000183D1E2A0-0x0000000183D1E5A0
	// [XID] // 0x00000001899DA640-0x00000001899DA660
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF84CE */, bool useObjectPool = false /* Metadata: 0x00AF84D2 */) => default; // 0x0000000183D1DB90-0x0000000183D1DDA0
	[BlackList] // 0x00000001899E2080-0x00000001899E20C0
	// [XID] // 0x00000001899E2080-0x00000001899E20C0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183D1D780-0x0000000183D1DA50
	// [XID] // 0x00000001899EC570-0x00000001899EC590
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183D1E640-0x0000000183D1E830
	[BlackList] // 0x00000001899F42D0-0x00000001899F4310
	// [XID] // 0x00000001899F42D0-0x00000001899F4310
	public virtual void AutoAllocTypeFields() {} // 0x0000000183D1DA50-0x0000000183D1DAF0
	[BlackList] // 0x00000001899FE5D0-0x00000001899FE610
	// [XID] // 0x00000001899FE5D0-0x00000001899FE610
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183D1DAF0-0x0000000183D1DB90
	[BlackList] // 0x0000000189A08A70-0x0000000189A08AB0
	// [XID] // 0x0000000189A08A70-0x0000000189A08AB0
	public virtual void ReturnToObjectPool() {} // 0x0000000183D1EA50-0x0000000183D1EAF0
	[BlackList] // 0x0000000189A131E0-0x0000000189A13220
	// [XID] // 0x0000000189A131E0-0x0000000189A13220
	public virtual void OnPoolAllocated() {} // 0x0000000183D1E9B0-0x0000000183D1EA50
	[BlackList] // 0x0000000189A1D480-0x0000000189A1D4C0
	// [XID] // 0x0000000189A1D480-0x0000000189A1D4C0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183D1E910-0x0000000183D1E9B0
}

