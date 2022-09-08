/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GadgetPlayUidInfo : MessageBase, IMessage<GadgetPlayUidInfo> // TypeDefIndex: 23203
{
	// Fields
	private static readonly MessageParser<GadgetPlayUidInfo> _parser; // 0x00
	public const int UidFieldNumber = 1; // Metadata: 0x00B03783
	private uint uid_; // 0x18
	public const int ScoreFieldNumber = 2; // Metadata: 0x00B03787
	private uint score_; // 0x1C
	public const int IconFieldNumber = 3; // Metadata: 0x00B0378B
	private uint icon_; // 0x20
	public const int NicknameFieldNumber = 4; // Metadata: 0x00B0378F
	private string nickname_; // 0x28
	public const int OnlineIdFieldNumber = 5; // Metadata: 0x00B03793
	private string onlineId_; // 0x30
	public const int BattleWatcherIdFieldNumber = 6; // Metadata: 0x00B03797
	private uint battleWatcherId_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GadgetPlayUidInfo> Parser { get => default; } // 0x00000001845D7310-0x00000001845D73A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001845D6E10-0x00000001845D6EA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001845D6950-0x00000001845D69D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001845D5CC0-0x00000001845D5D20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001845D77D0-0x00000001845D78C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001845D74D0-0x00000001845D7530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001845D7080-0x00000001845D7170 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001845D7780-0x00000001845D77D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001845D6A70-0x00000001845D6B60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Uid { get => default; set {} } // 0x00000001845D68B0-0x00000001845D6950 0x00000001845D6EA0-0x00000001845D6F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Score { get => default; set {} } // 0x00000001845D6F40-0x00000001845D6FE0 0x00000001845D5DC0-0x00000001845D5E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Icon { get => default; set {} } // 0x00000001845D6150-0x00000001845D61F0 0x00000001845D5D20-0x00000001845D5DC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Nickname { get => default; set {} } // 0x00000001845D6FE0-0x00000001845D7080 0x00000001845D62A0-0x00000001845D6350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string OnlineId { get => default; set {} } // 0x00000001845D6D70-0x00000001845D6E10 0x00000001845D7260-0x00000001845D7310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BattleWatcherId { get => default; set {} } // 0x00000001845D5C20-0x00000001845D5CC0 0x00000001845D5E60-0x00000001845D5F00

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetPlayUidInfo() {} // 0x00000001845D7D80-0x00000001845D7E00
	static GadgetPlayUidInfo() {} // 0x00000001845D7CC0-0x00000001845D7D80

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetPlayUidInfo Clone() => default; // 0x00000001845D7170-0x00000001845D7260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetPlayUidInfo ShallowCopy() => default; // 0x00000001845D69D0-0x00000001845D6A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001845D6100-0x00000001845D6150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001845D7430-0x00000001845D7480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001845D7480-0x00000001845D74D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001845D61F0-0x00000001845D62A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001845D6350-0x00000001845D6420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GadgetPlayUidInfo other) => default; // 0x00000001845D6420-0x00000001845D6620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001845D6B60-0x00000001845D6D70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001845D78C0-0x00000001845D7CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001845D7530-0x00000001845D7780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001845D6620-0x00000001845D68B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GadgetPlayUidInfo other) {} // 0x00000001845D5F00-0x00000001845D6100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001845D5AB0-0x00000001845D5C20
}

