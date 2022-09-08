/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PushTipsData : MessageBase, IMessage<PushTipsData> // TypeDefIndex: 25779
{
	// Fields
	private static readonly MessageParser<PushTipsData> _parser; // 0x00
	public const int PushTipsIdFieldNumber = 1; // Metadata: 0x00B098EF
	private uint pushTipsId_; // 0x18
	public const int StateFieldNumber = 2; // Metadata: 0x00B098F3
	private uint state_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PushTipsData> Parser { get => default; } // 0x00000001825ADB60-0x00000001825ADBF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001825AD8F0-0x00000001825AD980 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001825AD5E0-0x00000001825AD660 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001825ACE90-0x00000001825ACEF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001825ADF90-0x00000001825AE080 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001825ADD20-0x00000001825ADD80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001825AD980-0x00000001825ADA70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001825ADF40-0x00000001825ADF90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001825AD700-0x00000001825AD7F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PushTipsId { get => default; set {} } // 0x00000001825ACEF0-0x00000001825ACF90 0x00000001825ADD80-0x00000001825ADE20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint State { get => default; set {} } // 0x00000001825AD4A0-0x00000001825AD540 0x00000001825AD540-0x00000001825AD5E0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PushTipsData() {} // 0x00000001825AE340-0x00000001825AE3A0
	static PushTipsData() {} // 0x00000001825AE280-0x00000001825AE340

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PushTipsData Clone() => default; // 0x00000001825ADA70-0x00000001825ADB60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PushTipsData ShallowCopy() => default; // 0x00000001825AD660-0x00000001825AD700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001825AD0C0-0x00000001825AD110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001825ADC80-0x00000001825ADCD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001825ADCD0-0x00000001825ADD20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001825AD110-0x00000001825AD180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001825AD2A0-0x00000001825AD370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PushTipsData other) => default; // 0x00000001825AD180-0x00000001825AD2A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001825AD7F0-0x00000001825AD8F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001825AE080-0x00000001825AE280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001825ADE20-0x00000001825ADF40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001825AD370-0x00000001825AD4A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PushTipsData other) {} // 0x00000001825ACF90-0x00000001825AD0C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001825ACD90-0x00000001825ACE90
}

