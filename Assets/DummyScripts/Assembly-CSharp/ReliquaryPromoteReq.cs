/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ReliquaryPromoteReq : MessageBase, IMessage<ReliquaryPromoteReq> // TypeDefIndex: 23669
{
	// Fields
	private static readonly MessageParser<ReliquaryPromoteReq> _parser; // 0x00
	public const int TargetGuidFieldNumber = 1; // Metadata: 0x00B048EF
	private ulong targetGuid_; // 0x18
	public const int ItemGuidFieldNumber = 2; // Metadata: 0x00B048F3
	private ulong itemGuid_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ReliquaryPromoteReq> Parser { get => default; } // 0x0000000182C5D520-0x0000000182C5D5B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182C5D2B0-0x0000000182C5D340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182C5CF90-0x0000000182C5D010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182C5C820-0x0000000182C5C880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182C5D950-0x0000000182C5DA40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182C5D780-0x0000000182C5D7E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182C5D340-0x0000000182C5D430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182C5D900-0x0000000182C5D950 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182C5D0B0-0x0000000182C5D1A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong TargetGuid { get => default; set {} } // 0x0000000182C5D6E0-0x0000000182C5D780 0x0000000182C5CEF0-0x0000000182C5CF90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong ItemGuid { get => default; set {} } // 0x0000000182C5CA10-0x0000000182C5CAB0 0x0000000182C5CAB0-0x0000000182C5CB50

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23670
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23671
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 625
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReliquaryPromoteReq() {} // 0x0000000182C5DD00-0x0000000182C5DD60
	static ReliquaryPromoteReq() {} // 0x0000000182C5DC40-0x0000000182C5DD00

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReliquaryPromoteReq Clone() => default; // 0x0000000182C5D430-0x0000000182C5D520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReliquaryPromoteReq ShallowCopy() => default; // 0x0000000182C5D010-0x0000000182C5D0B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182C5C9C0-0x0000000182C5CA10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182C5D640-0x0000000182C5D690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182C5D690-0x0000000182C5D6E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182C5CB50-0x0000000182C5CBC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182C5CBC0-0x0000000182C5CC90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ReliquaryPromoteReq other) => default; // 0x0000000182C5CC90-0x0000000182C5CDB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182C5D1A0-0x0000000182C5D2B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182C5DA40-0x0000000182C5DC40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182C5D7E0-0x0000000182C5D900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182C5CDB0-0x0000000182C5CEF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ReliquaryPromoteReq other) {} // 0x0000000182C5C880-0x0000000182C5C9C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182C5C720-0x0000000182C5C820
}

