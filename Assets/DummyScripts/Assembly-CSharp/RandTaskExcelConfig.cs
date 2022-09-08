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
public class RandTaskExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15998
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 IDRawNum; // 0x10
	protected uint _titleTextMapHash; // 0x14
	protected RandTaskContentType _contentType; // 0x18
	protected SimpleSafeUInt32 rewardRawNum; // 0x1C
	protected bool _needUI; // 0x20
	protected uint _targetTextMapHash; // 0x24
	protected SimpleSafeUInt32 enterDistanceRawNum; // 0x28
	protected SimpleSafeUInt32 exitDistanceRawNum; // 0x2C

	// Properties
	public uint ID { /* [XID] */ /* 0x00000001899E08C0-0x00000001899E08E0 */ get => default; /* [XID] */ /* 0x00000001899E83A0-0x00000001899E83C0 */ protected set {} } // 0x0000000183CB63C0-0x0000000183CB6490 0x0000000183CB4F00-0x0000000183CB4FE0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint titleTextMapHash { /* [XID] */ /* 0x00000001899EF9F0-0x00000001899EFA10 */ get => default; /* [XID] */ /* 0x00000001899F7190-0x00000001899F71B0 */ protected set {} } // 0x0000000183CB55F0-0x0000000183CB5690 0x0000000183CB5690-0x0000000183CB5740
	public string title { /* [XID] */ /* 0x00000001899FE870-0x00000001899FE890 */ get => default; } // 0x0000000183CB6D70-0x0000000183CB6EF0 
	public RandTaskContentType contentType { /* [XID] */ /* 0x0000000189A06150-0x0000000189A06170 */ get => default; /* [XID] */ /* 0x0000000189A0D620-0x0000000189A0D640 */ protected set {} } // 0x0000000183CB6320-0x0000000183CB63C0 0x0000000183CB61A0-0x0000000183CB6250
	public uint reward { /* [XID] */ /* 0x0000000189A14D80-0x0000000189A14DA0 */ get => default; /* [XID] */ /* 0x0000000189A1BF70-0x0000000189A1BF90 */ protected set {} } // 0x0000000183CB6250-0x0000000183CB6320 0x0000000183CB52E0-0x0000000183CB53C0
	public bool needUI { /* [XID] */ /* 0x0000000189A237A0-0x0000000189A237C0 */ get => default; /* [XID] */ /* 0x0000000189A2AC20-0x0000000189A2AC40 */ protected set {} } // 0x0000000183CB71F0-0x0000000183CB7290 0x0000000183CB53C0-0x0000000183CB5470
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint targetTextMapHash { /* [XID] */ /* 0x0000000189A32160-0x0000000189A32180 */ get => default; /* [XID] */ /* 0x0000000189A39B10-0x0000000189A39B30 */ protected set {} } // 0x0000000183CB4FE0-0x0000000183CB5080 0x0000000183CB5230-0x0000000183CB52E0
	public string target { /* [XID] */ /* 0x0000000189A41390-0x0000000189A413B0 */ get => default; } // 0x0000000183CB5470-0x0000000183CB55F0 
	public uint enterDistance { /* [XID] */ /* 0x0000000189A48A30-0x0000000189A48A50 */ get => default; /* [XID] */ /* 0x0000000189A501C0-0x0000000189A501E0 */ protected set {} } // 0x0000000183CB6560-0x0000000183CB6630 0x0000000183CB6EF0-0x0000000183CB6FD0
	public uint exitDistance { /* [XID] */ /* 0x0000000189A57750-0x0000000189A57770 */ get => default; /* [XID] */ /* 0x0000000189A5F270-0x0000000189A5F290 */ protected set {} } // 0x0000000183CB6490-0x0000000183CB6560 0x0000000183CB7110-0x0000000183CB71F0

	// Constructors
	public RandTaskExcelConfig() {} // 0x0000000183CB7330-0x0000000183CB7390

	// Methods
	// [IDTag] // 0x0000000189A66B40-0x0000000189A66B80
	// [XID] // 0x0000000189A66B40-0x0000000189A66B80
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183CB5C60-0x0000000183CB61A0
	// [IDTag] // 0x0000000189A71140-0x0000000189A71180
	// [XID] // 0x0000000189A71140-0x0000000189A71180
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183CB5740-0x0000000183CB5C60
	// [XID] // 0x0000000189A7BCE0-0x0000000189A7BD00
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2D54 */, bool useObjectPool = false /* Metadata: 0x00AF2D58 */) => default; // 0x0000000183CB6630-0x0000000183CB6D70
	[BlackList] // 0x0000000189A836A0-0x0000000189A836E0
	// [XID] // 0x0000000189A836A0-0x0000000189A836E0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183CB5080-0x0000000183CB5120
	[BlackList] // 0x0000000189A8DFF0-0x0000000189A8E030
	// [XID] // 0x0000000189A8DFF0-0x0000000189A8E030
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183CB5120-0x0000000183CB5230
	[BlackList] // 0x0000000189A98880-0x0000000189A988C0
	// [XID] // 0x0000000189A98880-0x0000000189A988C0
	public virtual void ReturnToObjectPool() {} // 0x0000000183CB7290-0x0000000183CB7330
	[BlackList] // 0x0000000189AA2A40-0x0000000189AA2A80
	// [XID] // 0x0000000189AA2A40-0x0000000189AA2A80
	public virtual void OnPoolAllocated() {} // 0x0000000183CB7070-0x0000000183CB7110
	[BlackList] // 0x0000000189AAD240-0x0000000189AAD280
	// [XID] // 0x0000000189AAD240-0x0000000189AAD280
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183CB6FD0-0x0000000183CB7070
}

