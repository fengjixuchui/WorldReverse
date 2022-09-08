/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CutSceneBeginNotify : MessageBase, IMessage<CutSceneBeginNotify> // TypeDefIndex: 25185
{
	// Fields
	private static readonly MessageParser<CutSceneBeginNotify> _parser; // 0x00
	public const int CutsceneIdFieldNumber = 1; // Metadata: 0x00B0829F
	private uint cutsceneId_; // 0x18
	public const int IsWaitOthersFieldNumber = 2; // Metadata: 0x00B082A3
	private bool isWaitOthers_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CutSceneBeginNotify> Parser { get => default; } // 0x00000001838F6D50-0x00000001838F6DE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001838F6900-0x00000001838F6990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001838F6540-0x00000001838F65C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001838F6000-0x00000001838F6060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001838F70E0-0x00000001838F71D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001838F6F10-0x00000001838F6F70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001838F6B70-0x00000001838F6C60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001838F7090-0x00000001838F70E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001838F6660-0x00000001838F6750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CutsceneId { get => default; set {} } // 0x00000001838F6860-0x00000001838F6900 0x00000001838F6A30-0x00000001838F6AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsWaitOthers { get => default; set {} } // 0x00000001838F6AD0-0x00000001838F6B70 0x00000001838F6990-0x00000001838F6A30

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25186
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25187
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 295
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CutSceneBeginNotify() {} // 0x00000001838F7490-0x00000001838F74F0
	static CutSceneBeginNotify() {} // 0x00000001838F73D0-0x00000001838F7490

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CutSceneBeginNotify Clone() => default; // 0x00000001838F6C60-0x00000001838F6D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CutSceneBeginNotify ShallowCopy() => default; // 0x00000001838F65C0-0x00000001838F6660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001838F6190-0x00000001838F61E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001838F6E70-0x00000001838F6EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001838F6EC0-0x00000001838F6F10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001838F61E0-0x00000001838F6250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001838F6250-0x00000001838F6320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CutSceneBeginNotify other) => default; // 0x00000001838F6320-0x00000001838F6440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001838F6750-0x00000001838F6860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001838F71D0-0x00000001838F73D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001838F6F70-0x00000001838F7090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001838F6440-0x00000001838F6540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CutSceneBeginNotify other) {} // 0x00000001838F6060-0x00000001838F6190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001838F5F00-0x00000001838F6000
}

