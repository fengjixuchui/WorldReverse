/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SceneTimeNotify : MessageBase, IMessage<SceneTimeNotify> // TypeDefIndex: 25142
{
	// Fields
	private static readonly MessageParser<SceneTimeNotify> _parser; // 0x00
	public const int SceneIdFieldNumber = 1; // Metadata: 0x00B08133
	private uint sceneId_; // 0x18
	public const int IsPausedFieldNumber = 2; // Metadata: 0x00B08137
	private bool isPaused_; // 0x1C
	public const int SceneTimeFieldNumber = 3; // Metadata: 0x00B0813B
	private ulong sceneTime_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SceneTimeNotify> Parser { get => default; } // 0x0000000183681EC0-0x0000000183681F50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183681BB0-0x0000000183681C40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001836817C0-0x0000000183681840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183681000-0x0000000183681060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183682330-0x0000000183682420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183682080-0x00000001836820E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183681CE0-0x0000000183681DD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183682240-0x0000000183682290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183681980-0x0000000183681A70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneId { get => default; set {} } // 0x0000000183681290-0x0000000183681330 0x0000000183681720-0x00000001836817C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsPaused { get => default; set {} } // 0x00000001836818E0-0x0000000183681980 0x0000000183681680-0x0000000183681720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong SceneTime { get => default; set {} } // 0x0000000183681C40-0x0000000183681CE0 0x0000000183682290-0x0000000183682330

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25143
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25144
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 281
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneTimeNotify() {} // 0x0000000183682770-0x00000001836827D0
	static SceneTimeNotify() {} // 0x00000001836826B0-0x0000000183682770

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneTimeNotify Clone() => default; // 0x0000000183681DD0-0x0000000183681EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneTimeNotify ShallowCopy() => default; // 0x0000000183681840-0x00000001836818E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001836811C0-0x0000000183681210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183681FE0-0x0000000183682030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183682030-0x0000000183682080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183681210-0x0000000183681290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183681470-0x0000000183681540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SceneTimeNotify other) => default; // 0x0000000183681330-0x0000000183681470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183681A70-0x0000000183681BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183682420-0x00000001836826B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001836820E0-0x0000000183682240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183681540-0x0000000183681680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SceneTimeNotify other) {} // 0x0000000183681060-0x00000001836811C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183680EF0-0x0000000183681000
}

