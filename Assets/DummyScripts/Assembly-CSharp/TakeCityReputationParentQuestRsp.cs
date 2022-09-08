/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TakeCityReputationParentQuestRsp : MessageBase, IMessage<TakeCityReputationParentQuestRsp> // TypeDefIndex: 24771
{
	// Fields
	private static readonly MessageParser<TakeCityReputationParentQuestRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0732B
	private int retcode_; // 0x18
	public const int CityIdFieldNumber = 2; // Metadata: 0x00B0732F
	private uint cityId_; // 0x1C
	public const int ParentQuestListFieldNumber = 3; // Metadata: 0x00B07333
	private static readonly FieldCodec<uint> _repeated_parentQuestList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> parentQuestList_; // 0x20
	public const int ItemListFieldNumber = 4; // Metadata: 0x00B07337
	private static readonly FieldCodec<ItemParam> _repeated_itemList_codec; // 0x10
	private readonly RepeatedMessageField<ItemParam> itemList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TakeCityReputationParentQuestRsp> Parser { get => default; } // 0x0000000184CA7E20-0x0000000184CA7EB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184CA7B50-0x0000000184CA7BE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184CA77F0-0x0000000184CA7870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184CA6E00-0x0000000184CA6E60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184CA8360-0x0000000184CA8450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184CA8100-0x0000000184CA8160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184CA7C40-0x0000000184CA7D30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184CA8310-0x0000000184CA8360 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184CA7910-0x0000000184CA7A00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000184CA7750-0x0000000184CA77F0 0x0000000184CA7250-0x0000000184CA72F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CityId { get => default; set {} } // 0x0000000184CA7010-0x0000000184CA70B0 0x0000000184CA7F40-0x0000000184CA7FE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ParentQuestList { get => default; } // 0x0000000184CA72F0-0x0000000184CA7350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ItemParam> ItemList { get => default; } // 0x0000000184CA7BE0-0x0000000184CA7C40 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24772
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24773
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2807
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeCityReputationParentQuestRsp() {} // 0x0000000184CA8860-0x0000000184CA8910
	static TakeCityReputationParentQuestRsp() {} // 0x0000000184CA8730-0x0000000184CA8860

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeCityReputationParentQuestRsp Clone() => default; // 0x0000000184CA7D30-0x0000000184CA7E20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeCityReputationParentQuestRsp ShallowCopy() => default; // 0x0000000184CA7870-0x0000000184CA7910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184CA70B0-0x0000000184CA7100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184CA7FE0-0x0000000184CA8070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184CA8070-0x0000000184CA8100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184CA7100-0x0000000184CA7250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184CA74C0-0x0000000184CA7590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TakeCityReputationParentQuestRsp other) => default; // 0x0000000184CA7350-0x0000000184CA74C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184CA7A00-0x0000000184CA7B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184CA8450-0x0000000184CA8730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184CA8160-0x0000000184CA8310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184CA7590-0x0000000184CA7750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TakeCityReputationParentQuestRsp other) {} // 0x0000000184CA6E60-0x0000000184CA7010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184CA6C00-0x0000000184CA6E00
}

