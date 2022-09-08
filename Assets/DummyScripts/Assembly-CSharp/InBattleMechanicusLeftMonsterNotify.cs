/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InBattleMechanicusLeftMonsterNotify : MessageBase, IMessage<InBattleMechanicusLeftMonsterNotify> // TypeDefIndex: 24123
{
	// Fields
	private static readonly MessageParser<InBattleMechanicusLeftMonsterNotify> _parser; // 0x00
	public const int LeftMonsterFieldNumber = 1; // Metadata: 0x00B05A47
	private uint leftMonster_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<InBattleMechanicusLeftMonsterNotify> Parser { get => default; } // 0x0000000181312A60-0x0000000181312AF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001813127F0-0x0000000181312880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181312460-0x00000001813124E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181311ED0-0x0000000181311F30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181312DB0-0x0000000181312EA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181312C20-0x0000000181312C80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181312880-0x0000000181312970 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181312D60-0x0000000181312DB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181312620-0x0000000181312710 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint LeftMonster { get => default; set {} } // 0x0000000181312580-0x0000000181312620 0x0000000181312040-0x00000001813120E0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24124
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24125
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5306
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleMechanicusLeftMonsterNotify() {} // 0x00000001813130D0-0x0000000181313130
	static InBattleMechanicusLeftMonsterNotify() {} // 0x0000000181313010-0x00000001813130D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleMechanicusLeftMonsterNotify Clone() => default; // 0x0000000181312970-0x0000000181312A60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleMechanicusLeftMonsterNotify ShallowCopy() => default; // 0x00000001813124E0-0x0000000181312580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001813120E0-0x0000000181312130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181312B80-0x0000000181312BD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181312BD0-0x0000000181312C20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181312130-0x00000001813121A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001813121A0-0x0000000181312270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(InBattleMechanicusLeftMonsterNotify other) => default; // 0x0000000181312270-0x0000000181312370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181312710-0x00000001813127F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181312EA0-0x0000000181313010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181312C80-0x0000000181312D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181312370-0x0000000181312460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(InBattleMechanicusLeftMonsterNotify other) {} // 0x0000000181311F30-0x0000000181312040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181311DF0-0x0000000181311ED0
}

