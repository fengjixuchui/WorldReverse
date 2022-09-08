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
public class NewActivityEntryConfig : IAutoAllocRecycle // TypeDefIndex: 15894
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected NewActivityType _activityType; // 0x14
	protected SimpleSafeInt32 sortPriorityRawNum; // 0x18
	protected string _tabIcon; // 0x20
	protected uint _tabNameTextMapHash; // 0x28
	protected SimpleSafeUInt32 durationRawNum; // 0x2C

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189A045F0-0x0000000189A04610 */ get => default; /* [XID] */ /* 0x0000000189A0BD70-0x0000000189A0BD90 */ protected set {} } // 0x00000001839A9C00-0x00000001839A9CD0 0x00000001839A8EB0-0x00000001839A8F90
	public NewActivityType activityType { /* [XID] */ /* 0x0000000189A13620-0x0000000189A13640 */ get => default; /* [XID] */ /* 0x0000000189A1A790-0x0000000189A1A7B0 */ protected set {} } // 0x00000001839A8E10-0x00000001839A8EB0 0x00000001839A9860-0x00000001839A9910
	public int sortPriority { /* [XID] */ /* 0x0000000189A22010-0x0000000189A22030 */ get => default; /* [XID] */ /* 0x0000000189A29460-0x0000000189A29480 */ protected set {} } // 0x00000001839A99F0-0x00000001839A9AC0 0x00000001839A9910-0x00000001839A99F0
	public string tabIcon { /* [XID] */ /* 0x0000000189A30A30-0x0000000189A30A50 */ get => default; /* [XID] */ /* 0x0000000189A38470-0x0000000189A38490 */ protected set {} } // 0x00000001839A8D70-0x00000001839A8E10 0x00000001839A9630-0x00000001839A96E0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint tabNameTextMapHash { /* [XID] */ /* 0x0000000189A3FC00-0x0000000189A3FC20 */ get => default; /* [XID] */ /* 0x0000000189A472B0-0x0000000189A472D0 */ protected set {} } // 0x00000001839A9CD0-0x00000001839A9D70 0x00000001839A8F90-0x00000001839A9040
	public string tabName { /* [XID] */ /* 0x0000000189A4EBB0-0x0000000189A4EBD0 */ get => default; } // 0x00000001839A96E0-0x00000001839A9860 
	public uint duration { /* [XID] */ /* 0x0000000189A56280-0x0000000189A562A0 */ get => default; /* [XID] */ /* 0x0000000189A5DCE0-0x0000000189A5DD00 */ protected set {} } // 0x00000001839A8340-0x00000001839A8410 0x00000001839A8C90-0x00000001839A8D70

	// Constructors
	public NewActivityEntryConfig() {} // 0x00000001839A9E10-0x00000001839A9E70

	// Methods
	// [IDTag] // 0x0000000189A654C0-0x0000000189A65500
	// [XID] // 0x0000000189A654C0-0x0000000189A65500
	public virtual bool ParseFromLine(string line) => default; // 0x00000001839A8840-0x00000001839A8C90
	// [IDTag] // 0x0000000189A6FD00-0x0000000189A6FD40
	// [XID] // 0x0000000189A6FD00-0x0000000189A6FD40
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001839A8410-0x00000001839A8840
	// [XID] // 0x0000000189A7A930-0x0000000189A7A950
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2A78 */, bool useObjectPool = false /* Metadata: 0x00AF2A7C */) => default; // 0x00000001839A9040-0x00000001839A9630
	[BlackList] // 0x0000000189A81DD0-0x0000000189A81E10
	// [XID] // 0x0000000189A81DD0-0x0000000189A81E10
	public virtual void AutoAllocTypeFields() {} // 0x00000001839A8180-0x00000001839A8220
	[BlackList] // 0x0000000189A8C850-0x0000000189A8C890
	// [XID] // 0x0000000189A8C850-0x0000000189A8C890
	public virtual void AutoRecycleTypeFields() {} // 0x00000001839A8220-0x00000001839A8340
	[BlackList] // 0x0000000189A96E40-0x0000000189A96E80
	// [XID] // 0x0000000189A96E40-0x0000000189A96E80
	public virtual void ReturnToObjectPool() {} // 0x00000001839A9D70-0x00000001839A9E10
	[BlackList] // 0x0000000189AA11A0-0x0000000189AA11E0
	// [XID] // 0x0000000189AA11A0-0x0000000189AA11E0
	public virtual void OnPoolAllocated() {} // 0x00000001839A9B60-0x00000001839A9C00
	[BlackList] // 0x0000000189AABAD0-0x0000000189AABB10
	// [XID] // 0x0000000189AABAD0-0x0000000189AABB10
	public virtual void OnBeforePoolRecycled() {} // 0x00000001839A9AC0-0x00000001839A9B60
}

