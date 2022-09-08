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
public class WidgetExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16282
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 materialIDRawNum; // 0x10
	protected string _jsonAddr; // 0x18
	protected uint[] _customizeDesc; // 0x20

	// Properties
	public uint materialID { /* [XID] */ /* 0x000000018982AEF0-0x000000018982AF10 */ get => default; /* [XID] */ /* 0x0000000189832390-0x00000001898323B0 */ protected set {} } // 0x0000000181955AD0-0x0000000181955BA0 0x00000001819551B0-0x0000000181955290
	public string jsonAddr { /* [XID] */ /* 0x00000001898399C0-0x00000001898399E0 */ get => default; /* [XID] */ /* 0x0000000189840EA0-0x0000000189840EC0 */ protected set {} } // 0x0000000181954D00-0x0000000181954DA0 0x0000000181955100-0x00000001819551B0
	public uint[] customizeDesc { /* [XID] */ /* 0x0000000189848340-0x0000000189848360 */ get => default; /* [XID] */ /* 0x000000018984FAE0-0x000000018984FB00 */ protected set {} } // 0x0000000181955A30-0x0000000181955AD0 0x0000000181954AD0-0x0000000181954B80
	public string[] customizeDescLocalized { /* [XID] */ /* 0x0000000189856E80-0x0000000189856EA0 */ get => default; } // 0x0000000181954DA0-0x0000000181955100 

	// Constructors
	public WidgetExcelConfig() {} // 0x0000000181956190-0x00000001819561F0

	// Methods
	// [IDTag] // 0x000000018985E030-0x000000018985E070
	// [XID] // 0x000000018985E030-0x000000018985E070
	public virtual bool ParseFromLine(string line) => default; // 0x0000000181955630-0x0000000181955A30
	// [IDTag] // 0x0000000189868A70-0x0000000189868AB0
	// [XID] // 0x0000000189868A70-0x0000000189868AB0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181955290-0x0000000181955630
	// [XID] // 0x0000000189872D90-0x0000000189872DB0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF365D */, bool useObjectPool = false /* Metadata: 0x00AF3661 */) => default; // 0x0000000181955BA0-0x0000000181955FB0
	[BlackList] // 0x000000018987AA50-0x000000018987AA90
	// [XID] // 0x000000018987AA50-0x000000018987AA90
	public virtual void AutoAllocTypeFields() {} // 0x0000000181954B80-0x0000000181954C20
	[BlackList] // 0x0000000189884970-0x00000001898849B0
	// [XID] // 0x0000000189884970-0x00000001898849B0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181954C20-0x0000000181954D00
	[BlackList] // 0x000000018988EE00-0x000000018988EE40
	// [XID] // 0x000000018988EE00-0x000000018988EE40
	public virtual void ReturnToObjectPool() {} // 0x00000001819560F0-0x0000000181956190
	[BlackList] // 0x00000001898995D0-0x0000000189899610
	// [XID] // 0x00000001898995D0-0x0000000189899610
	public virtual void OnPoolAllocated() {} // 0x0000000181956050-0x00000001819560F0
	[BlackList] // 0x00000001898A3A40-0x00000001898A3A80
	// [XID] // 0x00000001898A3A40-0x00000001898A3A80
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181955FB0-0x0000000181956050
}

