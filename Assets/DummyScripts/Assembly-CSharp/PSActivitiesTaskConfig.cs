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
public class PSActivitiesTaskConfig : PSActivitiesBaseConfig, IAutoAllocRecycle // TypeDefIndex: 15959
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 activityIDRawNum; // 0x20
	protected uint _taskNameTextMapHash; // 0x24
	protected bool _isRequiredForCompletion; // 0x28
	protected bool _hidden; // 0x29

	// Properties
	public uint activityID { /* [XID] */ /* 0x00000001899B40E0-0x00000001899B4100 */ get => default; /* [XID] */ /* 0x00000001899BB550-0x00000001899BB570 */ protected set {} } // 0x0000000183609D70-0x0000000183609E40 0x0000000183609340-0x0000000183609420
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint taskNameTextMapHash { /* [XID] */ /* 0x00000001899C30E0-0x00000001899C3100 */ get => default; /* [XID] */ /* 0x00000001899CA500-0x00000001899CA520 */ protected set {} } // 0x00000001836092A0-0x0000000183609340 0x000000018360A530-0x000000018360A5E0
	public string taskName { /* [XID] */ /* 0x00000001899D1CC0-0x00000001899D1CE0 */ get => default; } // 0x000000018360A5E0-0x000000018360A760 
	public bool isRequiredForCompletion { /* [XID] */ /* 0x00000001899D9130-0x00000001899D9150 */ get => default; /* [XID] */ /* 0x00000001899E0920-0x00000001899E0940 */ protected set {} } // 0x0000000183609420-0x00000001836094C0 0x00000001836091F0-0x00000001836092A0
	public bool hidden { /* [XID] */ /* 0x00000001899E83C0-0x00000001899E83E0 */ get => default; /* [XID] */ /* 0x00000001899EFA10-0x00000001899EFA30 */ protected set {} } // 0x000000018360A760-0x000000018360A800 0x000000018360A860-0x000000018360A910

	// Constructors
	public PSActivitiesTaskConfig() {} // 0x000000018360A9B0-0x000000018360AA10

	// Methods
	// [IDTag] // 0x00000001899F71B0-0x00000001899F71F0
	// [XID] // 0x00000001899F71B0-0x00000001899F71F0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183609520-0x0000000183609950
	// [IDTag] // 0x0000000189A013F0-0x0000000189A01430
	// [XID] // 0x0000000189A013F0-0x0000000189A01430
	public override bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183609950-0x0000000183609D70
	// [XID] // 0x0000000189A0BD30-0x0000000189A0BD50
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2C48 */, bool useObjectPool = false /* Metadata: 0x00AF2C4C */) => default; // 0x0000000183609F30-0x000000018360A530
	[BlackList] // 0x0000000189A135C0-0x0000000189A13600
	// [XID] // 0x0000000189A135C0-0x0000000189A13600
	public override void AutoAllocTypeFields() {} // 0x0000000183608FD0-0x0000000183609070
	[BlackList] // 0x0000000189A1D980-0x0000000189A1D9C0
	// [XID] // 0x0000000189A1D980-0x0000000189A1D9C0
	public override void AutoRecycleTypeFields() {} // 0x0000000183609070-0x0000000183609150
	[BlackList] // 0x0000000189A27CE0-0x0000000189A27D20
	// [XID] // 0x0000000189A27CE0-0x0000000189A27D20
	public override void ReturnToObjectPool() {} // 0x000000018360A910-0x000000018360A9B0
}

