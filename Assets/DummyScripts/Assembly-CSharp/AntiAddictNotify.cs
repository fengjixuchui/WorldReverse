/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AntiAddictNotify : MessageBase, IMessage<AntiAddictNotify> // TypeDefIndex: 24492
{
	// Fields
	private static readonly MessageParser<AntiAddictNotify> _parser; // 0x00
	public const int MsgTypeFieldNumber = 1; // Metadata: 0x00B068C7
	private int msgType_; // 0x18
	public const int MsgFieldNumber = 2; // Metadata: 0x00B068CB
	private string msg_; // 0x20
	public const int LevelFieldNumber = 3; // Metadata: 0x00B068CF
	private string level_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AntiAddictNotify> Parser { get => default; } // 0x000000018302F9A0-0x000000018302FA30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018302F690-0x000000018302F720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018302F1B0-0x000000018302F230 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018302EA10-0x000000018302EA70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018302FE40-0x000000018302FF30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018302FC00-0x000000018302FC60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018302F7C0-0x000000018302F8B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018302FDF0-0x000000018302FE40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018302F380-0x000000018302F470 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int MsgType { get => default; set {} } // 0x000000018302F720-0x000000018302F7C0 0x000000018302FB60-0x000000018302FC00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Msg { get => default; set {} } // 0x000000018302F5F0-0x000000018302F690 0x000000018302FF30-0x000000018302FFE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Level { get => default; set {} } // 0x000000018302EC00-0x000000018302ECA0 0x000000018302F2D0-0x000000018302F380

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24493
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24494
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 163
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AntiAddictNotify() {} // 0x0000000183030300-0x0000000183030380
	static AntiAddictNotify() {} // 0x0000000183030240-0x0000000183030300

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AntiAddictNotify Clone() => default; // 0x000000018302F8B0-0x000000018302F9A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AntiAddictNotify ShallowCopy() => default; // 0x000000018302F230-0x000000018302F2D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018302ECA0-0x000000018302ECF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018302FAC0-0x000000018302FB10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018302FB10-0x000000018302FB60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018302ECF0-0x000000018302ED80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018302EF20-0x000000018302EFF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AntiAddictNotify other) => default; // 0x000000018302ED80-0x000000018302EF20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018302F470-0x000000018302F5F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018302FFE0-0x0000000183030240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018302FC60-0x000000018302FDF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018302EFF0-0x000000018302F1B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AntiAddictNotify other) {} // 0x000000018302EA70-0x000000018302EC00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018302E900-0x000000018302EA10
}

