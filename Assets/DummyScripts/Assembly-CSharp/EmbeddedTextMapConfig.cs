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
public class EmbeddedTextMapConfig : IAutoAllocRecycle // TypeDefIndex: 15565
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected string _textMapId; // 0x10
	protected uint _textMapContentTextMapHash; // 0x18

	// Properties
	public string textMapId { /* [XID] */ /* 0x00000001896C3A60-0x00000001896C3A80 */ get => default; /* [XID] */ /* 0x00000001896CAED0-0x00000001896CAEF0 */ protected set {} } // 0x0000000183ED1840-0x0000000183ED18E0 0x0000000183ED1640-0x0000000183ED16F0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint textMapContentTextMapHash { /* [XID] */ /* 0x00000001896D2500-0x00000001896D2520 */ get => default; /* [XID] */ /* 0x00000001896D9F70-0x00000001896D9F90 */ protected set {} } // 0x0000000183ED17A0-0x0000000183ED1840 0x0000000183ED16F0-0x0000000183ED17A0
	public string textMapContent { /* [XID] */ /* 0x0000000189A21040-0x0000000189A21060 */ get => default; } // 0x0000000183ED14C0-0x0000000183ED1640 

	// Constructors
	public EmbeddedTextMapConfig() {} // 0x0000000183ED1E30-0x0000000183ED1E90

	// Methods
	// [IDTag] // 0x00000001896E8900-0x00000001896E8940
	// [XID] // 0x00000001896E8900-0x00000001896E8940
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183ED1250-0x0000000183ED14C0
	// [IDTag] // 0x00000001896F2DF0-0x00000001896F2E30
	// [XID] // 0x00000001896F2DF0-0x00000001896F2E30
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183ED1020-0x0000000183ED1250
	// [XID] // 0x00000001896FD7F0-0x00000001896FD810
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1F3E */, bool useObjectPool = false /* Metadata: 0x00AF1F42 */) => default; // 0x0000000183ED18E0-0x0000000183ED1C50
	[BlackList] // 0x0000000189704D30-0x0000000189704D70
	// [XID] // 0x0000000189704D30-0x0000000189704D70
	public virtual void AutoAllocTypeFields() {} // 0x0000000183ED0EE0-0x0000000183ED0F80
	[BlackList] // 0x000000018970F780-0x000000018970F7C0
	// [XID] // 0x000000018970F780-0x000000018970F7C0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183ED0F80-0x0000000183ED1020
	[BlackList] // 0x0000000189719E30-0x0000000189719E70
	// [XID] // 0x0000000189719E30-0x0000000189719E70
	public virtual void ReturnToObjectPool() {} // 0x0000000183ED1D90-0x0000000183ED1E30
	[BlackList] // 0x0000000189724050-0x0000000189724090
	// [XID] // 0x0000000189724050-0x0000000189724090
	public virtual void OnPoolAllocated() {} // 0x0000000183ED1CF0-0x0000000183ED1D90
	[BlackList] // 0x000000018972E850-0x000000018972E890
	// [XID] // 0x000000018972E850-0x000000018972E890
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183ED1C50-0x0000000183ED1CF0
}

