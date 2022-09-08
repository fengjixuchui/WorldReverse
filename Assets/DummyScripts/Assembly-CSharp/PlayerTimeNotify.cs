/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerTimeNotify : MessageBase, IMessage<PlayerTimeNotify> // TypeDefIndex: 24419
{
	// Fields
	private static readonly MessageParser<PlayerTimeNotify> _parser; // 0x00
	public const int IsPausedFieldNumber = 1; // Metadata: 0x00B06647
	private bool isPaused_; // 0x18
	public const int PlayerTimeFieldNumber = 2; // Metadata: 0x00B0664B
	private ulong playerTime_; // 0x20
	public const int ServerTimeFieldNumber = 3; // Metadata: 0x00B0664F
	private ulong serverTime_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerTimeNotify> Parser { get => default; } // 0x0000000183EC7B20-0x0000000183EC7BB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183EC7810-0x0000000183EC78A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183EC7380-0x0000000183EC7400 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183EC6BB0-0x0000000183EC6C10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183EC7EF0-0x0000000183EC7FE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183EC7CE0-0x0000000183EC7D40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183EC7940-0x0000000183EC7A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183EC7EA0-0x0000000183EC7EF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183EC75E0-0x0000000183EC76D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsPaused { get => default; set {} } // 0x0000000183EC7540-0x0000000183EC75E0 0x0000000183EC7240-0x0000000183EC72E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong PlayerTime { get => default; set {} } // 0x0000000183EC7050-0x0000000183EC70F0 0x0000000183EC7400-0x0000000183EC74A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong ServerTime { get => default; set {} } // 0x0000000183EC72E0-0x0000000183EC7380 0x0000000183EC78A0-0x0000000183EC7940

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24420
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24421
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 140
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerTimeNotify() {} // 0x0000000183EC8330-0x0000000183EC8390
	static PlayerTimeNotify() {} // 0x0000000183EC8270-0x0000000183EC8330

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerTimeNotify Clone() => default; // 0x0000000183EC7A30-0x0000000183EC7B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerTimeNotify ShallowCopy() => default; // 0x0000000183EC74A0-0x0000000183EC7540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183EC6D70-0x0000000183EC6DC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183EC7C40-0x0000000183EC7C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183EC7C90-0x0000000183EC7CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183EC6DC0-0x0000000183EC6E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183EC6E40-0x0000000183EC6F10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerTimeNotify other) => default; // 0x0000000183EC6F10-0x0000000183EC7050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183EC76D0-0x0000000183EC7810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183EC7FE0-0x0000000183EC8270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183EC7D40-0x0000000183EC7EA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183EC70F0-0x0000000183EC7240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerTimeNotify other) {} // 0x0000000183EC6C10-0x0000000183EC6D70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183EC6A90-0x0000000183EC6BB0
}

