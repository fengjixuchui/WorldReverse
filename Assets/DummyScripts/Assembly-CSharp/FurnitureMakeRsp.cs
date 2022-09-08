/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FurnitureMakeRsp : MessageBase, IMessage<FurnitureMakeRsp> // TypeDefIndex: 23448
{
	// Fields
	private static readonly MessageParser<FurnitureMakeRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B040BF
	private int retcode_; // 0x18
	public const int FurnitureMakeSlotFieldNumber = 2; // Metadata: 0x00B040C3
	private FurnitureMakeSlot furnitureMakeSlot_; // 0x20
	public const int HelpDataListFieldNumber = 3; // Metadata: 0x00B040C7
	private static readonly FieldCodec<FurnitureMakeHelpData> _repeated_helpDataList_codec; // 0x08
	private readonly RepeatedMessageField<FurnitureMakeHelpData> helpDataList_; // 0x28
	public const int HelpedDataListFieldNumber = 4; // Metadata: 0x00B040CB
	private static readonly FieldCodec<FurnitureMakeBeHelpedData> _repeated_helpedDataList_codec; // 0x10
	private readonly RepeatedMessageField<FurnitureMakeBeHelpedData> helpedDataList_; // 0x30
	public const int MakeInfoListFieldNumber = 5; // Metadata: 0x00B040CF
	private static readonly FieldCodec<FurnitureMakeMakeInfo> _repeated_makeInfoList_codec; // 0x18
	private readonly RepeatedMessageField<FurnitureMakeMakeInfo> makeInfoList_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FurnitureMakeRsp> Parser { get => default; } // 0x000000018396FC80-0x000000018396FD10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018396FA10-0x000000018396FAA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018396F570-0x000000018396F5F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018396EA10-0x000000018396EA70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183970330-0x0000000183970420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183970040-0x00000001839700A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018396FAA0-0x000000018396FB90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001839702E0-0x0000000183970330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018396F690-0x000000018396F780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x000000018396F4D0-0x000000018396F570 0x000000018396EF50-0x000000018396EFF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FurnitureMakeSlot FurnitureMakeSlot { get => default; set {} } // 0x000000018396FED0-0x000000018396FF70 0x000000018396F970-0x000000018396FA10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<FurnitureMakeHelpData> HelpDataList { get => default; } // 0x000000018396FDA0-0x000000018396FE00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<FurnitureMakeBeHelpedData> HelpedDataList { get => default; } // 0x0000000183970420-0x0000000183970480 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<FurnitureMakeMakeInfo> MakeInfoList { get => default; } // 0x00000001839700A0-0x0000000183970100 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23449
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23450
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4602
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FurnitureMakeRsp() {} // 0x0000000183970970-0x0000000183970A40
	static FurnitureMakeRsp() {} // 0x00000001839707C0-0x0000000183970970

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FurnitureMakeRsp Clone() => default; // 0x000000018396FB90-0x000000018396FC80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FurnitureMakeRsp ShallowCopy() => default; // 0x000000018396F5F0-0x000000018396F690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018396EC90-0x000000018396ED10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018396FE00-0x000000018396FED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018396FF70-0x0000000183970040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018396ED10-0x000000018396EF50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018396EFF0-0x000000018396F0C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FurnitureMakeRsp other) => default; // 0x000000018396F0C0-0x000000018396F280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018396F780-0x000000018396F970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183970480-0x00000001839707C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183970100-0x00000001839702E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018396F280-0x000000018396F4D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FurnitureMakeRsp other) {} // 0x000000018396EA70-0x000000018396EC90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018396E790-0x000000018396EA10
}

