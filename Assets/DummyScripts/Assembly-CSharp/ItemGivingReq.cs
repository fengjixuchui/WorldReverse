/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ItemGivingReq : MessageBase, IMessage<ItemGivingReq> // TypeDefIndex: 24474
{
	// Fields
	private static readonly MessageParser<ItemGivingReq> _parser; // 0x00
	public const int GivingIdFieldNumber = 1; // Metadata: 0x00B0682B
	private uint givingId_; // 0x18
	public const int ItemParamListFieldNumber = 2; // Metadata: 0x00B0682F
	private static readonly FieldCodec<ItemParam> _repeated_itemParamList_codec; // 0x08
	private readonly RepeatedMessageField<ItemParam> itemParamList_; // 0x20
	public const int ItemGuidCountMapFieldNumber = 3; // Metadata: 0x00B06833
	private static readonly MapField<ulong, uint> _map_itemGuidCountMap_codec; // 0x10
	private readonly MapField<ulong, uint> itemGuidCountMap_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ItemGivingReq> Parser { get => default; } // 0x00000001842FC8B0-0x00000001842FC940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001842FC5A0-0x00000001842FC630 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001842FC230-0x00000001842FC2B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001842FB9F0-0x00000001842FBA50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001842FCD70-0x00000001842FCE60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001842FCAF0-0x00000001842FCB50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001842FC6D0-0x00000001842FC7C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001842FCCC0-0x00000001842FCD10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001842FC350-0x00000001842FC440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GivingId { get => default; set {} } // 0x00000001842FC630-0x00000001842FC6D0 0x00000001842FBD70-0x00000001842FBE10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ItemParam> ItemParamList { get => default; } // 0x00000001842FCD10-0x00000001842FCD70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<ulong, uint> ItemGuidCountMap { get => default; } // 0x00000001842FC1D0-0x00000001842FC230 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24475
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24476
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 157
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ItemGivingReq() {} // 0x00000001842FD240-0x00000001842FD2F0
	static ItemGivingReq() {} // 0x00000001842FD0C0-0x00000001842FD240

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ItemGivingReq Clone() => default; // 0x00000001842FC7C0-0x00000001842FC8B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ItemGivingReq ShallowCopy() => default; // 0x00000001842FC2B0-0x00000001842FC350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001842FBBE0-0x00000001842FBC30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001842FC9D0-0x00000001842FCA60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001842FCA60-0x00000001842FCAF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001842FBC30-0x00000001842FBD70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001842FBF80-0x00000001842FC050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ItemGivingReq other) => default; // 0x00000001842FBE10-0x00000001842FBF80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001842FC440-0x00000001842FC5A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001842FCE60-0x00000001842FD0C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001842FCB50-0x00000001842FCCC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001842FC050-0x00000001842FC1D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ItemGivingReq other) {} // 0x00000001842FBA50-0x00000001842FBBE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001842FB820-0x00000001842FB9F0
}

