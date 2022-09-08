/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TakeCityReputationParentQuestReq : MessageBase, IMessage<TakeCityReputationParentQuestReq> // TypeDefIndex: 24768
{
	// Fields
	private static readonly MessageParser<TakeCityReputationParentQuestReq> _parser; // 0x00
	public const int CityIdFieldNumber = 1; // Metadata: 0x00B0730F
	private uint cityId_; // 0x18
	public const int ParentQuestListFieldNumber = 2; // Metadata: 0x00B07313
	private static readonly FieldCodec<uint> _repeated_parentQuestList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> parentQuestList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TakeCityReputationParentQuestReq> Parser { get => default; } // 0x0000000182EF60A0-0x0000000182EF6130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182EF5E30-0x0000000182EF5EC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182EF5B20-0x0000000182EF5BA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182EF5440-0x0000000182EF54A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182EF64F0-0x0000000182EF65E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182EF6300-0x0000000182EF6360 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182EF5EC0-0x0000000182EF5FB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182EF64A0-0x0000000182EF64F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182EF5C40-0x0000000182EF5D30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CityId { get => default; set {} } // 0x0000000182EF55D0-0x0000000182EF5670 0x0000000182EF61C0-0x0000000182EF6260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ParentQuestList { get => default; } // 0x0000000182EF5780-0x0000000182EF57E0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24769
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24770
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2806
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeCityReputationParentQuestReq() {} // 0x0000000182EF68A0-0x0000000182EF6930
	static TakeCityReputationParentQuestReq() {} // 0x0000000182EF67C0-0x0000000182EF68A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeCityReputationParentQuestReq Clone() => default; // 0x0000000182EF5FB0-0x0000000182EF60A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeCityReputationParentQuestReq ShallowCopy() => default; // 0x0000000182EF5BA0-0x0000000182EF5C40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182EF5670-0x0000000182EF56C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182EF6260-0x0000000182EF62B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182EF62B0-0x0000000182EF6300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182EF56C0-0x0000000182EF5780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182EF5910-0x0000000182EF59E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TakeCityReputationParentQuestReq other) => default; // 0x0000000182EF57E0-0x0000000182EF5910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182EF5D30-0x0000000182EF5E30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182EF65E0-0x0000000182EF67C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182EF6360-0x0000000182EF64A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182EF59E0-0x0000000182EF5B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TakeCityReputationParentQuestReq other) {} // 0x0000000182EF54A0-0x0000000182EF55D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182EF52D0-0x0000000182EF5440
}

