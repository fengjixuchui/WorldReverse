/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DropItemRsp : MessageBase, IMessage<DropItemRsp> // TypeDefIndex: 23633
{
	// Fields
	private static readonly MessageParser<DropItemRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0476F
	private int retcode_; // 0x18
	public const int StoreTypeFieldNumber = 2; // Metadata: 0x00B04773
	private StoreType storeType_; // 0x1C
	public const int GuidFieldNumber = 3; // Metadata: 0x00B04777
	private ulong guid_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DropItemRsp> Parser { get => default; } // 0x00000001821F3790-0x00000001821F3820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001821F3520-0x00000001821F35B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001821F31A0-0x00000001821F3220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001821F27C0-0x00000001821F2820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001821F3B60-0x00000001821F3C50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001821F3950-0x00000001821F39B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001821F35B0-0x00000001821F36A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001821F3B10-0x00000001821F3B60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001821F32C0-0x00000001821F33B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001821F3100-0x00000001821F31A0 0x00000001821F2C30-0x00000001821F2CD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public StoreType StoreType { get => default; set {} } // 0x00000001821F2A20-0x00000001821F2AC0 0x00000001821F2CD0-0x00000001821F2D70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong Guid { get => default; set {} } // 0x00000001821F2980-0x00000001821F2A20 0x00000001821F2B90-0x00000001821F2C30

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23634
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23635
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 611
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DropItemRsp() {} // 0x00000001821F3FA0-0x00000001821F4010
	static DropItemRsp() {} // 0x00000001821F3EE0-0x00000001821F3FA0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DropItemRsp Clone() => default; // 0x00000001821F36A0-0x00000001821F3790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DropItemRsp ShallowCopy() => default; // 0x00000001821F3220-0x00000001821F32C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001821F2AC0-0x00000001821F2B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001821F38B0-0x00000001821F3900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001821F3900-0x00000001821F3950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001821F2B10-0x00000001821F2B90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001821F2D70-0x00000001821F2E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DropItemRsp other) => default; // 0x00000001821F2E40-0x00000001821F2F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001821F33B0-0x00000001821F3520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001821F3C50-0x00000001821F3EE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001821F39B0-0x00000001821F3B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001821F2F80-0x00000001821F3100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DropItemRsp other) {} // 0x00000001821F2820-0x00000001821F2980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001821F26B0-0x00000001821F27C0
}

