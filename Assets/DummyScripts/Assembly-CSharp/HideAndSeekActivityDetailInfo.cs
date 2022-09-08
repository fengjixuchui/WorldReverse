/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HideAndSeekActivityDetailInfo : MessageBase, IMessage<HideAndSeekActivityDetailInfo> // TypeDefIndex: 22353
{
	// Fields
	private static readonly MessageParser<HideAndSeekActivityDetailInfo> _parser; // 0x00
	public const int ChosenHunterSkillListFieldNumber = 1; // Metadata: 0x00B0164B
	private static readonly FieldCodec<uint> _repeated_chosenHunterSkillList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> chosenHunterSkillList_; // 0x18
	public const int ChosenHiderSkillListFieldNumber = 2; // Metadata: 0x00B0164F
	private static readonly FieldCodec<uint> _repeated_chosenHiderSkillList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> chosenHiderSkillList_; // 0x20
	public const int UnlockMapListFieldNumber = 3; // Metadata: 0x00B01653
	private static readonly FieldCodec<uint> _repeated_unlockMapList_codec; // 0x18
	private readonly RepeatedPrimitiveField<uint> unlockMapList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HideAndSeekActivityDetailInfo> Parser { get => default; } // 0x0000000183DE8540-0x0000000183DE85D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183DE8210-0x0000000183DE82A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183DE7EE0-0x0000000183DE7F60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183DE77F0-0x0000000183DE7850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183DE8910-0x0000000183DE8A00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183DE8700-0x0000000183DE8760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183DE8360-0x0000000183DE8450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183DE88C0-0x0000000183DE8910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183DE8000-0x0000000183DE80F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ChosenHunterSkillList { get => default; } // 0x0000000183DE82A0-0x0000000183DE8300 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ChosenHiderSkillList { get => default; } // 0x0000000183DE7790-0x0000000183DE77F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> UnlockMapList { get => default; } // 0x0000000183DE8300-0x0000000183DE8360 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HideAndSeekActivityDetailInfo() {} // 0x0000000183DE8D50-0x0000000183DE8E20
	static HideAndSeekActivityDetailInfo() {} // 0x0000000183DE8C30-0x0000000183DE8D50

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HideAndSeekActivityDetailInfo Clone() => default; // 0x0000000183DE8450-0x0000000183DE8540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HideAndSeekActivityDetailInfo ShallowCopy() => default; // 0x0000000183DE7F60-0x0000000183DE8000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183DE79A0-0x0000000183DE79F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183DE8660-0x0000000183DE86B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183DE86B0-0x0000000183DE8700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183DE79F0-0x0000000183DE7B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183DE7CC0-0x0000000183DE7D90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HideAndSeekActivityDetailInfo other) => default; // 0x0000000183DE7B70-0x0000000183DE7CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183DE80F0-0x0000000183DE8210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183DE8A00-0x0000000183DE8C30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183DE8760-0x0000000183DE88C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183DE7D90-0x0000000183DE7EE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HideAndSeekActivityDetailInfo other) {} // 0x0000000183DE7850-0x0000000183DE79A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183DE7560-0x0000000183DE7790
}

