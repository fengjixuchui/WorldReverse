/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ChannellerSlabTakeoffBuffReq : MessageBase, IMessage<ChannellerSlabTakeoffBuffReq> // TypeDefIndex: 22283
{
	// Fields
	private static readonly MessageParser<ChannellerSlabTakeoffBuffReq> _parser; // 0x00
	public const int BuffIdFieldNumber = 1; // Metadata: 0x00B013CF
	private uint buffId_; // 0x18
	public const int SlotIdFieldNumber = 2; // Metadata: 0x00B013D3
	private uint slotId_; // 0x1C
	public const int IsMpFieldNumber = 3; // Metadata: 0x00B013D7
	private bool isMp_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ChannellerSlabTakeoffBuffReq> Parser { get => default; } // 0x0000000183071240-0x00000001830712D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183070F30-0x0000000183070FC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183070BF0-0x0000000183070C70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183070380-0x00000001830703E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183071610-0x0000000183071700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183071400-0x0000000183071460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183070FC0-0x00000001830710B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001830715C0-0x0000000183071610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183070D10-0x0000000183070E00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BuffId { get => default; set {} } // 0x00000001830711A0-0x0000000183071240 0x00000001830703E0-0x0000000183070480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SlotId { get => default; set {} } // 0x0000000183071700-0x00000001830717A0 0x0000000183070A00-0x0000000183070AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsMp { get => default; set {} } // 0x0000000183070750-0x00000001830707F0 0x0000000183070480-0x0000000183070520

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22284
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22285
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 8005
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabTakeoffBuffReq() {} // 0x0000000183071AF0-0x0000000183071B50
	static ChannellerSlabTakeoffBuffReq() {} // 0x0000000183071A30-0x0000000183071AF0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabTakeoffBuffReq Clone() => default; // 0x00000001830710B0-0x00000001830711A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabTakeoffBuffReq ShallowCopy() => default; // 0x0000000183070C70-0x0000000183070D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183070680-0x00000001830706D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183071360-0x00000001830713B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001830713B0-0x0000000183071400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001830706D0-0x0000000183070750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001830707F0-0x00000001830708C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ChannellerSlabTakeoffBuffReq other) => default; // 0x00000001830708C0-0x0000000183070A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183070E00-0x0000000183070F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001830717A0-0x0000000183071A30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183071460-0x00000001830715C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183070AA0-0x0000000183070BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ChannellerSlabTakeoffBuffReq other) {} // 0x0000000183070520-0x0000000183070680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183070270-0x0000000183070380
}

