/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct Point2D : IEmptyInitable, IHashable // TypeDefIndex: 17792
{
	// Fields
	private SimpleSafeFloat xRawNum; // 0x00
	private SimpleSafeFloat yRawNum; // 0x04

	// Properties
	public float x { /* [XID] */ /* 0x0000000189709CB0-0x0000000189709CD0 */ get => default; /* [XID] */ /* 0x00000001896B4C50-0x00000001896B4C70 */ set {} } // 0x0000000182404840-0x0000000182404920 0x0000000182404EC0-0x0000000182404FB0
	public float y { /* [XID] */ /* 0x00000001896BC020-0x00000001896BC040 */ get => default; /* [XID] */ /* 0x00000001896C3500-0x00000001896C3520 */ set {} } // 0x00000001824042C0-0x00000001824043D0 0x0000000182404FB0-0x00000001824050C0

	// Methods
	// [IDTag] // 0x00000001896CAA70-0x00000001896CAAB0
	// [XID] // 0x00000001896CAA70-0x00000001896CAAB0
	public bool Equals(Point2D otherVal) => default; // 0x00000001824050C0-0x0000000182405330
	// [IDTag] // 0x00000001896D5200-0x00000001896D5240
	// [XID] // 0x00000001896D5200-0x00000001896D5240
	public override bool Equals(object other) => default; // 0x00000001824043D0-0x0000000182404760
	// [XID] // 0x00000001896DF9E0-0x00000001896DFA00
	public override int GetHashCode() => default; // 0x0000000182404920-0x00000001824049D0
	// [XID] // 0x00000001896E6D80-0x00000001896E6DA0
	public void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001824053F0-0x0000000182405400
	// [XID] // 0x00000001896EE290-0x00000001896EE2B0
	public void InitEmpty() {} // 0x0000000182404AC0-0x0000000182404DD0
	[BlackList] // 0x00000001896F5BA0-0x00000001896F5BE0
	// [XID] // 0x00000001896F5BA0-0x00000001896F5BE0
	public bool FromJson(JSONNode node) => default; // 0x0000000182404760-0x0000000182404840
	// [XID] // 0x00000001898B02C0-0x00000001898B02E0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182403B80-0x0000000182403E60
	// [XID] // 0x0000000189982740-0x0000000189982760
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7C49 */, bool useObjectPool = false /* Metadata: 0x00AF7C4D */) => default; // 0x0000000182404DD0-0x0000000182404EC0
	// [XID] // 0x00000001896333E0-0x0000000189633400
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7C4E */, bool useObjectPool = false /* Metadata: 0x00AF7C52 */) => default; // 0x00000001824041D0-0x00000001824042C0
	[BlackList] // 0x00000001897165C0-0x0000000189716600
	// [XID] // 0x00000001897165C0-0x0000000189716600
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182403E60-0x0000000182403F00
	// [XID] // 0x0000000189720EB0-0x0000000189720ED0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182405330-0x00000001824053F0
}

