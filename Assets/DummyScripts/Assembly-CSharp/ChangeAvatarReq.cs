/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ChangeAvatarReq : MessageBase, IMessage<ChangeAvatarReq> // TypeDefIndex: 22402
{
	// Fields
	private static readonly MessageParser<ChangeAvatarReq> _parser; // 0x00
	public const int GuidFieldNumber = 1; // Metadata: 0x00B017EF
	private ulong guid_; // 0x18
	public const int SkillIdFieldNumber = 2; // Metadata: 0x00B017F3
	private uint skillId_; // 0x20
	public const int IsMoveFieldNumber = 3; // Metadata: 0x00B017F7
	private bool isMove_; // 0x24
	public const int MovePosFieldNumber = 4; // Metadata: 0x00B017FB
	private Vector movePos_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ChangeAvatarReq> Parser { get => default; } // 0x0000000182611060-0x00000001826110F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182610D50-0x0000000182610DE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001826108C0-0x0000000182610940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018260FEB0-0x000000018260FF10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182611610-0x0000000182611700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182611280-0x00000001826112E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182610E80-0x0000000182610F70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182611520-0x0000000182611570 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182610A80-0x0000000182610B70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong Guid { get => default; set {} } // 0x0000000182610180-0x0000000182610220 0x00000001826103F0-0x0000000182610490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SkillId { get => default; set {} } // 0x00000001826109E0-0x0000000182610A80 0x0000000182610DE0-0x0000000182610E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsMove { get => default; set {} } // 0x0000000182611700-0x00000001826117A0 0x00000001826100E0-0x0000000182610180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector MovePos { get => default; set {} } // 0x00000001826112E0-0x0000000182611380 0x0000000182611570-0x0000000182611610

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22403
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22404
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 1707
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChangeAvatarReq() {} // 0x0000000182611B60-0x0000000182611BC0
	static ChangeAvatarReq() {} // 0x0000000182611AA0-0x0000000182611B60

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChangeAvatarReq Clone() => default; // 0x0000000182610F70-0x0000000182611060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChangeAvatarReq ShallowCopy() => default; // 0x0000000182610940-0x00000001826109E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182610220-0x00000001826102A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182611180-0x0000000182611200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182611200-0x0000000182611280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001826102A0-0x00000001826103F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182610490-0x0000000182610560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ChangeAvatarReq other) => default; // 0x0000000182610560-0x00000001826106D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182610B70-0x0000000182610D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001826117A0-0x0000000182611AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182611380-0x0000000182611520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001826106D0-0x00000001826108C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ChangeAvatarReq other) {} // 0x000000018260FF10-0x00000001826100E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018260FD30-0x000000018260FEB0
}

