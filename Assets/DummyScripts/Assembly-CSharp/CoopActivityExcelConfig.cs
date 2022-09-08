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
public class CoopActivityExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15464
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 activityIdRawNum; // 0x10
	protected SimpleSafeUInt32 avatarIdRawNum; // 0x14
	protected string _prefabPath; // 0x18
	protected uint _activityNameTextMapHash; // 0x20
	protected uint _activityDesTextMapHash; // 0x24

	// Properties
	public uint activityId { /* [XID] */ /* 0x0000000189655480-0x00000001896554A0 */ get => default; /* [XID] */ /* 0x000000018965CC20-0x000000018965CC40 */ protected set {} } // 0x00000001828230B0-0x0000000182823180 0x0000000182822A80-0x0000000182822B60
	public uint avatarId { /* [XID] */ /* 0x0000000189664140-0x0000000189664160 */ get => default; /* [XID] */ /* 0x000000018966B7A0-0x000000018966B7C0 */ protected set {} } // 0x00000001828227C0-0x0000000182822890 0x0000000182821BC0-0x0000000182821CA0
	public string prefabPath { /* [XID] */ /* 0x0000000189673560-0x0000000189673580 */ get => default; /* [XID] */ /* 0x000000018967ADA0-0x000000018967ADC0 */ protected set {} } // 0x0000000182822890-0x0000000182822930 0x00000001828229D0-0x0000000182822A80
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint activityNameTextMapHash { /* [XID] */ /* 0x0000000189682630-0x0000000189682650 */ get => default; /* [XID] */ /* 0x000000018968A0F0-0x000000018968A110 */ protected set {} } // 0x0000000182823230-0x00000001828232D0 0x0000000182823180-0x0000000182823230
	public string activityName { /* [XID] */ /* 0x0000000189691E90-0x0000000189691EB0 */ get => default; } // 0x00000001828232D0-0x0000000182823450 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint activityDesTextMapHash { /* [XID] */ /* 0x00000001896993C0-0x00000001896993E0 */ get => default; /* [XID] */ /* 0x00000001896A0830-0x00000001896A0850 */ protected set {} } // 0x0000000182822930-0x00000001828229D0 0x0000000182822710-0x00000001828227C0
	public string activityDes { /* [XID] */ /* 0x00000001896A7E20-0x00000001896A7E40 */ get => default; } // 0x0000000182821CA0-0x0000000182821E20 

	// Constructors
	public CoopActivityExcelConfig() {} // 0x0000000182823630-0x0000000182823690

	// Methods
	// [IDTag] // 0x00000001896AF270-0x00000001896AF2B0
	// [XID] // 0x00000001896AF270-0x00000001896AF2B0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182821FB0-0x0000000182822370
	// [IDTag] // 0x00000001896B9730-0x00000001896B9770
	// [XID] // 0x00000001896B9730-0x00000001896B9770
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182822370-0x0000000182822710
	// [XID] // 0x00000001896C3AA0-0x00000001896C3AC0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1B36 */, bool useObjectPool = false /* Metadata: 0x00AF1B3A */) => default; // 0x0000000182822B60-0x00000001828230B0
	[BlackList] // 0x00000001896CAF70-0x00000001896CAFB0
	// [XID] // 0x00000001896CAF70-0x00000001896CAFB0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182821E20-0x0000000182821EC0
	[BlackList] // 0x00000001896D5720-0x00000001896D5760
	// [XID] // 0x00000001896D5720-0x00000001896D5760
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182821EC0-0x0000000182821FB0
	[BlackList] // 0x00000001896DFEE0-0x00000001896DFF20
	// [XID] // 0x00000001896DFEE0-0x00000001896DFF20
	public virtual void ReturnToObjectPool() {} // 0x0000000182823590-0x0000000182823630
	[BlackList] // 0x00000001896EA340-0x00000001896EA380
	// [XID] // 0x00000001896EA340-0x00000001896EA380
	public virtual void OnPoolAllocated() {} // 0x00000001828234F0-0x0000000182823590
	[BlackList] // 0x00000001896F4820-0x00000001896F4860
	// [XID] // 0x00000001896F4820-0x00000001896F4860
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182823450-0x00000001828234F0
}

