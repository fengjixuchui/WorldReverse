/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ServerAnnounceRevokeNotify : MessageBase, IMessage<ServerAnnounceRevokeNotify> // TypeDefIndex: 21935
{
	// Fields
	private static readonly MessageParser<ServerAnnounceRevokeNotify> _parser; // 0x00
	public const int ConfigIdListFieldNumber = 1; // Metadata: 0x00B0063B
	private static readonly FieldCodec<uint> _repeated_configIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> configIdList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ServerAnnounceRevokeNotify> Parser { get => default; } // 0x0000000182A66180-0x0000000182A66210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182A65F10-0x0000000182A65FA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182A65C40-0x0000000182A65CC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182A65700-0x0000000182A65760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182A66550-0x0000000182A66640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182A663A0-0x0000000182A66400 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182A65FA0-0x0000000182A66090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182A66500-0x0000000182A66550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182A65D60-0x0000000182A65E50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ConfigIdList { get => default; } // 0x0000000182A66340-0x0000000182A663A0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21936
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21937
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2023
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ServerAnnounceRevokeNotify() {} // 0x0000000182A66870-0x0000000182A66900
	static ServerAnnounceRevokeNotify() {} // 0x0000000182A66790-0x0000000182A66870

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ServerAnnounceRevokeNotify Clone() => default; // 0x0000000182A66090-0x0000000182A66180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ServerAnnounceRevokeNotify ShallowCopy() => default; // 0x0000000182A65CC0-0x0000000182A65D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182A65870-0x0000000182A658C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182A662A0-0x0000000182A662F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182A662F0-0x0000000182A66340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182A658C0-0x0000000182A65980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182A65A80-0x0000000182A65B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ServerAnnounceRevokeNotify other) => default; // 0x0000000182A65980-0x0000000182A65A80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182A65E50-0x0000000182A65F10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182A66640-0x0000000182A66790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182A66400-0x0000000182A66500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182A65B50-0x0000000182A65C40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ServerAnnounceRevokeNotify other) {} // 0x0000000182A65760-0x0000000182A65870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182A655C0-0x0000000182A65700
}

