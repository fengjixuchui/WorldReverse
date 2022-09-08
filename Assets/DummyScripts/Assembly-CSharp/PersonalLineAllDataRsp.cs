/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PersonalLineAllDataRsp : MessageBase, IMessage<PersonalLineAllDataRsp> // TypeDefIndex: 24674
{
	// Fields
	private static readonly MessageParser<PersonalLineAllDataRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B06F83
	private int retcode_; // 0x18
	public const int CurFinishedDailyTaskCountFieldNumber = 2; // Metadata: 0x00B06F87
	private uint curFinishedDailyTaskCount_; // 0x1C
	public const int LegendaryKeyCountFieldNumber = 3; // Metadata: 0x00B06F8B
	private uint legendaryKeyCount_; // 0x20
	public const int OngoingPersonalLineListFieldNumber = 4; // Metadata: 0x00B06F8F
	private static readonly FieldCodec<uint> _repeated_ongoingPersonalLineList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> ongoingPersonalLineList_; // 0x28
	public const int CanBeUnlockedPersonalLineListFieldNumber = 5; // Metadata: 0x00B06F93
	private static readonly FieldCodec<uint> _repeated_canBeUnlockedPersonalLineList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> canBeUnlockedPersonalLineList_; // 0x30
	public const int LockedPersonalLineListFieldNumber = 6; // Metadata: 0x00B06F97
	private static readonly FieldCodec<LockedPersonallineData> _repeated_lockedPersonalLineList_codec; // 0x18
	private readonly RepeatedMessageField<LockedPersonallineData> lockedPersonalLineList_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PersonalLineAllDataRsp> Parser { get => default; } // 0x0000000183DAB140-0x0000000183DAB1D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183DAAE30-0x0000000183DAAEC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183DAAA20-0x0000000183DAAAA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183DA9E20-0x0000000183DA9E80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183DAB6B0-0x0000000183DAB7A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183DAB3E0-0x0000000183DAB440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183DAAEC0-0x0000000183DAAFB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183DAB660-0x0000000183DAB6B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183DAAB40-0x0000000183DAAC30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000183DAA8E0-0x0000000183DAA980 0x0000000183DAA370-0x0000000183DAA410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurFinishedDailyTaskCount { get => default; set {} } // 0x0000000183DA9D80-0x0000000183DA9E20 0x0000000183DA9E80-0x0000000183DA9F20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint LegendaryKeyCount { get => default; set {} } // 0x0000000183DAA980-0x0000000183DAAA20 0x0000000183DAB0A0-0x0000000183DAB140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> OngoingPersonalLineList { get => default; } // 0x0000000183DAB2F0-0x0000000183DAB350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> CanBeUnlockedPersonalLineList { get => default; } // 0x0000000183DAADD0-0x0000000183DAAE30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<LockedPersonallineData> LockedPersonalLineList { get => default; } // 0x0000000183DAA160-0x0000000183DAA1C0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24675
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24676
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 436
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PersonalLineAllDataRsp() {} // 0x0000000183DABCD0-0x0000000183DABDA0
	static PersonalLineAllDataRsp() {} // 0x0000000183DABB80-0x0000000183DABCD0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PersonalLineAllDataRsp Clone() => default; // 0x0000000183DAAFB0-0x0000000183DAB0A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PersonalLineAllDataRsp ShallowCopy() => default; // 0x0000000183DAAAA0-0x0000000183DAAB40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183DAA110-0x0000000183DAA160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183DAB260-0x0000000183DAB2F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183DAB350-0x0000000183DAB3E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183DAA1C0-0x0000000183DAA370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183DAA5D0-0x0000000183DAA6A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PersonalLineAllDataRsp other) => default; // 0x0000000183DAA410-0x0000000183DAA5D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183DAAC30-0x0000000183DAADD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183DAB7A0-0x0000000183DABB80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183DAB440-0x0000000183DAB660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183DAA6A0-0x0000000183DAA8E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PersonalLineAllDataRsp other) {} // 0x0000000183DA9F20-0x0000000183DAA110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183DA9AF0-0x0000000183DA9D80
}

