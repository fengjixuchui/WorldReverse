/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CityReputationRequestInfo : MessageBase, IMessage<CityReputationRequestInfo> // TypeDefIndex: 24747
{
	// Fields
	private static readonly MessageParser<CityReputationRequestInfo> _parser; // 0x00
	public const int IsOpenFieldNumber = 1; // Metadata: 0x00B07237
	private bool isOpen_; // 0x18
	public const int RequestInfoListFieldNumber = 2; // Metadata: 0x00B0723B
	private static readonly FieldCodec<Types.RequestInfo> _repeated_requestInfoList_codec; // 0x08
	private readonly RepeatedMessageField<Types.RequestInfo> requestInfoList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CityReputationRequestInfo> Parser { get => default; } // 0x0000000184C4F7D0-0x0000000184C4F860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184C4F560-0x0000000184C4F5F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184C4F250-0x0000000184C4F2D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184C4EBB0-0x0000000184C4EC10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184C4FCA0-0x0000000184C4FD90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184C4FA10-0x0000000184C4FA70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184C4F5F0-0x0000000184C4F6E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184C4FC50-0x0000000184C4FCA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184C4F370-0x0000000184C4F460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsOpen { get => default; set {} } // 0x0000000184C4FA70-0x0000000184C4FB10 0x0000000184C4EC10-0x0000000184C4ECB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<Types.RequestInfo> RequestInfoList { get => default; } // 0x0000000184C4FD90-0x0000000184C4FDF0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24748
	{
		// Nested types
		public sealed class RequestInfo : MessageBase, IMessage<RequestInfo> // TypeDefIndex: 24749
		{
			// Fields
			private static readonly MessageParser<RequestInfo> _parser; // 0x00
			public const int RequestIdFieldNumber = 1; // Metadata: 0x00B0723F
			private uint requestId_; // 0x18
			public const int QuestIdFieldNumber = 2; // Metadata: 0x00B07243
			private uint questId_; // 0x1C
			public const int IsTakenRewardFieldNumber = 3; // Metadata: 0x00B07247
			private bool isTakenReward_; // 0x20

			// Properties
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static MessageParser<RequestInfo> Parser { get => default; } // 0x0000000184C418F0-0x0000000184C41980 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184C41680-0x0000000184C41710 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override MessageDescriptor Descriptor { get => default; } // 0x0000000184C41340-0x0000000184C413C0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static string StaticClassName { get => default; } // 0x0000000184C40A30-0x0000000184C40A90 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string ClassName { get => default; } // 0x0000000184C41CC0-0x0000000184C41DB0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static string StaticFullClassName { get => default; } // 0x0000000184C41AB0-0x0000000184C41B10 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string FullClassName { get => default; } // 0x0000000184C41710-0x0000000184C41800 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static ushort StaticCmdId { get => default; } // 0x0000000184C41C70-0x0000000184C41CC0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override ushort CmdId { get => default; } // 0x0000000184C41460-0x0000000184C41550 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public uint RequestId { get => default; set {} } // 0x0000000184C40A90-0x0000000184C40B30 0x0000000184C40B30-0x0000000184C40BD0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public uint QuestId { get => default; set {} } // 0x0000000184C40990-0x0000000184C40A30 0x0000000184C412A0-0x0000000184C41340
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public bool IsTakenReward { get => default; set {} } // 0x0000000184C41200-0x0000000184C412A0 0x0000000184C40BD0-0x0000000184C40C70

			// Constructors
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public RequestInfo() {} // 0x0000000184C42100-0x0000000184C42160
			static RequestInfo() {} // 0x0000000184C42040-0x0000000184C42100

			// Methods
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public RequestInfo Clone() => default; // 0x0000000184C41800-0x0000000184C418F0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public RequestInfo ShallowCopy() => default; // 0x0000000184C413C0-0x0000000184C41460
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalSetInPool(bool value) {} // 0x0000000184C40DD0-0x0000000184C40E20
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184C41A10-0x0000000184C41A60
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184C41A60-0x0000000184C41AB0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void Reset() {} // 0x0000000184C40E20-0x0000000184C40EA0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override bool Equals(object other) => default; // 0x0000000184C40FE0-0x0000000184C410B0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public bool Equals(RequestInfo other) => default; // 0x0000000184C40EA0-0x0000000184C40FE0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override int GetHashCode() => default; // 0x0000000184C41550-0x0000000184C41680
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string ToString() => default; // 0x0000000184C41DB0-0x0000000184C42040
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void WriteTo(CodedOutputStream output) {} // 0x0000000184C41B10-0x0000000184C41C70
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override int CalculateSize() => default; // 0x0000000184C410B0-0x0000000184C41200
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public void CopyFrom(RequestInfo other) {} // 0x0000000184C40C70-0x0000000184C40DD0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void MergeFrom(CodedInputStream input) {} // 0x0000000184C40880-0x0000000184C40990
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CityReputationRequestInfo() {} // 0x0000000184C500E0-0x0000000184C50170
	static CityReputationRequestInfo() {} // 0x0000000184C4FFD0-0x0000000184C500E0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CityReputationRequestInfo Clone() => default; // 0x0000000184C4F6E0-0x0000000184C4F7D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CityReputationRequestInfo ShallowCopy() => default; // 0x0000000184C4F2D0-0x0000000184C4F370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184C4EE10-0x0000000184C4EE60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184C4F8F0-0x0000000184C4F980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184C4F980-0x0000000184C4FA10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184C4EE60-0x0000000184C4EF40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184C4EF40-0x0000000184C4F010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CityReputationRequestInfo other) => default; // 0x0000000184C4F010-0x0000000184C4F140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184C4F460-0x0000000184C4F560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184C4FDF0-0x0000000184C4FFD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184C4FB10-0x0000000184C4FC50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184C4F140-0x0000000184C4F250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CityReputationRequestInfo other) {} // 0x0000000184C4ECB0-0x0000000184C4EE10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184C4EA50-0x0000000184C4EBB0
}

