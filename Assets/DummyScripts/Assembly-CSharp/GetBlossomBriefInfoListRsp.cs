/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetBlossomBriefInfoListRsp : MessageBase, IMessage<GetBlossomBriefInfoListRsp> // TypeDefIndex: 22596
{
	// Fields
	private static readonly MessageParser<GetBlossomBriefInfoListRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B01F47
	private int retcode_; // 0x18
	public const int BriefInfoListFieldNumber = 2; // Metadata: 0x00B01F4B
	private static readonly FieldCodec<BlossomBriefInfo> _repeated_briefInfoList_codec; // 0x08
	private readonly RepeatedMessageField<BlossomBriefInfo> briefInfoList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetBlossomBriefInfoListRsp> Parser { get => default; } // 0x0000000183484460-0x00000001834844F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001834841F0-0x0000000183484280 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183483EE0-0x0000000183483F60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183483770-0x00000001834837D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183484890-0x0000000183484980 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001834846A0-0x0000000183484700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183484280-0x0000000183484370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183484840-0x0000000183484890 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183484000-0x00000001834840F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000183483E40-0x0000000183483EE0 0x0000000183483A60-0x0000000183483B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<BlossomBriefInfo> BriefInfoList { get => default; } // 0x0000000183483710-0x0000000183483770 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22597
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22598
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2702
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetBlossomBriefInfoListRsp() {} // 0x0000000183484C70-0x0000000183484D00
	static GetBlossomBriefInfoListRsp() {} // 0x0000000183484B60-0x0000000183484C70

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetBlossomBriefInfoListRsp Clone() => default; // 0x0000000183484370-0x0000000183484460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetBlossomBriefInfoListRsp ShallowCopy() => default; // 0x0000000183483F60-0x0000000183484000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183483930-0x0000000183483980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183484580-0x0000000183484610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183484610-0x00000001834846A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183483980-0x0000000183483A60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183483C30-0x0000000183483D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetBlossomBriefInfoListRsp other) => default; // 0x0000000183483B00-0x0000000183483C30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001834840F0-0x00000001834841F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183484980-0x0000000183484B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183484700-0x0000000183484840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183483D00-0x0000000183483E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetBlossomBriefInfoListRsp other) {} // 0x00000001834837D0-0x0000000183483930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001834835B0-0x0000000183483710
}

