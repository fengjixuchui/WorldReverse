/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetQuestTalkHistoryRsp : MessageBase, IMessage<GetQuestTalkHistoryRsp> // TypeDefIndex: 24590
{
	// Fields
	private static readonly MessageParser<GetQuestTalkHistoryRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B06C6F
	private int retcode_; // 0x18
	public const int ParentQuestIdFieldNumber = 2; // Metadata: 0x00B06C73
	private uint parentQuestId_; // 0x1C
	public const int TalkIdListFieldNumber = 3; // Metadata: 0x00B06C77
	private static readonly FieldCodec<uint> _repeated_talkIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> talkIdList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetQuestTalkHistoryRsp> Parser { get => default; } // 0x0000000183B18BA0-0x0000000183B18C30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183B18890-0x0000000183B18920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183B18550-0x0000000183B185D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183B17C90-0x0000000183B17CF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183B18F80-0x0000000183B19070 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183B18D60-0x0000000183B18DC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183B189C0-0x0000000183B18AB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183B18F30-0x0000000183B18F80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183B18670-0x0000000183B18760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000183B18450-0x0000000183B184F0 0x0000000183B17F70-0x0000000183B18010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ParentQuestId { get => default; set {} } // 0x0000000183B18010-0x0000000183B180B0 0x0000000183B18920-0x0000000183B189C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> TalkIdList { get => default; } // 0x0000000183B184F0-0x0000000183B18550 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24591
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24592
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 409
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetQuestTalkHistoryRsp() {} // 0x0000000183B193C0-0x0000000183B19450
	static GetQuestTalkHistoryRsp() {} // 0x0000000183B192E0-0x0000000183B193C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetQuestTalkHistoryRsp Clone() => default; // 0x0000000183B18AB0-0x0000000183B18BA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetQuestTalkHistoryRsp ShallowCopy() => default; // 0x0000000183B185D0-0x0000000183B18670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183B17E50-0x0000000183B17EA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183B18CC0-0x0000000183B18D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183B18D10-0x0000000183B18D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183B17EA0-0x0000000183B17F70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183B180B0-0x0000000183B18180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetQuestTalkHistoryRsp other) => default; // 0x0000000183B18180-0x0000000183B182C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183B18760-0x0000000183B18890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183B19070-0x0000000183B192E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183B18DC0-0x0000000183B18F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183B182C0-0x0000000183B18450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetQuestTalkHistoryRsp other) {} // 0x0000000183B17CF0-0x0000000183B17E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183B17B10-0x0000000183B17C90
}

