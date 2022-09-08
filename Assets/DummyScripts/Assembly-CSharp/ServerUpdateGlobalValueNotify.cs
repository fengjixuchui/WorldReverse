/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ServerUpdateGlobalValueNotify : MessageBase, IMessage<ServerUpdateGlobalValueNotify> // TypeDefIndex: 21818
{
	// Fields
	private static readonly MessageParser<ServerUpdateGlobalValueNotify> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B00103
	private uint entityId_; // 0x18
	public const int KeyHashFieldNumber = 2; // Metadata: 0x00B00107
	private uint keyHash_; // 0x1C
	public const int UpdateTypeFieldNumber = 3; // Metadata: 0x00B0010B
	private Types.UpdateType updateType_; // 0x20
	public const int DeltaFieldNumber = 4; // Metadata: 0x00B0010F
	private float delta_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ServerUpdateGlobalValueNotify> Parser { get => default; } // 0x00000001836DE9A0-0x00000001836DEA30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001836DE5F0-0x00000001836DE680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001836DE210-0x00000001836DE290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001836DD990-0x00000001836DD9F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001836DEE50-0x00000001836DEF40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001836DEC00-0x00000001836DEC60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001836DE7C0-0x00000001836DE8B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001836DEE00-0x00000001836DEE50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001836DE330-0x00000001836DE420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x00000001836DEB60-0x00000001836DEC00 0x00000001836DEF40-0x00000001836DEFE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint KeyHash { get => default; set {} } // 0x00000001836DE680-0x00000001836DE720 0x00000001836DDB80-0x00000001836DDC20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.UpdateType UpdateType { get => default; set {} } // 0x00000001836DEFE0-0x00000001836DF080 0x00000001836DE720-0x00000001836DE7C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float Delta { get => default; set {} } // 0x00000001836DDD00-0x00000001836DDDA0 0x00000001836DDDA0-0x00000001836DDE40

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21819
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21820
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1113
		}

		public enum UpdateType // TypeDefIndex: 21821
		{
			Invalue = 0,
			Add = 1
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ServerUpdateGlobalValueNotify() {} // 0x00000001836DF460-0x00000001836DF4D0
	static ServerUpdateGlobalValueNotify() {} // 0x00000001836DF3A0-0x00000001836DF460

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ServerUpdateGlobalValueNotify Clone() => default; // 0x00000001836DE8B0-0x00000001836DE9A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ServerUpdateGlobalValueNotify ShallowCopy() => default; // 0x00000001836DE290-0x00000001836DE330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001836DDC20-0x00000001836DDC70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001836DEAC0-0x00000001836DEB10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001836DEB10-0x00000001836DEB60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001836DDC70-0x00000001836DDD00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001836DDE40-0x00000001836DDF10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ServerUpdateGlobalValueNotify other) => default; // 0x00000001836DDF10-0x00000001836DE070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001836DE420-0x00000001836DE5F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001836DF080-0x00000001836DF3A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001836DEC60-0x00000001836DEE00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001836DE070-0x00000001836DE210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ServerUpdateGlobalValueNotify other) {} // 0x00000001836DD9F0-0x00000001836DDB80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001836DD870-0x00000001836DD990
}

