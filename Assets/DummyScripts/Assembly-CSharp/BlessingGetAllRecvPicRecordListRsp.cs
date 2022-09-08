/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BlessingGetAllRecvPicRecordListRsp : MessageBase, IMessage<BlessingGetAllRecvPicRecordListRsp> // TypeDefIndex: 22152
{
	// Fields
	private static readonly MessageParser<BlessingGetAllRecvPicRecordListRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B00E9F
	private int retcode_; // 0x18
	public const int RecvPicRecordListFieldNumber = 3; // Metadata: 0x00B00EA3
	private static readonly FieldCodec<BlessingRecvPicRecord> _repeated_recvPicRecordList_codec; // 0x08
	private readonly RepeatedMessageField<BlessingRecvPicRecord> recvPicRecordList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BlessingGetAllRecvPicRecordListRsp> Parser { get => default; } // 0x00000001825C0C10-0x00000001825C0CA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001825C09A0-0x00000001825C0A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001825C0690-0x00000001825C0710 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001825BFEC0-0x00000001825BFF20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001825C1040-0x00000001825C1130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001825C0E50-0x00000001825C0EB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001825C0A30-0x00000001825C0B20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001825C0FF0-0x00000001825C1040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001825C07B0-0x00000001825C08A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001825C05F0-0x00000001825C0690 0x00000001825C01B0-0x00000001825C0250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<BlessingRecvPicRecord> RecvPicRecordList { get => default; } // 0x00000001825C0250-0x00000001825C02B0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22153
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22154
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2152
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlessingGetAllRecvPicRecordListRsp() {} // 0x00000001825C1420-0x00000001825C14B0
	static BlessingGetAllRecvPicRecordListRsp() {} // 0x00000001825C1310-0x00000001825C1420

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlessingGetAllRecvPicRecordListRsp Clone() => default; // 0x00000001825C0B20-0x00000001825C0C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlessingGetAllRecvPicRecordListRsp ShallowCopy() => default; // 0x00000001825C0710-0x00000001825C07B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001825C0080-0x00000001825C00D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001825C0D30-0x00000001825C0DC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001825C0DC0-0x00000001825C0E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001825C00D0-0x00000001825C01B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001825C03E0-0x00000001825C04B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BlessingGetAllRecvPicRecordListRsp other) => default; // 0x00000001825C02B0-0x00000001825C03E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001825C08A0-0x00000001825C09A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001825C1130-0x00000001825C1310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001825C0EB0-0x00000001825C0FF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001825C04B0-0x00000001825C05F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BlessingGetAllRecvPicRecordListRsp other) {} // 0x00000001825BFF20-0x00000001825C0080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001825BFD60-0x00000001825BFEC0
}

