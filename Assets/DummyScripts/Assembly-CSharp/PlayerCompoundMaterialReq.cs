/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerCompoundMaterialReq : MessageBase, IMessage<PlayerCompoundMaterialReq> // TypeDefIndex: 24397
{
	// Fields
	private static readonly MessageParser<PlayerCompoundMaterialReq> _parser; // 0x00
	public const int CompoundIdFieldNumber = 1; // Metadata: 0x00B0658B
	private uint compoundId_; // 0x18
	public const int CountFieldNumber = 2; // Metadata: 0x00B0658F
	private uint count_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerCompoundMaterialReq> Parser { get => default; } // 0x000000018186FA50-0x000000018186FAE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018186F7E0-0x000000018186F870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018186F4D0-0x000000018186F550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018186EF60-0x000000018186EFC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018186FF20-0x0000000181870010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018186FD50-0x000000018186FDB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018186F870-0x000000018186F960 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018186FED0-0x000000018186FF20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018186F5F0-0x000000018186F6E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CompoundId { get => default; set {} } // 0x000000018186FCB0-0x000000018186FD50 0x0000000181870010-0x00000001818700B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Count { get => default; set {} } // 0x000000018186FB70-0x000000018186FC10 0x000000018186EEC0-0x000000018186EF60

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24398
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24399
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 133
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerCompoundMaterialReq() {} // 0x0000000181870370-0x00000001818703D0
	static PlayerCompoundMaterialReq() {} // 0x00000001818702B0-0x0000000181870370

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerCompoundMaterialReq Clone() => default; // 0x000000018186F960-0x000000018186FA50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerCompoundMaterialReq ShallowCopy() => default; // 0x000000018186F550-0x000000018186F5F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018186F0F0-0x000000018186F140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018186FC10-0x000000018186FC60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018186FC60-0x000000018186FCB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018186F140-0x000000018186F1B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018186F1B0-0x000000018186F280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerCompoundMaterialReq other) => default; // 0x000000018186F280-0x000000018186F3A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018186F6E0-0x000000018186F7E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001818700B0-0x00000001818702B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018186FDB0-0x000000018186FED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018186F3A0-0x000000018186F4D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerCompoundMaterialReq other) {} // 0x000000018186EFC0-0x000000018186F0F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018186EDC0-0x000000018186EEC0
}

