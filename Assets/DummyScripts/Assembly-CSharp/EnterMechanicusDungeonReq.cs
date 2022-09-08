/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EnterMechanicusDungeonReq : MessageBase, IMessage<EnterMechanicusDungeonReq> // TypeDefIndex: 23907
{
	// Fields
	private static readonly MessageParser<EnterMechanicusDungeonReq> _parser; // 0x00
	public const int DifficultLevelFieldNumber = 1; // Metadata: 0x00B051AB
	private uint difficultLevel_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EnterMechanicusDungeonReq> Parser { get => default; } // 0x00000001838940F0-0x0000000183894180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183893DE0-0x0000000183893E70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183893AF0-0x0000000183893B70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183893560-0x00000001838935C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183894440-0x0000000183894530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001838942B0-0x0000000183894310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183893F10-0x0000000183894000 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001838943F0-0x0000000183894440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183893C10-0x0000000183893D00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DifficultLevel { get => default; set {} } // 0x0000000183893E70-0x0000000183893F10 0x0000000183893A50-0x0000000183893AF0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23908
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23909
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 3911
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EnterMechanicusDungeonReq() {} // 0x0000000183894760-0x00000001838947C0
	static EnterMechanicusDungeonReq() {} // 0x00000001838946A0-0x0000000183894760

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EnterMechanicusDungeonReq Clone() => default; // 0x0000000183894000-0x00000001838940F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EnterMechanicusDungeonReq ShallowCopy() => default; // 0x0000000183893B70-0x0000000183893C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001838936D0-0x0000000183893720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183894210-0x0000000183894260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183894260-0x00000001838942B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183893720-0x0000000183893790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183893790-0x0000000183893860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EnterMechanicusDungeonReq other) => default; // 0x0000000183893860-0x0000000183893960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183893D00-0x0000000183893DE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183894530-0x00000001838946A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183894310-0x00000001838943F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183893960-0x0000000183893A50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EnterMechanicusDungeonReq other) {} // 0x00000001838935C0-0x00000001838936D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183893480-0x0000000183893560
}

