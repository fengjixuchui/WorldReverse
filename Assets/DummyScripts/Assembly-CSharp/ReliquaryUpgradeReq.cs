/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ReliquaryUpgradeReq : MessageBase, IMessage<ReliquaryUpgradeReq> // TypeDefIndex: 23663
{
	// Fields
	private static readonly MessageParser<ReliquaryUpgradeReq> _parser; // 0x00
	public const int TargetReliquaryGuidFieldNumber = 1; // Metadata: 0x00B048A3
	private ulong targetReliquaryGuid_; // 0x18
	public const int FoodReliquaryGuidListFieldNumber = 2; // Metadata: 0x00B048A7
	private static readonly FieldCodec<ulong> _repeated_foodReliquaryGuidList_codec; // 0x08
	private readonly RepeatedPrimitiveField<ulong> foodReliquaryGuidList_; // 0x20
	public const int ItemParamListFieldNumber = 3; // Metadata: 0x00B048AB
	private static readonly FieldCodec<ItemParam> _repeated_itemParamList_codec; // 0x10
	private readonly RepeatedMessageField<ItemParam> itemParamList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ReliquaryUpgradeReq> Parser { get => default; } // 0x000000018189FE80-0x000000018189FF10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018189FC10-0x000000018189FCA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018189F8E0-0x000000018189F960 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018189F170-0x000000018189F1D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001818A03E0-0x00000001818A04D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001818A00C0-0x00000001818A0120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018189FCA0-0x000000018189FD90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001818A0330-0x00000001818A0380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018189FA00-0x000000018189FAF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong TargetReliquaryGuid { get => default; set {} } // 0x00000001818A04D0-0x00000001818A0570 0x00000001818A0120-0x00000001818A01C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<ulong> FoodReliquaryGuidList { get => default; } // 0x000000018189F4E0-0x000000018189F540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ItemParam> ItemParamList { get => default; } // 0x00000001818A0380-0x00000001818A03E0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23664
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23665
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 623
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReliquaryUpgradeReq() {} // 0x00000001818A0900-0x00000001818A09B0
	static ReliquaryUpgradeReq() {} // 0x00000001818A07D0-0x00000001818A0900

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReliquaryUpgradeReq Clone() => default; // 0x000000018189FD90-0x000000018189FE80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReliquaryUpgradeReq ShallowCopy() => default; // 0x000000018189F960-0x000000018189FA00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018189F350-0x000000018189F3A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018189FFA0-0x00000001818A0030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001818A0030-0x00000001818A00C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018189F3A0-0x000000018189F4E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018189F690-0x000000018189F760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ReliquaryUpgradeReq other) => default; // 0x000000018189F540-0x000000018189F690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018189FAF0-0x000000018189FC10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001818A0570-0x00000001818A07D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001818A01C0-0x00000001818A0330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018189F760-0x000000018189F8E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ReliquaryUpgradeReq other) {} // 0x000000018189F1D0-0x000000018189F350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018189EF90-0x000000018189F170
}

