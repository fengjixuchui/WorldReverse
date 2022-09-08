/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TowerGetFloorStarRewardReq : MessageBase, IMessage<TowerGetFloorStarRewardReq> // TypeDefIndex: 25740
{
	// Fields
	private static readonly MessageParser<TowerGetFloorStarRewardReq> _parser; // 0x00
	public const int FloorIdFieldNumber = 1; // Metadata: 0x00B0978B
	private uint floorId_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TowerGetFloorStarRewardReq> Parser { get => default; } // 0x00000001847DB670-0x00000001847DB700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001847DB400-0x00000001847DB490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001847DB110-0x00000001847DB190 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001847DAB80-0x00000001847DABE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001847DBA60-0x00000001847DBB50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001847DB8D0-0x00000001847DB930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001847DB490-0x00000001847DB580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001847DBA10-0x00000001847DBA60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001847DB230-0x00000001847DB320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FloorId { get => default; set {} } // 0x00000001847DB790-0x00000001847DB830 0x00000001847DADB0-0x00000001847DAE50

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25741
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25742
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2423
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerGetFloorStarRewardReq() {} // 0x00000001847DBD80-0x00000001847DBDE0
	static TowerGetFloorStarRewardReq() {} // 0x00000001847DBCC0-0x00000001847DBD80

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerGetFloorStarRewardReq Clone() => default; // 0x00000001847DB580-0x00000001847DB670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerGetFloorStarRewardReq ShallowCopy() => default; // 0x00000001847DB190-0x00000001847DB230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001847DACF0-0x00000001847DAD40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001847DB830-0x00000001847DB880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001847DB880-0x00000001847DB8D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001847DAD40-0x00000001847DADB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001847DAF50-0x00000001847DB020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TowerGetFloorStarRewardReq other) => default; // 0x00000001847DAE50-0x00000001847DAF50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001847DB320-0x00000001847DB400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001847DBB50-0x00000001847DBCC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001847DB930-0x00000001847DBA10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001847DB020-0x00000001847DB110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TowerGetFloorStarRewardReq other) {} // 0x00000001847DABE0-0x00000001847DACF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001847DAAA0-0x00000001847DAB80
}

