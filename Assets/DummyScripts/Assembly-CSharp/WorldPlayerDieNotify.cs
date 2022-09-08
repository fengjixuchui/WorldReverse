/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WorldPlayerDieNotify : MessageBase, IMessage<WorldPlayerDieNotify> // TypeDefIndex: 25160
{
	// Fields
	private static readonly MessageParser<WorldPlayerDieNotify> _parser; // 0x00
	public const int DieTypeFieldNumber = 1; // Metadata: 0x00B081CF
	private PlayerDieType dieType_; // 0x18
	public const int MurdererEntityIdFieldNumber = 2; // Metadata: 0x00B081D3
	private uint murdererEntityId_; // 0x1C
	public const int MonsterIdFieldNumber = 3; // Metadata: 0x00B081D7
	public const int GadgetIdFieldNumber = 4; // Metadata: 0x00B081DB
	private object entity_; // 0x20
	private EntityOneofCase entityCase_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<WorldPlayerDieNotify> Parser { get => default; } // 0x000000018323ECA0-0x000000018323ED30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018323E8F0-0x000000018323E980 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018323E390-0x000000018323E410 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018323D890-0x000000018323D8F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018323F0A0-0x000000018323F190 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018323EE60-0x000000018323EEC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018323E9F0-0x000000018323EAE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018323F050-0x000000018323F0A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018323E4B0-0x000000018323E5A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerDieType DieType { get => default; set {} } // 0x000000018323E7F0-0x000000018323E890 0x000000018323DCE0-0x000000018323DD80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MurdererEntityId { get => default; set {} } // 0x000000018323DD80-0x000000018323DE20 0x000000018323E220-0x000000018323E2C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MonsterId { get => default; set {} } // 0x000000018323EBD0-0x000000018323ECA0 0x000000018323D8F0-0x000000018323D9A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GadgetId { get => default; set {} } // 0x000000018323E2C0-0x000000018323E390 0x000000018323E740-0x000000018323E7F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityOneofCase EntityCase { get => default; } // 0x000000018323E890-0x000000018323E8F0 

	// Nested types
	public enum EntityOneofCase // TypeDefIndex: 25161
	{
		None = 0,
		MonsterId = 3,
		GadgetId = 4
	}

	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25162
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25163
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 287
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorldPlayerDieNotify() {} // 0x000000018323F5A0-0x000000018323F610
	static WorldPlayerDieNotify() {} // 0x000000018323F4E0-0x000000018323F5A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorldPlayerDieNotify Clone() => default; // 0x000000018323EAE0-0x000000018323EBD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorldPlayerDieNotify ShallowCopy() => default; // 0x000000018323E410-0x000000018323E4B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018323DBC0-0x000000018323DC10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018323EDC0-0x000000018323EE10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018323EE10-0x000000018323EE60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018323DC10-0x000000018323DCE0
	public void resetEntity() {} // 0x000000018323E980-0x000000018323E9F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void ClearEntity() {} // 0x000000018323D9A0-0x000000018323DA00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018323DF90-0x000000018323E060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(WorldPlayerDieNotify other) => default; // 0x000000018323DE20-0x000000018323DF90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018323E5A0-0x000000018323E740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018323F190-0x000000018323F4E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018323EEC0-0x000000018323F050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018323E060-0x000000018323E220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(WorldPlayerDieNotify other) {} // 0x000000018323DA00-0x000000018323DBC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018323D770-0x000000018323D890
}

