/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ScenePlayerLocationNotify : MessageBase, IMessage<ScenePlayerLocationNotify> // TypeDefIndex: 24931
{
	// Fields
	private static readonly MessageParser<ScenePlayerLocationNotify> _parser; // 0x00
	public const int SceneIdFieldNumber = 1; // Metadata: 0x00B0794F
	private uint sceneId_; // 0x18
	public const int PlayerLocListFieldNumber = 2; // Metadata: 0x00B07953
	private static readonly FieldCodec<PlayerLocationInfo> _repeated_playerLocList_codec; // 0x08
	private readonly RepeatedMessageField<PlayerLocationInfo> playerLocList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ScenePlayerLocationNotify> Parser { get => default; } // 0x0000000185B3E710-0x0000000185B3E7A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000185B3E440-0x0000000185B3E4D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000185B3E130-0x0000000185B3E1B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000185B3D9C0-0x0000000185B3DA20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000185B3EB40-0x0000000185B3EC30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000185B3E950-0x0000000185B3E9B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000185B3E530-0x0000000185B3E620 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000185B3EAF0-0x0000000185B3EB40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000185B3E250-0x0000000185B3E340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneId { get => default; set {} } // 0x0000000185B3DCB0-0x0000000185B3DD50 0x0000000185B3E090-0x0000000185B3E130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<PlayerLocationInfo> PlayerLocList { get => default; } // 0x0000000185B3E4D0-0x0000000185B3E530 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24932
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24933
		{
			None = 0,
			EnetChannelId = 1,
			EnetIsReliable = 1,
			CmdId = 213
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayerLocationNotify() {} // 0x0000000185B3EF20-0x0000000185B3EFB0
	static ScenePlayerLocationNotify() {} // 0x0000000185B3EE10-0x0000000185B3EF20

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayerLocationNotify Clone() => default; // 0x0000000185B3E620-0x0000000185B3E710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayerLocationNotify ShallowCopy() => default; // 0x0000000185B3E1B0-0x0000000185B3E250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000185B3DB80-0x0000000185B3DBD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185B3E830-0x0000000185B3E8C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185B3E8C0-0x0000000185B3E950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000185B3DBD0-0x0000000185B3DCB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000185B3DD50-0x0000000185B3DE20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ScenePlayerLocationNotify other) => default; // 0x0000000185B3DE20-0x0000000185B3DF50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000185B3E340-0x0000000185B3E440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000185B3EC30-0x0000000185B3EE10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000185B3E9B0-0x0000000185B3EAF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000185B3DF50-0x0000000185B3E090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ScenePlayerLocationNotify other) {} // 0x0000000185B3DA20-0x0000000185B3DB80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000185B3D860-0x0000000185B3D9C0
}

