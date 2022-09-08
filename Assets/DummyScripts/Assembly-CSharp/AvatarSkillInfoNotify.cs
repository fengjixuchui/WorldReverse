/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarSkillInfoNotify : MessageBase, IMessage<AvatarSkillInfoNotify> // TypeDefIndex: 25498
{
	// Fields
	private static readonly MessageParser<AvatarSkillInfoNotify> _parser; // 0x00
	public const int GuidFieldNumber = 1; // Metadata: 0x00B08E5B
	private ulong guid_; // 0x18
	public const int SkillMapFieldNumber = 2; // Metadata: 0x00B08E5F
	private static readonly MapField<uint, AvatarSkillInfo> _map_skillMap_codec; // 0x08
	private readonly MapField<uint, AvatarSkillInfo> skillMap_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AvatarSkillInfoNotify> Parser { get => default; } // 0x00000001833D19F0-0x00000001833D1A80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001833D1780-0x00000001833D1810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001833D1430-0x00000001833D14B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001833D0CA0-0x00000001833D0D00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001833D1DA0-0x00000001833D1E90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001833D1BB0-0x00000001833D1C10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001833D1810-0x00000001833D1900 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001833D1D50-0x00000001833D1DA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001833D1550-0x00000001833D1640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong Guid { get => default; set {} } // 0x00000001833D0E30-0x00000001833D0ED0 0x00000001833D0FE0-0x00000001833D1080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, AvatarSkillInfo> SkillMap { get => default; } // 0x00000001833D1080-0x00000001833D10E0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25499
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25500
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1008
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarSkillInfoNotify() {} // 0x00000001833D21E0-0x00000001833D2270
	static AvatarSkillInfoNotify() {} // 0x00000001833D2080-0x00000001833D21E0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarSkillInfoNotify Clone() => default; // 0x00000001833D1900-0x00000001833D19F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarSkillInfoNotify ShallowCopy() => default; // 0x00000001833D14B0-0x00000001833D1550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001833D0ED0-0x00000001833D0F20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001833D1B10-0x00000001833D1B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001833D1B60-0x00000001833D1BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001833D0F20-0x00000001833D0FE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001833D10E0-0x00000001833D11B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AvatarSkillInfoNotify other) => default; // 0x00000001833D11B0-0x00000001833D12F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001833D1640-0x00000001833D1780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001833D1E90-0x00000001833D2080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001833D1C10-0x00000001833D1D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001833D12F0-0x00000001833D1430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AvatarSkillInfoNotify other) {} // 0x00000001833D0D00-0x00000001833D0E30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001833D0B40-0x00000001833D0CA0
}

