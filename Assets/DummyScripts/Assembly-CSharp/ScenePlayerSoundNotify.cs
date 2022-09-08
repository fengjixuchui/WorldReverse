/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ScenePlayerSoundNotify : MessageBase, IMessage<ScenePlayerSoundNotify> // TypeDefIndex: 25078
{
	// Fields
	private static readonly MessageParser<ScenePlayerSoundNotify> _parser; // 0x00
	public const int SoundNameFieldNumber = 1; // Metadata: 0x00B07EEF
	private string soundName_; // 0x18
	public const int PlayPosFieldNumber = 2; // Metadata: 0x00B07EF3
	private Vector playPos_; // 0x20
	public const int PlayTypeFieldNumber = 3; // Metadata: 0x00B07EF7
	private Types.PlaySoundType playType_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ScenePlayerSoundNotify> Parser { get => default; } // 0x0000000182C37930-0x0000000182C379C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182C374D0-0x0000000182C37560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182C370A0-0x0000000182C37120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182C36710-0x0000000182C36770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182C37E10-0x0000000182C37F00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182C37B50-0x0000000182C37BB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182C37600-0x0000000182C376F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182C37DC0-0x0000000182C37E10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182C371C0-0x0000000182C372B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string SoundName { get => default; set {} } // 0x0000000182C37890-0x0000000182C37930 0x0000000182C377E0-0x0000000182C37890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector PlayPos { get => default; set {} } // 0x0000000182C37560-0x0000000182C37600 0x0000000182C36940-0x0000000182C369E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.PlaySoundType PlayType { get => default; set {} } // 0x0000000182C37BB0-0x0000000182C37C50 0x0000000182C36BA0-0x0000000182C36C40

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25079
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25080
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 261
		}

		public enum PlaySoundType // TypeDefIndex: 25081
		{
			PlaySoundNone = 0,
			PlaySoundStart = 1,
			PlaySoundStop = 2
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayerSoundNotify() {} // 0x0000000182C38220-0x0000000182C382A0
	static ScenePlayerSoundNotify() {} // 0x0000000182C38160-0x0000000182C38220

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayerSoundNotify Clone() => default; // 0x0000000182C376F0-0x0000000182C377E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayerSoundNotify ShallowCopy() => default; // 0x0000000182C37120-0x0000000182C371C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182C369E0-0x0000000182C36A60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182C37A50-0x0000000182C37AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182C37AD0-0x0000000182C37B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182C36A60-0x0000000182C36BA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182C36C40-0x0000000182C36D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ScenePlayerSoundNotify other) => default; // 0x0000000182C36D10-0x0000000182C36E90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182C372B0-0x0000000182C374D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182C37F00-0x0000000182C38160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182C37C50-0x0000000182C37DC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182C36E90-0x0000000182C370A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ScenePlayerSoundNotify other) {} // 0x0000000182C36770-0x0000000182C36940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182C365C0-0x0000000182C36710
}

