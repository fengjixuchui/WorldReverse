/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InBattleMechanicusBuildingPointsNotify : MessageBase, IMessage<InBattleMechanicusBuildingPointsNotify> // TypeDefIndex: 24126
{
	// Fields
	private static readonly MessageParser<InBattleMechanicusBuildingPointsNotify> _parser; // 0x00
	public const int PlayerBuildingPointsMapFieldNumber = 1; // Metadata: 0x00B05A5B
	private static readonly MapField<uint, uint> _map_playerBuildingPointsMap_codec; // 0x08
	private readonly MapField<uint, uint> playerBuildingPointsMap_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<InBattleMechanicusBuildingPointsNotify> Parser { get => default; } // 0x0000000181368D90-0x0000000181368E20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181368B20-0x0000000181368BB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181368820-0x00000001813688A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181368210-0x0000000181368270 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181369100-0x00000001813691F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181368F50-0x0000000181368FB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181368BB0-0x0000000181368CA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001813690B0-0x0000000181369100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181368940-0x0000000181368A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> PlayerBuildingPointsMap { get => default; } // 0x0000000181368480-0x00000001813684E0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24127
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24128
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5307
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleMechanicusBuildingPointsNotify() {} // 0x0000000181369470-0x0000000181369500
	static InBattleMechanicusBuildingPointsNotify() {} // 0x0000000181369340-0x0000000181369470

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleMechanicusBuildingPointsNotify Clone() => default; // 0x0000000181368CA0-0x0000000181368D90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleMechanicusBuildingPointsNotify ShallowCopy() => default; // 0x00000001813688A0-0x0000000181368940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181368380-0x00000001813683D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181368EB0-0x0000000181368F00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181368F00-0x0000000181368F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001813683D0-0x0000000181368480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001813684E0-0x00000001813685B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(InBattleMechanicusBuildingPointsNotify other) => default; // 0x00000001813685B0-0x0000000181368730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181368A30-0x0000000181368B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001813691F0-0x0000000181369340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181368FB0-0x00000001813690B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181368730-0x0000000181368820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(InBattleMechanicusBuildingPointsNotify other) {} // 0x0000000181368270-0x0000000181368380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001813680E0-0x0000000181368210
}

