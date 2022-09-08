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
using Newtonsoft.Json;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class RoomExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16092
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected uint _nameTextMapHash; // 0x14
	protected string _prefabPath; // 0x18
	protected string _navMeshPath; // 0x20

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189715030-0x0000000189715050 */ get => default; /* [XID] */ /* 0x000000018971CB40-0x000000018971CB60 */ protected set {} } // 0x0000000184AA2460-0x0000000184AA2530 0x0000000184AA1C40-0x0000000184AA1D20
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x0000000189723ED0-0x0000000189723EF0 */ get => default; /* [XID] */ /* 0x000000018972B730-0x000000018972B750 */ protected set {} } // 0x0000000184AA1430-0x0000000184AA14D0 0x0000000184AA21D0-0x0000000184AA2280
	public string name { /* [XID] */ /* 0x0000000189732F20-0x0000000189732F40 */ get => default; } // 0x0000000184AA2530-0x0000000184AA26B0 
	public string prefabPath { /* [XID] */ /* 0x000000018973A5B0-0x000000018973A5D0 */ get => default; /* [XID] */ /* 0x0000000189741F60-0x0000000189741F80 */ protected set {} } // 0x0000000184AA1AF0-0x0000000184AA1B90 0x0000000184AA1B90-0x0000000184AA1C40
	public string navMeshPath { /* [XID] */ /* 0x00000001897499A0-0x00000001897499C0 */ get => default; /* [XID] */ /* 0x0000000189750EA0-0x0000000189750EC0 */ protected set {} } // 0x0000000184AA2280-0x0000000184AA2320 0x0000000184AA1380-0x0000000184AA1430

	// Constructors
	public RoomExcelConfig() {} // 0x0000000184AA2750-0x0000000184AA27B0

	// Methods
	// [IDTag] // 0x00000001897582F0-0x0000000189758330
	// [XID] // 0x00000001897582F0-0x0000000189758330
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184AA14D0-0x0000000184AA17F0
	// [IDTag] // 0x0000000189762C50-0x0000000189762C90
	// [XID] // 0x0000000189762C50-0x0000000189762C90
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184AA17F0-0x0000000184AA1AF0
	// [XID] // 0x000000018976D2A0-0x000000018976D2C0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3009 */, bool useObjectPool = false /* Metadata: 0x00AF300D */) => default; // 0x0000000184AA1D20-0x0000000184AA21D0
	[BlackList] // 0x00000001897746F0-0x0000000189774730
	// [XID] // 0x00000001897746F0-0x0000000189774730
	public virtual void AutoAllocTypeFields() {} // 0x0000000184AA1200-0x0000000184AA12A0
	[BlackList] // 0x000000018977EF20-0x000000018977EF60
	// [XID] // 0x000000018977EF20-0x000000018977EF60
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184AA12A0-0x0000000184AA1380
	[BlackList] // 0x0000000189789720-0x0000000189789760
	// [XID] // 0x0000000189789720-0x0000000189789760
	public virtual void ReturnToObjectPool() {} // 0x0000000184AA26B0-0x0000000184AA2750
	[BlackList] // 0x0000000189793C40-0x0000000189793C80
	// [XID] // 0x0000000189793C40-0x0000000189793C80
	public virtual void OnPoolAllocated() {} // 0x0000000184AA23C0-0x0000000184AA2460
	[BlackList] // 0x000000018979EF50-0x000000018979EF90
	// [XID] // 0x000000018979EF50-0x000000018979EF90
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184AA2320-0x0000000184AA23C0
}

