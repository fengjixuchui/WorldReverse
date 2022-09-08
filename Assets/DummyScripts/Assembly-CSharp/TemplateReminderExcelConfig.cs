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
public class TemplateReminderExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16035
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected TemplateReminderStyleType _style; // 0x14
	protected string _icon; // 0x18
	protected uint _titleTextMapHash; // 0x20
	protected uint _contentTextMapHash; // 0x24
	protected NewActivityType _activityType; // 0x28
	protected SimpleSafeFloat showTimeRawNum; // 0x2C

	// Properties
	public uint id { /* [XID] */ /* 0x00000001896462C0-0x00000001896462E0 */ get => default; /* [XID] */ /* 0x000000018964DB00-0x000000018964DB20 */ protected set {} } // 0x00000001851E11A0-0x00000001851E1270 0x00000001851E0100-0x00000001851E01E0
	public TemplateReminderStyleType style { /* [XID] */ /* 0x0000000189655320-0x0000000189655340 */ get => default; /* [XID] */ /* 0x000000018965CB80-0x000000018965CBA0 */ protected set {} } // 0x00000001851E0D80-0x00000001851E0E20 0x00000001851E0ED0-0x00000001851E0F80
	public string icon { /* [XID] */ /* 0x0000000189664060-0x0000000189664080 */ get => default; /* [XID] */ /* 0x000000018966B6C0-0x000000018966B6E0 */ protected set {} } // 0x00000001851DF250-0x00000001851DF2F0 0x00000001851E0CD0-0x00000001851E0D80
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint titleTextMapHash { /* [XID] */ /* 0x00000001896734C0-0x00000001896734E0 */ get => default; /* [XID] */ /* 0x000000018967ACC0-0x000000018967ACE0 */ protected set {} } // 0x00000001851DF4A0-0x00000001851DF540 0x00000001851DF540-0x00000001851DF5F0
	public string title { /* [XID] */ /* 0x00000001896825D0-0x00000001896825F0 */ get => default; } // 0x00000001851E0B50-0x00000001851E0CD0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint contentTextMapHash { /* [XID] */ /* 0x0000000189689F90-0x0000000189689FB0 */ get => default; /* [XID] */ /* 0x0000000189691D30-0x0000000189691D50 */ protected set {} } // 0x00000001851E0AB0-0x00000001851E0B50 0x00000001851E01E0-0x00000001851E0290
	public string content { /* [XID] */ /* 0x0000000189699260-0x0000000189699280 */ get => default; } // 0x00000001851E0930-0x00000001851E0AB0 
	public NewActivityType activityType { /* [XID] */ /* 0x00000001896A0790-0x00000001896A07B0 */ get => default; /* [XID] */ /* 0x00000001896A7CE0-0x00000001896A7D00 */ protected set {} } // 0x00000001851E0060-0x00000001851E0100 0x00000001851E0E20-0x00000001851E0ED0
	public float showTime { /* [XID] */ /* 0x00000001896AF130-0x00000001896AF150 */ get => default; /* [XID] */ /* 0x00000001896B6680-0x00000001896B66A0 */ protected set {} } // 0x00000001851DFF80-0x00000001851E0060 0x00000001851E0F80-0x00000001851E1060

	// Constructors
	public TemplateReminderExcelConfig() {} // 0x00000001851E1310-0x00000001851E1370

	// Methods
	// [IDTag] // 0x00000001896BD980-0x00000001896BD9C0
	// [XID] // 0x00000001896BD980-0x00000001896BD9C0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001851DFAB0-0x00000001851DFF80
	// [IDTag] // 0x00000001896C8070-0x00000001896C80B0
	// [XID] // 0x00000001896C8070-0x00000001896C80B0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001851DF5F0-0x00000001851DFAB0
	// [XID] // 0x00000001896D2420-0x00000001896D2440
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2E7D */, bool useObjectPool = false /* Metadata: 0x00AF2E81 */) => default; // 0x00000001851E0290-0x00000001851E0930
	[BlackList] // 0x00000001896D9E30-0x00000001896D9E70
	// [XID] // 0x00000001896D9E30-0x00000001896D9E70
	public virtual void AutoAllocTypeFields() {} // 0x00000001851DF2F0-0x00000001851DF390
	[BlackList] // 0x00000001896E43D0-0x00000001896E4410
	// [XID] // 0x00000001896E43D0-0x00000001896E4410
	public virtual void AutoRecycleTypeFields() {} // 0x00000001851DF390-0x00000001851DF4A0
	[BlackList] // 0x00000001896EE6B0-0x00000001896EE6F0
	// [XID] // 0x00000001896EE6B0-0x00000001896EE6F0
	public virtual void ReturnToObjectPool() {} // 0x00000001851E1270-0x00000001851E1310
	[BlackList] // 0x00000001896F8B60-0x00000001896F8BA0
	// [XID] // 0x00000001896F8B60-0x00000001896F8BA0
	public virtual void OnPoolAllocated() {} // 0x00000001851E1100-0x00000001851E11A0
	[BlackList] // 0x0000000189703550-0x0000000189703590
	// [XID] // 0x0000000189703550-0x0000000189703590
	public virtual void OnBeforePoolRecycled() {} // 0x00000001851E1060-0x00000001851E1100
}

