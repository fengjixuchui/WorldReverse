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
public class ProductMcoinDetailConfig : ProductDetailConfig, IAutoAllocRecycle // TypeDefIndex: 16138
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected uint _itemNameTextMapHash; // 0x28
	protected uint _primNameTextMapHash; // 0x2C
	protected string _icon; // 0x30
	protected SimpleSafeUInt32 mcoinNumRawNum; // 0x38
	protected SimpleSafeUInt32 mcoinNonFirstRawNum; // 0x3C
	protected SimpleSafeUInt32 mcoinFirstRawNum; // 0x40
	protected SimpleSafeUInt32 seqenceRawNum; // 0x44

	// Properties
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint itemNameTextMapHash { /* [XID] */ /* 0x0000000189BD51D0-0x0000000189BD51F0 */ get => default; /* [XID] */ /* 0x0000000189BDCD60-0x0000000189BDCD80 */ protected set {} } // 0x0000000181407DA0-0x0000000181407E40 0x0000000181406FC0-0x0000000181407070
	public string itemName { /* [XID] */ /* 0x00000001895E9490-0x00000001895E94B0 */ get => default; } // 0x0000000181407B80-0x0000000181407D00 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint primNameTextMapHash { /* [XID] */ /* 0x00000001895F0D00-0x00000001895F0D20 */ get => default; /* [XID] */ /* 0x00000001895F86B0-0x00000001895F86D0 */ protected set {} } // 0x0000000181407D00-0x0000000181407DA0 0x0000000181406E30-0x0000000181406EE0
	public string primName { /* [XID] */ /* 0x00000001895FFB50-0x00000001895FFB70 */ get => default; } // 0x0000000181407F50-0x00000001814080D0 
	public string icon { /* [XID] */ /* 0x00000001896072C0-0x00000001896072E0 */ get => default; /* [XID] */ /* 0x000000018960ED00-0x000000018960ED20 */ protected set {} } // 0x0000000181405B50-0x0000000181405BF0 0x0000000181407EA0-0x0000000181407F50
	public uint mcoinNum { /* [XID] */ /* 0x0000000189616380-0x00000001896163A0 */ get => default; /* [XID] */ /* 0x000000018961DBB0-0x000000018961DBD0 */ protected set {} } // 0x0000000181407070-0x0000000181407140 0x0000000181405E50-0x0000000181405F30
	public uint mcoinNonFirst { /* [XID] */ /* 0x0000000189624FD0-0x0000000189624FF0 */ get => default; /* [XID] */ /* 0x000000018962C850-0x000000018962C870 */ protected set {} } // 0x0000000181407AB0-0x0000000181407B80 0x0000000181406EE0-0x0000000181406FC0
	public uint mcoinFirst { /* [XID] */ /* 0x0000000189634570-0x0000000189634590 */ get => default; /* [XID] */ /* 0x000000018963BC80-0x000000018963BCA0 */ protected set {} } // 0x0000000181406010-0x00000001814060E0 0x0000000181405F30-0x0000000181406010
	public uint seqence { /* [XID] */ /* 0x0000000189643420-0x0000000189643440 */ get => default; /* [XID] */ /* 0x000000018964A9E0-0x000000018964AA00 */ protected set {} } // 0x0000000181406140-0x0000000181406210 0x00000001814080D0-0x00000001814081B0

	// Constructors
	public ProductMcoinDetailConfig() {} // 0x0000000181408250-0x00000001814082B0

	// Methods
	// [IDTag] // 0x0000000189652260-0x00000001896522A0
	// [XID] // 0x0000000189652260-0x00000001896522A0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000181406820-0x0000000181406E30
	// [IDTag] // 0x000000018965CB20-0x000000018965CB60
	// [XID] // 0x000000018965CB20-0x000000018965CB60
	public override bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181406210-0x0000000181406820
	// [XID] // 0x0000000189667290-0x00000001896672B0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3236 */, bool useObjectPool = false /* Metadata: 0x00AF323A */) => default; // 0x0000000181407230-0x0000000181407AB0
	[BlackList] // 0x000000018966EAA0-0x000000018966EAE0
	// [XID] // 0x000000018966EAA0-0x000000018966EAE0
	public override void AutoAllocTypeFields() {} // 0x0000000181405BF0-0x0000000181405C90
	[BlackList] // 0x0000000189679830-0x0000000189679870
	// [XID] // 0x0000000189679830-0x0000000189679870
	public override void AutoRecycleTypeFields() {} // 0x0000000181405C90-0x0000000181405DB0
	[BlackList] // 0x0000000189683CD0-0x0000000189683D10
	// [XID] // 0x0000000189683CD0-0x0000000189683D10
	public override void ReturnToObjectPool() {} // 0x00000001814081B0-0x0000000181408250
}

