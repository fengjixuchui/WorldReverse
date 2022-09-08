/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AsterMidDetailInfo : MessageBase, IMessage<AsterMidDetailInfo> // TypeDefIndex: 22000
{
	// Fields
	private static readonly MessageParser<AsterMidDetailInfo> _parser; // 0x00
	public const int IsOpenFieldNumber = 1; // Metadata: 0x00B008A7
	private bool isOpen_; // 0x18
	public const int CampListFieldNumber = 2; // Metadata: 0x00B008AB
	private static readonly FieldCodec<AsterMidCampInfo> _repeated_campList_codec; // 0x08
	private readonly RepeatedMessageField<AsterMidCampInfo> campList_; // 0x20
	public const int CollectCountFieldNumber = 3; // Metadata: 0x00B008AF
	private uint collectCount_; // 0x28
	public const int BeginTimeFieldNumber = 4; // Metadata: 0x00B008B3
	private uint beginTime_; // 0x2C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AsterMidDetailInfo> Parser { get => default; } // 0x0000000184D16EF0-0x0000000184D16F80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184D16C80-0x0000000184D16D10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184D16870-0x0000000184D168F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184D16070-0x0000000184D160D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184D17680-0x0000000184D17770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184D172D0-0x0000000184D17330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184D16D10-0x0000000184D16E00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184D17630-0x0000000184D17680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184D16A30-0x0000000184D16B20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsOpen { get => default; set {} } // 0x0000000184D17330-0x0000000184D173D0 0x0000000184D160D0-0x0000000184D16170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<AsterMidCampInfo> CampList { get => default; } // 0x0000000184D171D0-0x0000000184D17230 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CollectCount { get => default; set {} } // 0x0000000184D16990-0x0000000184D16A30 0x0000000184D17230-0x0000000184D172D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BeginTime { get => default; set {} } // 0x0000000184D17590-0x0000000184D17630 0x0000000184D17130-0x0000000184D171D0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AsterMidDetailInfo() {} // 0x0000000184D17B80-0x0000000184D17C10
	static AsterMidDetailInfo() {} // 0x0000000184D17A70-0x0000000184D17B80

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AsterMidDetailInfo Clone() => default; // 0x0000000184D16E00-0x0000000184D16EF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AsterMidDetailInfo ShallowCopy() => default; // 0x0000000184D168F0-0x0000000184D16990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184D16330-0x0000000184D16380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184D17010-0x0000000184D170A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184D170A0-0x0000000184D17130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184D16380-0x0000000184D16480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184D165F0-0x0000000184D166C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AsterMidDetailInfo other) => default; // 0x0000000184D16480-0x0000000184D165F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184D16B20-0x0000000184D16C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184D17770-0x0000000184D17A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184D173D0-0x0000000184D17590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184D166C0-0x0000000184D16870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AsterMidDetailInfo other) {} // 0x0000000184D16170-0x0000000184D16330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184D15ED0-0x0000000184D16070
}

