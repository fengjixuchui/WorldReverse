/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ChannellerSlabWearBuffReq : MessageBase, IMessage<ChannellerSlabWearBuffReq> // TypeDefIndex: 22277
{
	// Fields
	private static readonly MessageParser<ChannellerSlabWearBuffReq> _parser; // 0x00
	public const int BuffIdFieldNumber = 1; // Metadata: 0x00B0138F
	private uint buffId_; // 0x18
	public const int SlotIdFieldNumber = 2; // Metadata: 0x00B01393
	private uint slotId_; // 0x1C
	public const int IsMpFieldNumber = 3; // Metadata: 0x00B01397
	private bool isMp_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ChannellerSlabWearBuffReq> Parser { get => default; } // 0x00000001838E4910-0x00000001838E49A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001838E4600-0x00000001838E4690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001838E42C0-0x00000001838E4340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001838E3A50-0x00000001838E3AB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001838E4CE0-0x00000001838E4DD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001838E4AD0-0x00000001838E4B30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001838E4690-0x00000001838E4780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001838E4C90-0x00000001838E4CE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001838E43E0-0x00000001838E44D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BuffId { get => default; set {} } // 0x00000001838E4870-0x00000001838E4910 0x00000001838E3AB0-0x00000001838E3B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SlotId { get => default; set {} } // 0x00000001838E4DD0-0x00000001838E4E70 0x00000001838E40D0-0x00000001838E4170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsMp { get => default; set {} } // 0x00000001838E3E20-0x00000001838E3EC0 0x00000001838E3B50-0x00000001838E3BF0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22278
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22279
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 8003
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabWearBuffReq() {} // 0x00000001838E51C0-0x00000001838E5220
	static ChannellerSlabWearBuffReq() {} // 0x00000001838E5100-0x00000001838E51C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabWearBuffReq Clone() => default; // 0x00000001838E4780-0x00000001838E4870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabWearBuffReq ShallowCopy() => default; // 0x00000001838E4340-0x00000001838E43E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001838E3D50-0x00000001838E3DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001838E4A30-0x00000001838E4A80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001838E4A80-0x00000001838E4AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001838E3DA0-0x00000001838E3E20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001838E3EC0-0x00000001838E3F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ChannellerSlabWearBuffReq other) => default; // 0x00000001838E3F90-0x00000001838E40D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001838E44D0-0x00000001838E4600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001838E4E70-0x00000001838E5100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001838E4B30-0x00000001838E4C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001838E4170-0x00000001838E42C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ChannellerSlabWearBuffReq other) {} // 0x00000001838E3BF0-0x00000001838E3D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001838E3940-0x00000001838E3A50
}

