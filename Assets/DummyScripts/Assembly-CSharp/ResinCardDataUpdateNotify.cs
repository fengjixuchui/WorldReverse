/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ResinCardDataUpdateNotify : MessageBase, IMessage<ResinCardDataUpdateNotify> // TypeDefIndex: 24722
{
	// Fields
	private static readonly MessageParser<ResinCardDataUpdateNotify> _parser; // 0x00
	public const int CardDataListFieldNumber = 1; // Metadata: 0x00B0714B
	private static readonly FieldCodec<ResinCardData> _repeated_cardDataList_codec; // 0x08
	private readonly RepeatedMessageField<ResinCardData> cardDataList_; // 0x18
	public const int TodayStartTimeFieldNumber = 2; // Metadata: 0x00B0714F
	private uint todayStartTime_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ResinCardDataUpdateNotify> Parser { get => default; } // 0x0000000182234B00-0x0000000182234B90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001822347F0-0x0000000182234880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001822344E0-0x0000000182234560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182233EB0-0x0000000182233F10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182235030-0x0000000182235120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182234E40-0x0000000182234EA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182234920-0x0000000182234A10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182234FE0-0x0000000182235030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182234600-0x00000001822346F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ResinCardData> CardDataList { get => default; } // 0x0000000182234D40-0x0000000182234DA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TodayStartTime { get => default; set {} } // 0x0000000182234880-0x0000000182234920 0x0000000182234DA0-0x0000000182234E40

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24723
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24724
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4110
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ResinCardDataUpdateNotify() {} // 0x0000000182235410-0x00000001822354A0
	static ResinCardDataUpdateNotify() {} // 0x0000000182235300-0x0000000182235410

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ResinCardDataUpdateNotify Clone() => default; // 0x0000000182234A10-0x0000000182234B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ResinCardDataUpdateNotify ShallowCopy() => default; // 0x0000000182234560-0x0000000182234600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182234080-0x00000001822340D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182234C20-0x0000000182234CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182234CB0-0x0000000182234D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001822340D0-0x00000001822341B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001822342D0-0x00000001822343A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ResinCardDataUpdateNotify other) => default; // 0x00000001822341B0-0x00000001822342D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001822346F0-0x00000001822347F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182235120-0x0000000182235300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182234EA0-0x0000000182234FE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001822343A0-0x00000001822344E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ResinCardDataUpdateNotify other) {} // 0x0000000182233F10-0x0000000182234080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182233D50-0x0000000182233EB0
}

