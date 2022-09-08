/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarSkillInfo : MessageBase, IMessage<AvatarSkillInfo> // TypeDefIndex: 26065
{
	// Fields
	private static readonly MessageParser<AvatarSkillInfo> _parser; // 0x00
	public const int PassCdTimeFieldNumber = 1; // Metadata: 0x00B0AF33
	private uint passCdTime_; // 0x18
	public const int FullCdTimeListFieldNumber = 2; // Metadata: 0x00B0AF37
	private static readonly FieldCodec<uint> _repeated_fullCdTimeList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> fullCdTimeList_; // 0x20
	public const int MaxChargeCountFieldNumber = 3; // Metadata: 0x00B0AF3B
	private uint maxChargeCount_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AvatarSkillInfo> Parser { get => default; } // 0x000000018439F3D0-0x000000018439F460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018439F020-0x000000018439F0B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018439ECE0-0x000000018439ED60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018439E550-0x000000018439E5B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018439F860-0x000000018439F950 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018439F630-0x000000018439F690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018439F150-0x000000018439F240 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018439F810-0x000000018439F860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018439EE00-0x000000018439EEF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PassCdTime { get => default; set {} } // 0x000000018439E840-0x000000018439E8E0 0x000000018439F590-0x000000018439F630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> FullCdTimeList { get => default; } // 0x000000018439EAF0-0x000000018439EB50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MaxChargeCount { get => default; set {} } // 0x000000018439F240-0x000000018439F2E0 0x000000018439F0B0-0x000000018439F150

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarSkillInfo() {} // 0x000000018439FCA0-0x000000018439FD30
	static AvatarSkillInfo() {} // 0x000000018439FBC0-0x000000018439FCA0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarSkillInfo Clone() => default; // 0x000000018439F2E0-0x000000018439F3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarSkillInfo ShallowCopy() => default; // 0x000000018439ED60-0x000000018439EE00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018439E710-0x000000018439E760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018439F4F0-0x000000018439F540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018439F540-0x000000018439F590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018439E760-0x000000018439E840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018439E8E0-0x000000018439E9B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AvatarSkillInfo other) => default; // 0x000000018439E9B0-0x000000018439EAF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018439EEF0-0x000000018439F020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018439F950-0x000000018439FBC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018439F690-0x000000018439F810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018439EB50-0x000000018439ECE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AvatarSkillInfo other) {} // 0x000000018439E5B0-0x000000018439E710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018439E3D0-0x000000018439E550
}

