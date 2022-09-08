/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DoubleValue : MessageBase, IMessage<DoubleValue> // TypeDefIndex: 26467
{
	// Fields
	private static readonly MessageParser<DoubleValue> _parser; // 0x00
	public const int ValueFieldNumber = 1; // Metadata: 0x00B0C320
	private double value_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DoubleValue> Parser { /* [XID] */ /* 0x0000000189BB6540-0x0000000189BB6560 */ get => default; } // 0x0000000184FC46C0-0x0000000184FC4790 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x0000000189BBDBC0-0x0000000189BBDBE0 */ get => default; } // 0x0000000184FC4230-0x0000000184FC4320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x0000000189BC58C0-0x0000000189BC58E0 */ get => default; } // 0x0000000184FC3E50-0x0000000184FC3F20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x0000000189BCD360-0x0000000189BCD380 */ get => default; } // 0x0000000184FC36C0-0x0000000184FC3760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x0000000189BD4820-0x0000000189BD4840 */ get => default; } // 0x0000000184FC4CD0-0x0000000184FC4DD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x0000000189BDC390-0x0000000189BDC3B0 */ get => default; } // 0x0000000184FC4A60-0x0000000184FC4B00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x00000001895E8BF0-0x00000001895E8C10 */ get => default; } // 0x0000000184FC4490-0x0000000184FC4590 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x00000001895F0480-0x00000001895F04A0 */ get => default; } // 0x0000000184FC4C30-0x0000000184FC4CD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x00000001895F7ED0-0x00000001895F7EF0 */ get => default; } // 0x0000000184FC4000-0x0000000184FC4100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public double Value { /* [XID] */ /* 0x000000018963E1C0-0x000000018963E1E0 */ get => default; /* [XID] */ /* 0x0000000189645B30-0x0000000189645B50 */ set {} } // 0x0000000184FC43A0-0x0000000184FC4490 0x0000000184FC48D0-0x0000000184FC49B0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DoubleValue() {} // 0x0000000184FC5050-0x0000000184FC50B0
	static DoubleValue() {} // 0x0000000184FC4F90-0x0000000184FC5050

	// Methods
	[DebuggerNonUserCode] // 0x00000001895FF290-0x00000001895FF2D0
	// [XID] // 0x00000001895FF290-0x00000001895FF2D0
	public DoubleValue Clone() => default; // 0x0000000184FC4590-0x0000000184FC46C0
	[DebuggerNonUserCode] // 0x0000000189609CD0-0x0000000189609D10
	// [XID] // 0x0000000189609CD0-0x0000000189609D10
	public DoubleValue ShallowCopy() => default; // 0x0000000184FC3F20-0x0000000184FC4000
	[DebuggerNonUserCode] // 0x0000000189614100-0x0000000189614140
	// [XID] // 0x0000000189614100-0x0000000189614140
	protected override void InternalSetInPool(bool value) {} // 0x0000000184FC3930-0x0000000184FC39E0
	[DebuggerNonUserCode] // 0x000000018961EC80-0x000000018961ECC0
	// [XID] // 0x000000018961EC80-0x000000018961ECC0
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184FC4820-0x0000000184FC48D0
	[DebuggerNonUserCode] // 0x00000001896291E0-0x0000000189629220
	// [XID] // 0x00000001896291E0-0x0000000189629220
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184FC49B0-0x0000000184FC4A60
	[DebuggerNonUserCode] // 0x0000000189633A90-0x0000000189633AD0
	// [XID] // 0x0000000189633A90-0x0000000189633AD0
	public override void Reset() {} // 0x0000000184FC39E0-0x0000000184FC3A80
	[DebuggerNonUserCode] // 0x000000018964D380-0x000000018964D3D0
	// [IDTag] // 0x000000018964D380-0x000000018964D3D0
	// [XID] // 0x000000018964D380-0x000000018964D3D0
	public override bool Equals(object other) => default; // 0x0000000184FC3C40-0x0000000184FC3D50
	[DebuggerNonUserCode] // 0x000000018965A8E0-0x000000018965A930
	// [IDTag] // 0x000000018965A8E0-0x000000018965A930
	// [XID] // 0x000000018965A8E0-0x000000018965A930
	public bool Equals(DoubleValue other) => default; // 0x0000000184FC3AF0-0x0000000184FC3C40
	[DebuggerNonUserCode] // 0x00000001896681A0-0x00000001896681E0
	// [XID] // 0x00000001896681A0-0x00000001896681E0
	public override int GetHashCode() => default; // 0x0000000184FC4100-0x0000000184FC4230
	[DebuggerNonUserCode] // 0x0000000189672DF0-0x0000000189672E30
	// [XID] // 0x0000000189672DF0-0x0000000189672E30
	public override string ToString() => default; // 0x0000000184FC4DD0-0x0000000184FC4F90
	[DebuggerNonUserCode] // 0x000000018967D570-0x000000018967D5B0
	// [XID] // 0x000000018967D570-0x000000018967D5B0
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184FC4B00-0x0000000184FC4C30
	[DebuggerNonUserCode] // 0x00000001896880F0-0x0000000189688130
	// [XID] // 0x00000001896880F0-0x0000000189688130
	public override int CalculateSize() => default; // 0x0000000184FC3D50-0x0000000184FC3E50
	[DebuggerNonUserCode] // 0x0000000189692C50-0x0000000189692C90
	// [XID] // 0x0000000189692C50-0x0000000189692C90
	public void CopyFrom(DoubleValue other) {} // 0x0000000184FC37D0-0x0000000184FC3930
	[DebuggerNonUserCode] // 0x000000018969D150-0x000000018969D190
	// [XID] // 0x000000018969D150-0x000000018969D190
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184FC35A0-0x0000000184FC36C0
}

