/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CodexDataUpdateNotify : MessageBase, IMessage<CodexDataUpdateNotify> // TypeDefIndex: 22659
{
	// Fields
	private static readonly MessageParser<CodexDataUpdateNotify> _parser; // 0x00
	public const int TypeFieldNumber = 1; // Metadata: 0x00B0216B
	private CodexType type_; // 0x18
	public const int IdFieldNumber = 2; // Metadata: 0x00B0216F
	private uint id_; // 0x1C
	public const int WeaponMaxPromoteLevelFieldNumber = 3; // Metadata: 0x00B02173
	private uint weaponMaxPromoteLevel_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CodexDataUpdateNotify> Parser { get => default; } // 0x00000001829799A0-0x0000000182979A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001829795F0-0x0000000182979680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182979270-0x00000001829792F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182978BB0-0x0000000182978C10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182979EB0-0x0000000182979FA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182979C00-0x0000000182979C60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001829797C0-0x00000001829798B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182979DC0-0x0000000182979E10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182979390-0x0000000182979480 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CodexType Type { get => default; set {} } // 0x0000000182978A00-0x0000000182978AA0 0x0000000182979E10-0x0000000182979EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Id { get => default; set {} } // 0x00000001829791D0-0x0000000182979270 0x0000000182979A30-0x0000000182979AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint WeaponMaxPromoteLevel { get => default; set {} } // 0x0000000182979680-0x0000000182979720 0x0000000182979720-0x00000001829797C0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22660
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22661
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4202
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CodexDataUpdateNotify() {} // 0x000000018297A2F0-0x000000018297A360
	static CodexDataUpdateNotify() {} // 0x000000018297A230-0x000000018297A2F0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CodexDataUpdateNotify Clone() => default; // 0x00000001829798B0-0x00000001829799A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CodexDataUpdateNotify ShallowCopy() => default; // 0x00000001829792F0-0x0000000182979390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182978D70-0x0000000182978DC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182979B60-0x0000000182979BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182979BB0-0x0000000182979C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182978DC0-0x0000000182978E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182978E40-0x0000000182978F10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CodexDataUpdateNotify other) => default; // 0x0000000182978F10-0x0000000182979050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182979480-0x00000001829795F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182979FA0-0x000000018297A230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182979C60-0x0000000182979DC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182979050-0x00000001829791D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CodexDataUpdateNotify other) {} // 0x0000000182978C10-0x0000000182978D70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182978AA0-0x0000000182978BB0
}

