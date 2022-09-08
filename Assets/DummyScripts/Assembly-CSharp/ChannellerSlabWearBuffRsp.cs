/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ChannellerSlabWearBuffRsp : MessageBase, IMessage<ChannellerSlabWearBuffRsp> // TypeDefIndex: 22280
{
	// Fields
	private static readonly MessageParser<ChannellerSlabWearBuffRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B013AF
	private int retcode_; // 0x18
	public const int BuffIdFieldNumber = 2; // Metadata: 0x00B013B3
	private uint buffId_; // 0x1C
	public const int SlotIdFieldNumber = 3; // Metadata: 0x00B013B7
	private uint slotId_; // 0x20
	public const int IsMpFieldNumber = 4; // Metadata: 0x00B013BB
	private bool isMp_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ChannellerSlabWearBuffRsp> Parser { get => default; } // 0x0000000183135E40-0x0000000183135ED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183135B30-0x0000000183135BC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001831357C0-0x0000000183135840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183134D80-0x0000000183134DE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183136250-0x0000000183136340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183136000-0x0000000183136060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183135BC0-0x0000000183135CB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183136200-0x0000000183136250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001831358E0-0x00000001831359D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000183135720-0x00000001831357C0 0x0000000183135220-0x00000001831352C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BuffId { get => default; set {} } // 0x0000000183135DA0-0x0000000183135E40 0x0000000183134DE0-0x0000000183134E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SlotId { get => default; set {} } // 0x0000000183136340-0x00000001831363E0 0x00000001831354F0-0x0000000183135590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsMp { get => default; set {} } // 0x0000000183135180-0x0000000183135220 0x0000000183134E80-0x0000000183134F20

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22281
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22282
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 8004
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabWearBuffRsp() {} // 0x00000001831367C0-0x0000000183136820
	static ChannellerSlabWearBuffRsp() {} // 0x0000000183136700-0x00000001831367C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabWearBuffRsp Clone() => default; // 0x0000000183135CB0-0x0000000183135DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabWearBuffRsp ShallowCopy() => default; // 0x0000000183135840-0x00000001831358E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001831350A0-0x00000001831350F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183135F60-0x0000000183135FB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183135FB0-0x0000000183136000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001831350F0-0x0000000183135180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001831352C0-0x0000000183135390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ChannellerSlabWearBuffRsp other) => default; // 0x0000000183135390-0x00000001831354F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001831359D0-0x0000000183135B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001831363E0-0x0000000183136700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183136060-0x0000000183136200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183135590-0x0000000183135720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ChannellerSlabWearBuffRsp other) {} // 0x0000000183134F20-0x00000001831350A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183134C50-0x0000000183134D80
}

