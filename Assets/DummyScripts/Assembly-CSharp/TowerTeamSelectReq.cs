/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TowerTeamSelectReq : MessageBase, IMessage<TowerTeamSelectReq> // TypeDefIndex: 25709
{
	// Fields
	private static readonly MessageParser<TowerTeamSelectReq> _parser; // 0x00
	public const int FloorIdFieldNumber = 1; // Metadata: 0x00B0964F
	private uint floorId_; // 0x18
	public const int TowerTeamListFieldNumber = 2; // Metadata: 0x00B09653
	private static readonly FieldCodec<TowerTeam> _repeated_towerTeamList_codec; // 0x08
	private readonly RepeatedMessageField<TowerTeam> towerTeamList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TowerTeamSelectReq> Parser { get => default; } // 0x000000018173DB70-0x000000018173DC00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018173D900-0x000000018173D990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018173D5F0-0x000000018173D670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018173CF20-0x000000018173CF80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018173E0A0-0x000000018173E190 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018173DE50-0x000000018173DEB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018173D990-0x000000018173DA80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018173E050-0x000000018173E0A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018173D710-0x000000018173D800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FloorId { get => default; set {} } // 0x000000018173DC90-0x000000018173DD30 0x000000018173D210-0x000000018173D2B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<TowerTeam> TowerTeamList { get => default; } // 0x000000018173DFF0-0x000000018173E050 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25710
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25711
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2406
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerTeamSelectReq() {} // 0x000000018173E480-0x000000018173E510
	static TowerTeamSelectReq() {} // 0x000000018173E370-0x000000018173E480

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerTeamSelectReq Clone() => default; // 0x000000018173DA80-0x000000018173DB70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerTeamSelectReq ShallowCopy() => default; // 0x000000018173D670-0x000000018173D710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018173D0E0-0x000000018173D130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018173DD30-0x000000018173DDC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018173DDC0-0x000000018173DE50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018173D130-0x000000018173D210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018173D3E0-0x000000018173D4B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TowerTeamSelectReq other) => default; // 0x000000018173D2B0-0x000000018173D3E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018173D800-0x000000018173D900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018173E190-0x000000018173E370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018173DEB0-0x000000018173DFF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018173D4B0-0x000000018173D5F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TowerTeamSelectReq other) {} // 0x000000018173CF80-0x000000018173D0E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018173CDC0-0x000000018173CF20
}

