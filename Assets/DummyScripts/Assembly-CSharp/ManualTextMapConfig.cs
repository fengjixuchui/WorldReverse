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
public class ManualTextMapConfig : IAutoAllocRecycle // TypeDefIndex: 16185
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected string _textMapId; // 0x10
	protected uint _textMapContentTextMapHash; // 0x18
	protected TextParamType[] _paramTypes; // 0x20

	// Properties
	public string textMapId { /* [XID] */ /* 0x000000018965E0F0-0x000000018965E110 */ get => default; /* [XID] */ /* 0x00000001896657D0-0x00000001896657F0 */ protected set {} } // 0x0000000184B84450-0x0000000184B844F0 0x0000000184B84250-0x0000000184B84300
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint textMapContentTextMapHash { /* [XID] */ /* 0x00000001896727A0-0x00000001896727C0 */ get => default; /* [XID] */ /* 0x0000000189674DB0-0x0000000189674DD0 */ protected set {} } // 0x0000000184B843B0-0x0000000184B84450 0x0000000184B84300-0x0000000184B843B0
	public string textMapContent { /* [XID] */ /* 0x000000018966AAE0-0x000000018966AB00 */ get => default; } // 0x0000000184B840D0-0x0000000184B84250 
	public TextParamType[] paramTypes { /* [XID] */ /* 0x0000000189683CB0-0x0000000189683CD0 */ get => default; /* [XID] */ /* 0x000000018968B930-0x000000018968B950 */ protected set {} } // 0x0000000184B844F0-0x0000000184B84590 0x0000000184B84020-0x0000000184B840D0

	// Constructors
	public ManualTextMapConfig() {} // 0x0000000184B84B80-0x0000000184B84BE0

	// Methods
	// [IDTag] // 0x00000001896934C0-0x0000000189693500
	// [XID] // 0x00000001896934C0-0x0000000189693500
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184B83C20-0x0000000184B84020
	// [IDTag] // 0x000000018969DBB0-0x000000018969DBF0
	// [XID] // 0x000000018969DBB0-0x000000018969DBF0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184B83870-0x0000000184B83C20
	// [XID] // 0x00000001896A7CA0-0x00000001896A7CC0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3396 */, bool useObjectPool = false /* Metadata: 0x00AF339A */) => default; // 0x0000000184B84590-0x0000000184B849A0
	[BlackList] // 0x00000001896AF0B0-0x00000001896AF0F0
	// [XID] // 0x00000001896AF0B0-0x00000001896AF0F0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184B83720-0x0000000184B837C0
	[BlackList] // 0x00000001896B9510-0x00000001896B9550
	// [XID] // 0x00000001896B9510-0x00000001896B9550
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184B837C0-0x0000000184B83870
	[BlackList] // 0x00000001896C3900-0x00000001896C3940
	// [XID] // 0x00000001896C3900-0x00000001896C3940
	public virtual void ReturnToObjectPool() {} // 0x0000000184B84AE0-0x0000000184B84B80
	[BlackList] // 0x00000001896CE010-0x00000001896CE050
	// [XID] // 0x00000001896CE010-0x00000001896CE050
	public virtual void OnPoolAllocated() {} // 0x0000000184B84A40-0x0000000184B84AE0
	[BlackList] // 0x00000001896D8390-0x00000001896D83D0
	// [XID] // 0x00000001896D8390-0x00000001896D83D0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184B849A0-0x0000000184B84A40
}

