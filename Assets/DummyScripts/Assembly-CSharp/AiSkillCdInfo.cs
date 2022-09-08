/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AiSkillCdInfo : MessageBase, IMessage<AiSkillCdInfo> // TypeDefIndex: 23091
{
	// Fields
	private static readonly MessageParser<AiSkillCdInfo> _parser; // 0x00
	public const int SkillCdMapFieldNumber = 1; // Metadata: 0x00B032CB
	private static readonly MapField<uint, uint> _map_skillCdMap_codec; // 0x08
	private readonly MapField<uint, uint> skillCdMap_; // 0x18
	public const int SkillGroupCdMapFieldNumber = 2; // Metadata: 0x00B032CF
	private static readonly MapField<uint, uint> _map_skillGroupCdMap_codec; // 0x10
	private readonly MapField<uint, uint> skillGroupCdMap_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AiSkillCdInfo> Parser { get => default; } // 0x000000018198B6E0-0x000000018198B770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018198B410-0x000000018198B4A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018198B0A0-0x000000018198B120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018198A9A0-0x000000018198AA00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018198BA80-0x000000018198BB70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018198B8A0-0x000000018198B900 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018198B500-0x000000018198B5F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018198BA30-0x000000018198BA80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018198B1C0-0x000000018198B2B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> SkillCdMap { get => default; } // 0x000000018198B4A0-0x000000018198B500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> SkillGroupCdMap { get => default; } // 0x000000018198AA00-0x000000018198AA60 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AiSkillCdInfo() {} // 0x000000018198BEC0-0x000000018198BF70
	static AiSkillCdInfo() {} // 0x000000018198BD30-0x000000018198BEC0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AiSkillCdInfo Clone() => default; // 0x000000018198B5F0-0x000000018198B6E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AiSkillCdInfo ShallowCopy() => default; // 0x000000018198B120-0x000000018198B1C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018198AB90-0x000000018198ABE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018198B800-0x000000018198B850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018198B850-0x000000018198B8A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018198ABE0-0x000000018198ACF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018198AEB0-0x000000018198AF80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AiSkillCdInfo other) => default; // 0x000000018198ACF0-0x000000018198AEB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018198B2B0-0x000000018198B410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018198BB70-0x000000018198BD30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018198B900-0x000000018198BA30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018198AF80-0x000000018198B0A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AiSkillCdInfo other) {} // 0x000000018198AA60-0x000000018198AB90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018198A800-0x000000018198A9A0
}

