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
public class TransPointUpdateMaterial : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18035
{
	// Fields
	private SimpleSafeUInt32 levelRawNum; // 0x10
	private string _matPath; // 0x18
	private string[] _transforms; // 0x20

	// Properties
	public uint level { /* [XID] */ /* 0x0000000189880D50-0x0000000189880D70 */ get => default; /* [XID] */ /* 0x0000000189815B90-0x0000000189815BB0 */ private set {} } // 0x00000001814D43D0-0x00000001814D44A0 0x00000001814D42F0-0x00000001814D43D0
	public string matPath { /* [XID] */ /* 0x000000018981D630-0x000000018981D650 */ get => default; /* [XID] */ /* 0x0000000189824B20-0x0000000189824B40 */ private set {} } // 0x00000001814D38C0-0x00000001814D3960 0x00000001814D4240-0x00000001814D42F0
	public string[] transforms { /* [XID] */ /* 0x000000018982C4D0-0x000000018982C4F0 */ get => default; /* [XID] */ /* 0x00000001898339A0-0x00000001898339C0 */ private set {} } // 0x00000001814D3D90-0x00000001814D3E30 0x00000001814D3CE0-0x00000001814D3D90

	// Constructors
	public TransPointUpdateMaterial() {} // 0x00000001814D4AC0-0x00000001814D4B20

	// Methods
	// [XID] // 0x000000018983AF20-0x000000018983AF40
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001814D47C0-0x00000001814D48E0
	// [XID] // 0x0000000189842600-0x0000000189842620
	public void InitEmpty() {} // 0x00000001814D3E30-0x00000001814D3F40
	[BlackList] // 0x00000001898499B0-0x00000001898499F0
	// [XID] // 0x00000001898499B0-0x00000001898499F0
	public bool FromJson(JSONNode node) => default; // 0x00000001814D3960-0x00000001814D3CE0
	// [XID] // 0x0000000189853AA0-0x0000000189853AC0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001814D2D50-0x00000001814D3120
	// [XID] // 0x000000018985B550-0x000000018985B570
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF875F */, bool useObjectPool = false /* Metadata: 0x00AF8763 */) => default; // 0x00000001814D3F40-0x00000001814D4240
	// [XID] // 0x0000000189862AD0-0x0000000189862AF0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8764 */, bool useObjectPool = false /* Metadata: 0x00AF8768 */) => default; // 0x00000001814D3570-0x00000001814D38C0
	[BlackList] // 0x0000000189869F60-0x0000000189869FA0
	// [XID] // 0x0000000189869F60-0x0000000189869FA0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001814D3120-0x00000001814D33F0
	// [XID] // 0x00000001898740C0-0x00000001898740E0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001814D44A0-0x00000001814D47C0
	[BlackList] // 0x000000018987BB80-0x000000018987BBC0
	// [XID] // 0x000000018987BB80-0x000000018987BBC0
	public virtual void AutoAllocTypeFields() {} // 0x00000001814D33F0-0x00000001814D3490
	[BlackList] // 0x00000001898860C0-0x0000000189886100
	// [XID] // 0x00000001898860C0-0x0000000189886100
	public virtual void AutoRecycleTypeFields() {} // 0x00000001814D3490-0x00000001814D3570
	[BlackList] // 0x00000001898902C0-0x0000000189890300
	// [XID] // 0x00000001898902C0-0x0000000189890300
	public virtual void ReturnToObjectPool() {} // 0x00000001814D4A20-0x00000001814D4AC0
	[BlackList] // 0x000000018989AB10-0x000000018989AB50
	// [XID] // 0x000000018989AB10-0x000000018989AB50
	public virtual void OnPoolAllocated() {} // 0x00000001814D4980-0x00000001814D4A20
	[BlackList] // 0x00000001898A4FE0-0x00000001898A5020
	// [XID] // 0x00000001898A4FE0-0x00000001898A5020
	public virtual void OnBeforePoolRecycled() {} // 0x00000001814D48E0-0x00000001814D4980
}

