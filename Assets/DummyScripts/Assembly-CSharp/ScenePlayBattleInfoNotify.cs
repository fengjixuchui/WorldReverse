/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ScenePlayBattleInfoNotify : MessageBase, IMessage<ScenePlayBattleInfoNotify> // TypeDefIndex: 25366
{
	// Fields
	private static readonly MessageParser<ScenePlayBattleInfoNotify> _parser; // 0x00
	public const int BattleInfoFieldNumber = 1; // Metadata: 0x00B0892B
	private ScenePlayBattleInfo battleInfo_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ScenePlayBattleInfoNotify> Parser { get => default; } // 0x0000000181A2FEB0-0x0000000181A2FF40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181A2FC40-0x0000000181A2FCD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181A2F8E0-0x0000000181A2F960 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181A2F110-0x0000000181A2F170 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181A30260-0x0000000181A30350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181A300D0-0x0000000181A30130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181A2FCD0-0x0000000181A2FDC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181A30210-0x0000000181A30260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181A2FA00-0x0000000181A2FAF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayBattleInfo BattleInfo { get => default; set {} } // 0x0000000181A2F170-0x0000000181A2F210 0x0000000181A2F510-0x0000000181A2F5B0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25367
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25368
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4351
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayBattleInfoNotify() {} // 0x0000000181A30560-0x0000000181A305C0
	static ScenePlayBattleInfoNotify() {} // 0x0000000181A304A0-0x0000000181A30560

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayBattleInfoNotify Clone() => default; // 0x0000000181A2FDC0-0x0000000181A2FEB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayBattleInfoNotify ShallowCopy() => default; // 0x0000000181A2F960-0x0000000181A2FA00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181A2F370-0x0000000181A2F3F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181A2FFD0-0x0000000181A30050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181A30050-0x0000000181A300D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181A2F3F0-0x0000000181A2F510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181A2F6C0-0x0000000181A2F790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ScenePlayBattleInfoNotify other) => default; // 0x0000000181A2F5B0-0x0000000181A2F6C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181A2FAF0-0x0000000181A2FC40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181A30350-0x0000000181A304A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181A30130-0x0000000181A30210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181A2F790-0x0000000181A2F8E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ScenePlayBattleInfoNotify other) {} // 0x0000000181A2F210-0x0000000181A2F370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181A2F000-0x0000000181A2F110
}

