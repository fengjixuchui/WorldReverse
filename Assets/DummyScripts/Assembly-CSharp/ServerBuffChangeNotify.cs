/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ServerBuffChangeNotify : MessageBase, IMessage<ServerBuffChangeNotify> // TypeDefIndex: 23130
{
	// Fields
	private static readonly MessageParser<ServerBuffChangeNotify> _parser; // 0x00
	public const int ServerBuffChangeTypeFieldNumber = 1; // Metadata: 0x00B0341B
	private Types.ServerBuffChangeType serverBuffChangeType_; // 0x18
	public const int AvatarGuidListFieldNumber = 2; // Metadata: 0x00B0341F
	private static readonly FieldCodec<ulong> _repeated_avatarGuidList_codec; // 0x08
	private readonly RepeatedPrimitiveField<ulong> avatarGuidList_; // 0x20
	public const int ServerBuffListFieldNumber = 3; // Metadata: 0x00B03423
	private static readonly FieldCodec<ServerBuff> _repeated_serverBuffList_codec; // 0x10
	private readonly RepeatedMessageField<ServerBuff> serverBuffList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ServerBuffChangeNotify> Parser { get => default; } // 0x00000001846D9F20-0x00000001846D9FB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001846D9C50-0x00000001846D9CE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001846D9840-0x00000001846D98C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001846D9090-0x00000001846D90F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001846DA380-0x00000001846DA470 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001846DA160-0x00000001846DA1C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001846D9CE0-0x00000001846D9DD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001846DA330-0x00000001846DA380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001846D9960-0x00000001846D9A50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.ServerBuffChangeType ServerBuffChangeType { get => default; set {} } // 0x00000001846D9620-0x00000001846D96C0 0x00000001846D9BB0-0x00000001846D9C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<ulong> AvatarGuidList { get => default; } // 0x00000001846D9EC0-0x00000001846D9F20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ServerBuff> ServerBuffList { get => default; } // 0x00000001846DA470-0x00000001846DA4D0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23131
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23132
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 351
		}

		public enum ServerBuffChangeType // TypeDefIndex: 23133
		{
			AddServerBuff = 0,
			DelServerBuff = 1
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ServerBuffChangeNotify() {} // 0x00000001846DA860-0x00000001846DA920
	static ServerBuffChangeNotify() {} // 0x00000001846DA730-0x00000001846DA860

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ServerBuffChangeNotify Clone() => default; // 0x00000001846D9DD0-0x00000001846D9EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ServerBuffChangeNotify ShallowCopy() => default; // 0x00000001846D98C0-0x00000001846D9960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001846D9270-0x00000001846D92C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001846DA040-0x00000001846DA0D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001846DA0D0-0x00000001846DA160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001846D92C0-0x00000001846D9400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001846D9550-0x00000001846D9620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ServerBuffChangeNotify other) => default; // 0x00000001846D9400-0x00000001846D9550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001846D9A50-0x00000001846D9BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001846DA4D0-0x00000001846DA730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001846DA1C0-0x00000001846DA330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001846D96C0-0x00000001846D9840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ServerBuffChangeNotify other) {} // 0x00000001846D90F0-0x00000001846D9270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001846D8EC0-0x00000001846D9090
}

