/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CityReputationQuestInfo : MessageBase, IMessage<CityReputationQuestInfo> // TypeDefIndex: 24746
{
	// Fields
	private static readonly MessageParser<CityReputationQuestInfo> _parser; // 0x00
	public const int IsOpenFieldNumber = 1; // Metadata: 0x00B0722B
	private bool isOpen_; // 0x18
	public const int TakenParentQuestRewardListFieldNumber = 2; // Metadata: 0x00B0722F
	private static readonly FieldCodec<uint> _repeated_takenParentQuestRewardList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> takenParentQuestRewardList_; // 0x20
	public const int FinishedParentQuestListFieldNumber = 3; // Metadata: 0x00B07233
	private static readonly FieldCodec<uint> _repeated_finishedParentQuestList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> finishedParentQuestList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CityReputationQuestInfo> Parser { get => default; } // 0x000000018188EE60-0x000000018188EEF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018188EBF0-0x000000018188EC80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018188E860-0x000000018188E8E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018188E130-0x000000018188E190 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018188F340-0x000000018188F430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018188F020-0x000000018188F080 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018188EC80-0x000000018188ED70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018188F2F0-0x000000018188F340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018188E9E0-0x000000018188EAD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsOpen { get => default; set {} } // 0x000000018188F080-0x000000018188F120 0x000000018188E190-0x000000018188E230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> TakenParentQuestRewardList { get => default; } // 0x000000018188E980-0x000000018188E9E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> FinishedParentQuestList { get => default; } // 0x000000018188F290-0x000000018188F2F0 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CityReputationQuestInfo() {} // 0x000000018188F790-0x000000018188F840
	static CityReputationQuestInfo() {} // 0x000000018188F690-0x000000018188F790

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CityReputationQuestInfo Clone() => default; // 0x000000018188ED70-0x000000018188EE60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CityReputationQuestInfo ShallowCopy() => default; // 0x000000018188E8E0-0x000000018188E980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018188E380-0x000000018188E3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018188EF80-0x000000018188EFD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018188EFD0-0x000000018188F020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018188E3D0-0x000000018188E500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018188E500-0x000000018188E5D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CityReputationQuestInfo other) => default; // 0x000000018188E5D0-0x000000018188E720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018188EAD0-0x000000018188EBF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018188F430-0x000000018188F690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018188F120-0x000000018188F290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018188E720-0x000000018188E860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CityReputationQuestInfo other) {} // 0x000000018188E230-0x000000018188E380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018188DF50-0x000000018188E130
}

