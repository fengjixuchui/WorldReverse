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
public class FindHilichurlExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15130
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 activityIdRawNum; // 0x14
	protected SimpleSafeUInt32 rewardPreviewIdRawNum; // 0x18
	protected SimpleSafeUInt32 guideQuestIdRawNum; // 0x1C
	protected SimpleSafeUInt32 endQuestIdRawNum; // 0x20
	protected SimpleSafeUInt32[] _assignmentIdList; // 0x28
	protected SimpleSafeUInt32[] _HiliWeiIdList; // 0x30

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189A2AD40-0x0000000189A2AD60 */ get => default; /* [XID] */ /* 0x0000000189A32260-0x0000000189A32280 */ protected set {} } // 0x00000001843AA0C0-0x00000001843AA190 0x00000001843A9660-0x00000001843A9740
	public uint activityId { /* [XID] */ /* 0x0000000189A39CB0-0x0000000189A39CD0 */ get => default; /* [XID] */ /* 0x0000000189A414F0-0x0000000189A41510 */ protected set {} } // 0x00000001843A9EB0-0x00000001843A9F80 0x00000001843A9580-0x00000001843A9660
	public uint rewardPreviewId { /* [XID] */ /* 0x0000000189A48BB0-0x0000000189A48BD0 */ get => default; /* [XID] */ /* 0x0000000189A50300-0x0000000189A50320 */ protected set {} } // 0x00000001843A9100-0x00000001843A91D0 0x00000001843A9320-0x00000001843A9400
	public uint guideQuestId { /* [XID] */ /* 0x0000000189A578D0-0x0000000189A578F0 */ get => default; /* [XID] */ /* 0x0000000189A5F4D0-0x0000000189A5F4F0 */ protected set {} } // 0x00000001843A94B0-0x00000001843A9580 0x00000001843AA190-0x00000001843AA270
	public uint endQuestId { /* [XID] */ /* 0x0000000189A66E00-0x0000000189A66E20 */ get => default; /* [XID] */ /* 0x0000000189A6E640-0x0000000189A6E660 */ protected set {} } // 0x00000001843A9DE0-0x00000001843A9EB0 0x00000001843A7F80-0x00000001843A8060
	public SimpleSafeUInt32[] assignmentIdList { /* [XID] */ /* 0x0000000189A75CB0-0x0000000189A75CD0 */ get => default; /* [XID] */ /* 0x0000000189A7D870-0x0000000189A7D890 */ protected set {} } // 0x00000001843A91D0-0x00000001843A9270 0x00000001843A9400-0x00000001843A94B0
	public SimpleSafeUInt32[] HiliWeiIdList { /* [XID] */ /* 0x0000000189A850A0-0x0000000189A850C0 */ get => default; /* [XID] */ /* 0x0000000189A8C9D0-0x0000000189A8C9F0 */ protected set {} } // 0x00000001843A7EE0-0x00000001843A7F80 0x00000001843A9270-0x00000001843A9320

	// Constructors
	public FindHilichurlExcelConfig() {} // 0x00000001843AA310-0x00000001843AA370

	// Methods
	// [IDTag] // 0x0000000189A93D90-0x0000000189A93DD0
	// [XID] // 0x0000000189A93D90-0x0000000189A93DD0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001843A88A0-0x00000001843A9100
	// [IDTag] // 0x0000000189A9E3F0-0x0000000189A9E430
	// [XID] // 0x0000000189A9E3F0-0x0000000189A9E430
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001843A8060-0x00000001843A88A0
	// [XID] // 0x0000000189AA8A60-0x0000000189AA8A80
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF019E */, bool useObjectPool = false /* Metadata: 0x00AF01A2 */) => default; // 0x00000001843A9740-0x00000001843A9DE0
	[BlackList] // 0x0000000189AB0620-0x0000000189AB0660
	// [XID] // 0x0000000189AB0620-0x0000000189AB0660
	public virtual void AutoAllocTypeFields() {} // 0x00000001843A7D10-0x00000001843A7DB0
	[BlackList] // 0x0000000189ABB350-0x0000000189ABB390
	// [XID] // 0x0000000189ABB350-0x0000000189ABB390
	public virtual void AutoRecycleTypeFields() {} // 0x00000001843A7DB0-0x00000001843A7EE0
	[BlackList] // 0x0000000189AC5C10-0x0000000189AC5C50
	// [XID] // 0x0000000189AC5C10-0x0000000189AC5C50
	public virtual void ReturnToObjectPool() {} // 0x00000001843AA270-0x00000001843AA310
	[BlackList] // 0x0000000189ACFFF0-0x0000000189AD0030
	// [XID] // 0x0000000189ACFFF0-0x0000000189AD0030
	public virtual void OnPoolAllocated() {} // 0x00000001843AA020-0x00000001843AA0C0
	[BlackList] // 0x0000000189ADADE0-0x0000000189ADAE20
	// [XID] // 0x0000000189ADADE0-0x0000000189ADAE20
	public virtual void OnBeforePoolRecycled() {} // 0x00000001843A9F80-0x00000001843AA020
}

