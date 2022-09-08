/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HomeNpcData : MessageBase, IMessage<HomeNpcData> // TypeDefIndex: 23339
{
	// Fields
	private static readonly MessageParser<HomeNpcData> _parser; // 0x00
	public const int AvatarIdFieldNumber = 1; // Metadata: 0x00B03CC3
	private uint avatarId_; // 0x18
	public const int SpawnPosFieldNumber = 2; // Metadata: 0x00B03CC7
	private Vector spawnPos_; // 0x20
	public const int SpawnRotFieldNumber = 3; // Metadata: 0x00B03CCB
	private Vector spawnRot_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HomeNpcData> Parser { get => default; } // 0x0000000183E36AB0-0x0000000183E36B40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183E367A0-0x0000000183E36830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183E36370-0x0000000183E363F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183E35830-0x0000000183E35890 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183E37030-0x0000000183E37120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183E36CF0-0x0000000183E36D50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183E36830-0x0000000183E36920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183E36FE0-0x0000000183E37030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183E36490-0x0000000183E36580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AvatarId { get => default; set {} } // 0x0000000183E36230-0x0000000183E362D0 0x0000000183E362D0-0x0000000183E36370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector SpawnPos { get => default; set {} } // 0x0000000183E36F40-0x0000000183E36FE0 0x0000000183E36A10-0x0000000183E36AB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector SpawnRot { get => default; set {} } // 0x0000000183E36D50-0x0000000183E36DF0 0x0000000183E35D10-0x0000000183E35DB0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeNpcData() {} // 0x0000000183E37440-0x0000000183E374A0
	static HomeNpcData() {} // 0x0000000183E37380-0x0000000183E37440

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeNpcData Clone() => default; // 0x0000000183E36920-0x0000000183E36A10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeNpcData ShallowCopy() => default; // 0x0000000183E363F0-0x0000000183E36490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183E35A90-0x0000000183E35B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183E36BD0-0x0000000183E36C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183E36C60-0x0000000183E36CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183E35B20-0x0000000183E35D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183E35DB0-0x0000000183E35E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HomeNpcData other) => default; // 0x0000000183E35E80-0x0000000183E35FE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183E36580-0x0000000183E367A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183E37120-0x0000000183E37380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183E36DF0-0x0000000183E36F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183E35FE0-0x0000000183E36230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HomeNpcData other) {} // 0x0000000183E35890-0x0000000183E35A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183E356A0-0x0000000183E35830
}

