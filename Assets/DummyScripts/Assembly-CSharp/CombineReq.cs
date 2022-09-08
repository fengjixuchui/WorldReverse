/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CombineReq : MessageBase, IMessage<CombineReq> // TypeDefIndex: 23696
{
	// Fields
	private static readonly MessageParser<CombineReq> _parser; // 0x00
	public const int CombineIdFieldNumber = 1; // Metadata: 0x00B049EF
	private uint combineId_; // 0x18
	public const int CombineCountFieldNumber = 2; // Metadata: 0x00B049F3
	private uint combineCount_; // 0x1C
	public const int AvatarGuidFieldNumber = 3; // Metadata: 0x00B049F7
	private ulong avatarGuid_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CombineReq> Parser { get => default; } // 0x0000000181FBEFE0-0x0000000181FBF070 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181FBECD0-0x0000000181FBED60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181FBE8E0-0x0000000181FBE960 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181FBE0E0-0x0000000181FBE140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181FBF450-0x0000000181FBF540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181FBF240-0x0000000181FBF2A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181FBEE00-0x0000000181FBEEF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181FBF400-0x0000000181FBF450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181FBEAA0-0x0000000181FBEB90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CombineId { get => default; set {} } // 0x0000000181FBE410-0x0000000181FBE4B0 0x0000000181FBF1A0-0x0000000181FBF240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CombineCount { get => default; set {} } // 0x0000000181FBE840-0x0000000181FBE8E0 0x0000000181FBEA00-0x0000000181FBEAA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong AvatarGuid { get => default; set {} } // 0x0000000181FBED60-0x0000000181FBEE00 0x0000000181FBE2A0-0x0000000181FBE340

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23697
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23698
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 634
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CombineReq() {} // 0x0000000181FBF890-0x0000000181FBF8F0
	static CombineReq() {} // 0x0000000181FBF7D0-0x0000000181FBF890

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CombineReq Clone() => default; // 0x0000000181FBEEF0-0x0000000181FBEFE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CombineReq ShallowCopy() => default; // 0x0000000181FBE960-0x0000000181FBEA00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181FBE340-0x0000000181FBE390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181FBF100-0x0000000181FBF150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181FBF150-0x0000000181FBF1A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181FBE390-0x0000000181FBE410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181FBE4B0-0x0000000181FBE580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CombineReq other) => default; // 0x0000000181FBE580-0x0000000181FBE6C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181FBEB90-0x0000000181FBECD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181FBF540-0x0000000181FBF7D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181FBF2A0-0x0000000181FBF400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181FBE6C0-0x0000000181FBE840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CombineReq other) {} // 0x0000000181FBE140-0x0000000181FBE2A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181FBDFD0-0x0000000181FBE0E0
}

