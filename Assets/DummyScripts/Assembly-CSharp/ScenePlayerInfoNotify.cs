/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ScenePlayerInfoNotify : MessageBase, IMessage<ScenePlayerInfoNotify> // TypeDefIndex: 25027
{
	// Fields
	private static readonly MessageParser<ScenePlayerInfoNotify> _parser; // 0x00
	public const int PlayerInfoListFieldNumber = 1; // Metadata: 0x00B07CF3
	private static readonly FieldCodec<ScenePlayerInfo> _repeated_playerInfoList_codec; // 0x08
	private readonly RepeatedMessageField<ScenePlayerInfo> playerInfoList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ScenePlayerInfoNotify> Parser { get => default; } // 0x0000000182CEE490-0x0000000182CEE520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182CEE220-0x0000000182CEE2B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182CEDF50-0x0000000182CEDFD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182CED9D0-0x0000000182CEDA30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182CEE8E0-0x0000000182CEE9D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182CEE6D0-0x0000000182CEE730 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182CEE2B0-0x0000000182CEE3A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182CEE890-0x0000000182CEE8E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182CEE070-0x0000000182CEE160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ScenePlayerInfo> PlayerInfoList { get => default; } // 0x0000000182CEE830-0x0000000182CEE890 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25028
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25029
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 245
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayerInfoNotify() {} // 0x0000000182CEEC30-0x0000000182CEECC0
	static ScenePlayerInfoNotify() {} // 0x0000000182CEEB20-0x0000000182CEEC30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayerInfoNotify Clone() => default; // 0x0000000182CEE3A0-0x0000000182CEE490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayerInfoNotify ShallowCopy() => default; // 0x0000000182CEDFD0-0x0000000182CEE070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182CEDB60-0x0000000182CEDBB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182CEE5B0-0x0000000182CEE640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182CEE640-0x0000000182CEE6D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182CEDBB0-0x0000000182CEDC80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182CEDC80-0x0000000182CEDD50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ScenePlayerInfoNotify other) => default; // 0x0000000182CEDD50-0x0000000182CEDE60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182CEE160-0x0000000182CEE220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182CEE9D0-0x0000000182CEEB20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182CEE730-0x0000000182CEE830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182CEDE60-0x0000000182CEDF50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ScenePlayerInfoNotify other) {} // 0x0000000182CEDA30-0x0000000182CEDB60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182CED8A0-0x0000000182CED9D0
}

