/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetDailyDungeonEntryInfoRsp : MessageBase, IMessage<GetDailyDungeonEntryInfoRsp> // TypeDefIndex: 22943
{
	// Fields
	private static readonly MessageParser<GetDailyDungeonEntryInfoRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B02B7B
	private int retcode_; // 0x18
	public const int DailyDungeonInfoListFieldNumber = 2; // Metadata: 0x00B02B7F
	private static readonly FieldCodec<DailyDungeonEntryInfo> _repeated_dailyDungeonInfoList_codec; // 0x08
	private readonly RepeatedMessageField<DailyDungeonEntryInfo> dailyDungeonInfoList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetDailyDungeonEntryInfoRsp> Parser { get => default; } // 0x000000018306C710-0x000000018306C7A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018306C4A0-0x000000018306C530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018306C190-0x000000018306C210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018306BA20-0x000000018306BA80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018306CBA0-0x000000018306CC90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018306C950-0x000000018306C9B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018306C530-0x000000018306C620 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018306CB50-0x000000018306CBA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018306C2B0-0x000000018306C3A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x000000018306C0F0-0x000000018306C190 0x000000018306BD10-0x000000018306BDB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<DailyDungeonEntryInfo> DailyDungeonInfoList { get => default; } // 0x000000018306C9B0-0x000000018306CA10 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22944
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22945
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 945
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetDailyDungeonEntryInfoRsp() {} // 0x000000018306CF80-0x000000018306D010
	static GetDailyDungeonEntryInfoRsp() {} // 0x000000018306CE70-0x000000018306CF80

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetDailyDungeonEntryInfoRsp Clone() => default; // 0x000000018306C620-0x000000018306C710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetDailyDungeonEntryInfoRsp ShallowCopy() => default; // 0x000000018306C210-0x000000018306C2B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018306BBE0-0x000000018306BC30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018306C830-0x000000018306C8C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018306C8C0-0x000000018306C950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018306BC30-0x000000018306BD10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018306BEE0-0x000000018306BFB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetDailyDungeonEntryInfoRsp other) => default; // 0x000000018306BDB0-0x000000018306BEE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018306C3A0-0x000000018306C4A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018306CC90-0x000000018306CE70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018306CA10-0x000000018306CB50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018306BFB0-0x000000018306C0F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetDailyDungeonEntryInfoRsp other) {} // 0x000000018306BA80-0x000000018306BBE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018306B8C0-0x000000018306BA20
}

