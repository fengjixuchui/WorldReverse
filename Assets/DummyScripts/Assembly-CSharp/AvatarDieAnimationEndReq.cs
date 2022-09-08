/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarDieAnimationEndReq : MessageBase, IMessage<AvatarDieAnimationEndReq> // TypeDefIndex: 22438
{
	// Fields
	private static readonly MessageParser<AvatarDieAnimationEndReq> _parser; // 0x00
	public const int DieGuidFieldNumber = 1; // Metadata: 0x00B01943
	private ulong dieGuid_; // 0x18
	public const int SkillIdFieldNumber = 2; // Metadata: 0x00B01947
	private uint skillId_; // 0x20
	public const int RebornPosFieldNumber = 3; // Metadata: 0x00B0194B
	private Vector rebornPos_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AvatarDieAnimationEndReq> Parser { get => default; } // 0x000000018203B7E0-0x000000018203B870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018203B390-0x000000018203B420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018203AE90-0x000000018203AF10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018203A6C0-0x000000018203A720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018203BCB0-0x000000018203BDA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018203BAA0-0x000000018203BB00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018203B600-0x000000018203B6F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018203BC60-0x000000018203BCB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018203B050-0x000000018203B140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong DieGuid { get => default; set {} } // 0x000000018203B2F0-0x000000018203B390 0x000000018203B560-0x000000018203B600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SkillId { get => default; set {} } // 0x000000018203AFB0-0x000000018203B050 0x000000018203B420-0x000000018203B4C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector RebornPos { get => default; set {} } // 0x000000018203BA00-0x000000018203BAA0 0x000000018203B4C0-0x000000018203B560

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22439
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22440
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 1719
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarDieAnimationEndReq() {} // 0x000000018203C0D0-0x000000018203C130
	static AvatarDieAnimationEndReq() {} // 0x000000018203C010-0x000000018203C0D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarDieAnimationEndReq Clone() => default; // 0x000000018203B6F0-0x000000018203B7E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarDieAnimationEndReq ShallowCopy() => default; // 0x000000018203AF10-0x000000018203AFB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018203A8D0-0x000000018203A950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018203B900-0x000000018203B980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018203B980-0x000000018203BA00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018203A950-0x000000018203AA90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018203ABE0-0x000000018203ACB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AvatarDieAnimationEndReq other) => default; // 0x000000018203AA90-0x000000018203ABE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018203B140-0x000000018203B2F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018203BDA0-0x000000018203C010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018203BB00-0x000000018203BC60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018203ACB0-0x000000018203AE90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AvatarDieAnimationEndReq other) {} // 0x000000018203A720-0x000000018203A8D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018203A560-0x000000018203A6C0
}

