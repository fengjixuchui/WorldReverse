/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetExpeditionAssistInfoListRsp : MessageBase, IMessage<GetExpeditionAssistInfoListRsp> // TypeDefIndex: 22189
{
	// Fields
	private static readonly MessageParser<GetExpeditionAssistInfoListRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B01013
	private int retcode_; // 0x18
	public const int AssistInfoListFieldNumber = 2; // Metadata: 0x00B01017
	private static readonly FieldCodec<ExpeditionAssistInfo> _repeated_assistInfoList_codec; // 0x08
	private readonly RepeatedMessageField<ExpeditionAssistInfo> assistInfoList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetExpeditionAssistInfoListRsp> Parser { get => default; } // 0x0000000180DD17C0-0x0000000180DD1850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000180DD14F0-0x0000000180DD1580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000180DD11E0-0x0000000180DD1260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000180DD0A70-0x0000000180DD0AD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000180DD1BF0-0x0000000180DD1CE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000180DD1A00-0x0000000180DD1A60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000180DD1580-0x0000000180DD1670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000180DD1BA0-0x0000000180DD1BF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000180DD1300-0x0000000180DD13F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000180DD1140-0x0000000180DD11E0 0x0000000180DD0D60-0x0000000180DD0E00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ExpeditionAssistInfo> AssistInfoList { get => default; } // 0x0000000180DD1760-0x0000000180DD17C0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22190
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22191
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2168
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetExpeditionAssistInfoListRsp() {} // 0x0000000180DD1FD0-0x0000000180DD2060
	static GetExpeditionAssistInfoListRsp() {} // 0x0000000180DD1EC0-0x0000000180DD1FD0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetExpeditionAssistInfoListRsp Clone() => default; // 0x0000000180DD1670-0x0000000180DD1760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetExpeditionAssistInfoListRsp ShallowCopy() => default; // 0x0000000180DD1260-0x0000000180DD1300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000180DD0C30-0x0000000180DD0C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000180DD18E0-0x0000000180DD1970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000180DD1970-0x0000000180DD1A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000180DD0C80-0x0000000180DD0D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000180DD0E00-0x0000000180DD0ED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetExpeditionAssistInfoListRsp other) => default; // 0x0000000180DD0ED0-0x0000000180DD1000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000180DD13F0-0x0000000180DD14F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000180DD1CE0-0x0000000180DD1EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000180DD1A60-0x0000000180DD1BA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000180DD1000-0x0000000180DD1140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetExpeditionAssistInfoListRsp other) {} // 0x0000000180DD0AD0-0x0000000180DD0C30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000180DD0910-0x0000000180DD0A70
}

