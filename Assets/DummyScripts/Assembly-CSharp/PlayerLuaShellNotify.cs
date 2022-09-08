/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerLuaShellNotify : MessageBase, IMessage<PlayerLuaShellNotify> // TypeDefIndex: 24486
{
	// Fields
	private static readonly MessageParser<PlayerLuaShellNotify> _parser; // 0x00
	public const int IdFieldNumber = 1; // Metadata: 0x00B06897
	private uint id_; // 0x18
	public const int LuaShellFieldNumber = 2; // Metadata: 0x00B0689B
	private ByteString luaShell_; // 0x20
	public const int UseTypeFieldNumber = 3; // Metadata: 0x00B0689F
	private uint useType_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerLuaShellNotify> Parser { get => default; } // 0x000000018425C7E0-0x000000018425C870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018425C430-0x000000018425C4C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018425C0C0-0x000000018425C140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018425B8C0-0x000000018425B920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018425CC70-0x000000018425CD60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018425CA40-0x000000018425CAA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018425C4C0-0x000000018425C5B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018425CC20-0x000000018425CC70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018425C1E0-0x000000018425C2D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Id { get => default; set {} } // 0x000000018425C020-0x000000018425C0C0 0x000000018425C870-0x000000018425C910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ByteString LuaShell { get => default; set {} } // 0x000000018425B920-0x000000018425B9C0 0x000000018425CD60-0x000000018425CE10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint UseType { get => default; set {} } // 0x000000018425C740-0x000000018425C7E0 0x000000018425C6A0-0x000000018425C740

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24487
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24488
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 161
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerLuaShellNotify() {} // 0x000000018425D140-0x000000018425D1D0
	static PlayerLuaShellNotify() {} // 0x000000018425D080-0x000000018425D140

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerLuaShellNotify Clone() => default; // 0x000000018425C5B0-0x000000018425C6A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerLuaShellNotify ShallowCopy() => default; // 0x000000018425C140-0x000000018425C1E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018425BB40-0x000000018425BB90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018425C9A0-0x000000018425C9F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018425C9F0-0x000000018425CA40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018425BB90-0x000000018425BC40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018425BC40-0x000000018425BD10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerLuaShellNotify other) => default; // 0x000000018425BD10-0x000000018425BE80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018425C2D0-0x000000018425C430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018425CE10-0x000000018425D080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018425CAA0-0x000000018425CC20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018425BE80-0x000000018425C020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerLuaShellNotify other) {} // 0x000000018425B9C0-0x000000018425BB40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018425B7B0-0x000000018425B8C0
}

