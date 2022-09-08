/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ScenePlayBattleInterruptNotify : MessageBase, IMessage<ScenePlayBattleInterruptNotify> // TypeDefIndex: 25400
{
	// Fields
	private static readonly MessageParser<ScenePlayBattleInterruptNotify> _parser; // 0x00
	public const int PlayIdFieldNumber = 1; // Metadata: 0x00B08A63
	private uint playId_; // 0x18
	public const int PlayTypeFieldNumber = 2; // Metadata: 0x00B08A67
	private uint playType_; // 0x1C
	public const int InterruptStateFieldNumber = 3; // Metadata: 0x00B08A6B
	private uint interruptState_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ScenePlayBattleInterruptNotify> Parser { get => default; } // 0x0000000183032E50-0x0000000183032EE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183032BE0-0x0000000183032C70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183032760-0x00000001830327E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183031F60-0x0000000183031FC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001830332C0-0x00000001830333B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183033010-0x0000000183033070 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183032C70-0x0000000183032D60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183033270-0x00000001830332C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183032880-0x0000000183032970 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayId { get => default; set {} } // 0x00000001830326C0-0x0000000183032760 0x0000000183032B40-0x0000000183032BE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayType { get => default; set {} } // 0x0000000183033070-0x0000000183033110 0x0000000183032290-0x0000000183032330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint InterruptState { get => default; set {} } // 0x0000000183032AA0-0x0000000183032B40 0x0000000183032120-0x00000001830321C0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25401
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25402
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4362
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayBattleInterruptNotify() {} // 0x0000000183033700-0x0000000183033760
	static ScenePlayBattleInterruptNotify() {} // 0x0000000183033640-0x0000000183033700

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayBattleInterruptNotify Clone() => default; // 0x0000000183032D60-0x0000000183032E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayBattleInterruptNotify ShallowCopy() => default; // 0x00000001830327E0-0x0000000183032880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001830321C0-0x0000000183032210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183032F70-0x0000000183032FC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183032FC0-0x0000000183033010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183032210-0x0000000183032290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183032330-0x0000000183032400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ScenePlayBattleInterruptNotify other) => default; // 0x0000000183032400-0x0000000183032540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183032970-0x0000000183032AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001830333B0-0x0000000183033640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183033110-0x0000000183033270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183032540-0x00000001830326C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ScenePlayBattleInterruptNotify other) {} // 0x0000000183031FC0-0x0000000183032120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183031E50-0x0000000183031F60
}

