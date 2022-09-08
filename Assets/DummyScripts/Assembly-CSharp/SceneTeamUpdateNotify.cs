/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SceneTeamUpdateNotify : MessageBase, IMessage<SceneTeamUpdateNotify> // TypeDefIndex: 22493
{
	// Fields
	private static readonly MessageParser<SceneTeamUpdateNotify> _parser; // 0x00
	public const int SceneTeamAvatarListFieldNumber = 1; // Metadata: 0x00B01B53
	private static readonly FieldCodec<SceneTeamAvatar> _repeated_sceneTeamAvatarList_codec; // 0x08
	private readonly RepeatedMessageField<SceneTeamAvatar> sceneTeamAvatarList_; // 0x18
	public const int IsInMpFieldNumber = 3; // Metadata: 0x00B01B57
	private bool isInMp_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SceneTeamUpdateNotify> Parser { get => default; } // 0x0000000182C83320-0x0000000182C833B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182C830B0-0x0000000182C83140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182C82D10-0x0000000182C82D90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182C82620-0x0000000182C82680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182C83750-0x0000000182C83840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182C83560-0x0000000182C835C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182C83140-0x0000000182C83230 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182C83700-0x0000000182C83750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182C82E30-0x0000000182C82F20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<SceneTeamAvatar> SceneTeamAvatarList { get => default; } // 0x0000000182C829C0-0x0000000182C82A20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsInMp { get => default; set {} } // 0x0000000182C83010-0x0000000182C830B0 0x0000000182C82680-0x0000000182C82720

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22494
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22495
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1738
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneTeamUpdateNotify() {} // 0x0000000182C83B30-0x0000000182C83BC0
	static SceneTeamUpdateNotify() {} // 0x0000000182C83A20-0x0000000182C83B30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneTeamUpdateNotify Clone() => default; // 0x0000000182C83230-0x0000000182C83320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneTeamUpdateNotify ShallowCopy() => default; // 0x0000000182C82D90-0x0000000182C82E30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182C82890-0x0000000182C828E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182C83440-0x0000000182C834D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182C834D0-0x0000000182C83560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182C828E0-0x0000000182C829C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182C82B40-0x0000000182C82C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SceneTeamUpdateNotify other) => default; // 0x0000000182C82A20-0x0000000182C82B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182C82F20-0x0000000182C83010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182C83840-0x0000000182C83A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182C835C0-0x0000000182C83700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182C82C10-0x0000000182C82D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SceneTeamUpdateNotify other) {} // 0x0000000182C82720-0x0000000182C82890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182C824C0-0x0000000182C82620
}

