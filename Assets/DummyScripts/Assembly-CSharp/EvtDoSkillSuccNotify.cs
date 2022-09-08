/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtDoSkillSuccNotify : MessageBase, IMessage<EvtDoSkillSuccNotify> // TypeDefIndex: 23003
{
	// Fields
	private static readonly MessageParser<EvtDoSkillSuccNotify> _parser; // 0x00
	public const int ForwardTypeFieldNumber = 1; // Metadata: 0x00B02E8B
	private ForwardType forwardType_; // 0x18
	public const int CasterIdFieldNumber = 2; // Metadata: 0x00B02E8F
	private uint casterId_; // 0x1C
	public const int SkillIdFieldNumber = 3; // Metadata: 0x00B02E93
	private uint skillId_; // 0x20
	public const int ForwardFieldNumber = 4; // Metadata: 0x00B02E97
	private Vector forward_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EvtDoSkillSuccNotify> Parser { get => default; } // 0x00000001831BCB30-0x00000001831BCBC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001831BC780-0x00000001831BC810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001831BC2B0-0x00000001831BC330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001831BB7C0-0x00000001831BB820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001831BD040-0x00000001831BD130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001831BCD50-0x00000001831BCDB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001831BC8B0-0x00000001831BC9A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001831BCF50-0x00000001831BCFA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001831BC470-0x00000001831BC560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForwardType ForwardType { get => default; set {} } // 0x00000001831BC210-0x00000001831BC2B0 0x00000001831BBB10-0x00000001831BBBB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CasterId { get => default; set {} } // 0x00000001831BB820-0x00000001831BB8C0 0x00000001831BCFA0-0x00000001831BD040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SkillId { get => default; set {} } // 0x00000001831BC3D0-0x00000001831BC470 0x00000001831BC810-0x00000001831BC8B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Forward { get => default; set {} } // 0x00000001831BBBB0-0x00000001831BBC50 0x00000001831BCA90-0x00000001831BCB30

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23004
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23005
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 304
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtDoSkillSuccNotify() {} // 0x00000001831BD4F0-0x00000001831BD560
	static EvtDoSkillSuccNotify() {} // 0x00000001831BD430-0x00000001831BD4F0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtDoSkillSuccNotify Clone() => default; // 0x00000001831BC9A0-0x00000001831BCA90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtDoSkillSuccNotify ShallowCopy() => default; // 0x00000001831BC330-0x00000001831BC3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001831BBA90-0x00000001831BBB10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001831BCC50-0x00000001831BCCD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001831BCCD0-0x00000001831BCD50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001831BBC50-0x00000001831BBDA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001831BBF10-0x00000001831BBFE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EvtDoSkillSuccNotify other) => default; // 0x00000001831BBDA0-0x00000001831BBF10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001831BC560-0x00000001831BC780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001831BD130-0x00000001831BD430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001831BCDB0-0x00000001831BCF50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001831BBFE0-0x00000001831BC210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EvtDoSkillSuccNotify other) {} // 0x00000001831BB8C0-0x00000001831BBA90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001831BB650-0x00000001831BB7C0
}

