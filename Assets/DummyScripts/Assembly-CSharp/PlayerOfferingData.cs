/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerOfferingData : MessageBase, IMessage<PlayerOfferingData> // TypeDefIndex: 24222
{
	// Fields
	private static readonly MessageParser<PlayerOfferingData> _parser; // 0x00
	public const int OfferingIdFieldNumber = 1; // Metadata: 0x00B05E1B
	private uint offeringId_; // 0x18
	public const int LevelFieldNumber = 2; // Metadata: 0x00B05E1F
	private uint level_; // 0x1C
	public const int TakenLevelRewardListFieldNumber = 3; // Metadata: 0x00B05E23
	private static readonly FieldCodec<uint> _repeated_takenLevelRewardList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> takenLevelRewardList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerOfferingData> Parser { get => default; } // 0x0000000183622A90-0x0000000183622B20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183622780-0x0000000183622810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001836223A0-0x0000000183622420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183621C20-0x0000000183621C80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183622E70-0x0000000183622F60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183622C50-0x0000000183622CB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183622810-0x0000000183622900 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183622E20-0x0000000183622E70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183622560-0x0000000183622650 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint OfferingId { get => default; set {} } // 0x0000000183622F60-0x0000000183623000 0x00000001836229F0-0x0000000183622A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Level { get => default; set {} } // 0x0000000183621E40-0x0000000183621EE0 0x00000001836224C0-0x0000000183622560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> TakenLevelRewardList { get => default; } // 0x0000000183621DE0-0x0000000183621E40 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerOfferingData() {} // 0x0000000183623350-0x00000001836233E0
	static PlayerOfferingData() {} // 0x0000000183623270-0x0000000183623350

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerOfferingData Clone() => default; // 0x0000000183622900-0x00000001836229F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerOfferingData ShallowCopy() => default; // 0x0000000183622420-0x00000001836224C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183621EE0-0x0000000183621F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183622BB0-0x0000000183622C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183622C00-0x0000000183622C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183621F30-0x0000000183622000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183622140-0x0000000183622210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerOfferingData other) => default; // 0x0000000183622000-0x0000000183622140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183622650-0x0000000183622780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183623000-0x0000000183623270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183622CB0-0x0000000183622E20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183622210-0x00000001836223A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerOfferingData other) {} // 0x0000000183621C80-0x0000000183621DE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183621AA0-0x0000000183621C20
}

