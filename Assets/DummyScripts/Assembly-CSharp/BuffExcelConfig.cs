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
public class BuffExcelConfig : BaseServerBuffConfig, IAutoAllocRecycle // TypeDefIndex: 15296
{
	// Fields
	protected SimpleSafeUInt32 groupIdRawNum; // 0x28
	protected string _name; // 0x30
	protected string _desc; // 0x38
	protected SimpleSafeFloat timeRawNum; // 0x40
	protected BuffStackType _stackType; // 0x44
	protected bool _isPersistent; // 0x48

	// Properties
	public uint groupId { /* [XID] */ /* 0x000000018966B800-0x000000018966B820 */ get => default; /* [XID] */ /* 0x0000000189673580-0x00000001896735A0 */ protected set {} } // 0x0000000184728400-0x00000001847284D0 0x00000001847284D0-0x00000001847285B0
	public string name { /* [XID] */ /* 0x000000018967ADC0-0x000000018967ADE0 */ get => default; /* [XID] */ /* 0x0000000189682650-0x0000000189682670 */ protected set {} } // 0x0000000184728820-0x00000001847288C0 0x00000001847278B0-0x0000000184727960
	public string desc { /* [XID] */ /* 0x000000018968A110-0x000000018968A130 */ get => default; /* [XID] */ /* 0x0000000189691F10-0x0000000189691F30 */ protected set {} } // 0x0000000184727780-0x0000000184727820 0x0000000184728690-0x0000000184728740
	public float time { /* [XID] */ /* 0x0000000189699400-0x0000000189699420 */ get => default; /* [XID] */ /* 0x00000001896A0890-0x00000001896A08B0 */ protected set {} } // 0x0000000184728740-0x0000000184728820 0x00000001847285B0-0x0000000184728690
	public BuffStackType stackType { /* [XID] */ /* 0x00000001896A7E40-0x00000001896A7E60 */ get => default; /* [XID] */ /* 0x00000001896AF2B0-0x00000001896AF2D0 */ protected set {} } // 0x0000000184728300-0x00000001847283A0 0x0000000184726A90-0x0000000184726B40
	public bool isPersistent { /* [XID] */ /* 0x00000001896B6820-0x00000001896B6840 */ get => default; /* [XID] */ /* 0x00000001896BDA80-0x00000001896BDAA0 */ protected set {} } // 0x00000001847276E0-0x0000000184727780 0x0000000184727960-0x0000000184727A10

	// Constructors
	public BuffExcelConfig() {} // 0x0000000184728960-0x00000001847289C0

	// Methods
	// [IDTag] // 0x00000001896C5290-0x00000001896C52D0
	// [XID] // 0x00000001896C5290-0x00000001896C52D0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184726B40-0x0000000184727110
	// [IDTag] // 0x00000001896CFAB0-0x00000001896CFAF0
	// [XID] // 0x00000001896CFAB0-0x00000001896CFAF0
	public override bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184727110-0x00000001847276E0
	// [XID] // 0x00000001896D9FF0-0x00000001896DA010
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF06A8 */, bool useObjectPool = false /* Metadata: 0x00AF06AC */) => default; // 0x0000000184727A70-0x0000000184728300
	[BlackList] // 0x00000001896E15D0-0x00000001896E1610
	// [XID] // 0x00000001896E15D0-0x00000001896E1610
	public override void AutoAllocTypeFields() {} // 0x00000001847267D0-0x0000000184726870
	[BlackList] // 0x00000001896EB980-0x00000001896EB9C0
	// [XID] // 0x00000001896EB980-0x00000001896EB9C0
	public override void AutoRecycleTypeFields() {} // 0x0000000184726870-0x0000000184726990
	[BlackList] // 0x00000001896F6020-0x00000001896F6060
	// [XID] // 0x00000001896F6020-0x00000001896F6060
	public override void ReturnToObjectPool() {} // 0x00000001847288C0-0x0000000184728960
}

