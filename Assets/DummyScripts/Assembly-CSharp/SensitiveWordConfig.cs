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
public class SensitiveWordConfig : IAutoAllocRecycle // TypeDefIndex: 16101
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected string _word; // 0x18

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189BC6140-0x0000000189BC6160 */ get => default; /* [XID] */ /* 0x0000000189BCDD00-0x0000000189BCDD20 */ protected set {} } // 0x0000000182D3C870-0x0000000182D3C940 0x0000000182D3C230-0x0000000182D3C310
	public string word { /* [XID] */ /* 0x0000000189BD51F0-0x0000000189BD5210 */ get => default; /* [XID] */ /* 0x0000000189BDCD80-0x0000000189BDCDA0 */ protected set {} } // 0x0000000182D3C190-0x0000000182D3C230 0x0000000182D3C680-0x0000000182D3C730

	// Constructors
	public SensitiveWordConfig() {} // 0x0000000182D3C9E0-0x0000000182D3CA40

	// Methods
	// [IDTag] // 0x00000001895E94F0-0x00000001895E9530
	// [XID] // 0x00000001895E94F0-0x00000001895E9530
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182D3BD00-0x0000000182D3BF70
	// [IDTag] // 0x00000001895F3C70-0x00000001895F3CB0
	// [XID] // 0x00000001895F3C70-0x00000001895F3CB0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182D3BF70-0x0000000182D3C190
	// [XID] // 0x00000001895FE3A0-0x00000001895FE3C0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF304A */, bool useObjectPool = false /* Metadata: 0x00AF304E */) => default; // 0x0000000182D3C310-0x0000000182D3C680
	[BlackList] // 0x0000000189605D10-0x0000000189605D50
	// [XID] // 0x0000000189605D10-0x0000000189605D50
	public virtual void AutoAllocTypeFields() {} // 0x0000000182D3BB80-0x0000000182D3BC20
	[BlackList] // 0x0000000189610630-0x0000000189610670
	// [XID] // 0x0000000189610630-0x0000000189610670
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182D3BC20-0x0000000182D3BD00
	[BlackList] // 0x000000018961ABE0-0x000000018961AC20
	// [XID] // 0x000000018961ABE0-0x000000018961AC20
	public virtual void ReturnToObjectPool() {} // 0x0000000182D3C940-0x0000000182D3C9E0
	[BlackList] // 0x0000000189624FF0-0x0000000189625030
	// [XID] // 0x0000000189624FF0-0x0000000189625030
	public virtual void OnPoolAllocated() {} // 0x0000000182D3C7D0-0x0000000182D3C870
	[BlackList] // 0x000000018962FA20-0x000000018962FA60
	// [XID] // 0x000000018962FA20-0x000000018962FA60
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182D3C730-0x0000000182D3C7D0
}

