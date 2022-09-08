/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarTeamResonanceInfo : MessageBase, IMessage<AvatarTeamResonanceInfo> // TypeDefIndex: 25525
{
	// Fields
	private static readonly MessageParser<AvatarTeamResonanceInfo> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B08F6F
	private uint entityId_; // 0x18
	public const int AvatarGuidFieldNumber = 2; // Metadata: 0x00B08F73
	private ulong avatarGuid_; // 0x20
	public const int AddTeamResonanceIdListFieldNumber = 3; // Metadata: 0x00B08F77
	private static readonly FieldCodec<uint> _repeated_addTeamResonanceIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> addTeamResonanceIdList_; // 0x28
	public const int DelTeamResonanceIdListFieldNumber = 4; // Metadata: 0x00B08F7B
	private static readonly FieldCodec<uint> _repeated_delTeamResonanceIdList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> delTeamResonanceIdList_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AvatarTeamResonanceInfo> Parser { get => default; } // 0x000000018349AE80-0x000000018349AF10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018349AB70-0x000000018349AC00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018349A7B0-0x000000018349A830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183499FB0-0x000000018349A010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018349B3A0-0x000000018349B490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018349B140-0x000000018349B1A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018349ACA0-0x000000018349AD90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018349B350-0x000000018349B3A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018349A8D0-0x000000018349A9C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x000000018349B0A0-0x000000018349B140 0x000000018349B490-0x000000018349B530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong AvatarGuid { get => default; set {} } // 0x000000018349AC00-0x000000018349ACA0 0x000000018349A190-0x000000018349A230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> AddTeamResonanceIdList { get => default; } // 0x000000018349B040-0x000000018349B0A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> DelTeamResonanceIdList { get => default; } // 0x000000018349AB10-0x000000018349AB70 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarTeamResonanceInfo() {} // 0x000000018349B910-0x000000018349B9C0
	static AvatarTeamResonanceInfo() {} // 0x000000018349B810-0x000000018349B910

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarTeamResonanceInfo Clone() => default; // 0x000000018349AD90-0x000000018349AE80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarTeamResonanceInfo ShallowCopy() => default; // 0x000000018349A830-0x000000018349A8D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018349A230-0x000000018349A280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018349AFA0-0x000000018349AFF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018349AFF0-0x000000018349B040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018349A280-0x000000018349A3B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018349A3B0-0x000000018349A480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AvatarTeamResonanceInfo other) => default; // 0x000000018349A480-0x000000018349A5F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018349A9C0-0x000000018349AB10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018349B530-0x000000018349B810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018349B1A0-0x000000018349B350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018349A5F0-0x000000018349A7B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AvatarTeamResonanceInfo other) {} // 0x000000018349A010-0x000000018349A190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183499DC0-0x0000000183499FB0
}

