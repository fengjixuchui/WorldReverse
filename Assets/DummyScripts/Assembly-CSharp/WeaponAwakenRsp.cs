/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WeaponAwakenRsp : MessageBase, IMessage<WeaponAwakenRsp> // TypeDefIndex: 23687
{
	// Fields
	private static readonly MessageParser<WeaponAwakenRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0499B
	private int retcode_; // 0x18
	public const int TargetWeaponGuidFieldNumber = 2; // Metadata: 0x00B0499F
	private ulong targetWeaponGuid_; // 0x20
	public const int TargetWeaponAwakenLevelFieldNumber = 3; // Metadata: 0x00B049A3
	private uint targetWeaponAwakenLevel_; // 0x28
	public const int OldAffixLevelMapFieldNumber = 4; // Metadata: 0x00B049A7
	private static readonly MapField<uint, uint> _map_oldAffixLevelMap_codec; // 0x08
	private readonly MapField<uint, uint> oldAffixLevelMap_; // 0x30
	public const int CurAffixLevelMapFieldNumber = 5; // Metadata: 0x00B049AB
	private static readonly MapField<uint, uint> _map_curAffixLevelMap_codec; // 0x10
	private readonly MapField<uint, uint> curAffixLevelMap_; // 0x38
	public const int AvatarGuidFieldNumber = 6; // Metadata: 0x00B049AF
	private ulong avatarGuid_; // 0x40

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<WeaponAwakenRsp> Parser { get => default; } // 0x0000000185416430-0x00000001854164C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000185416120-0x00000001854161B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000185415CE0-0x0000000185415D60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000185415050-0x00000001854150B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000185416A30-0x0000000185416B20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001854166F0-0x0000000185416750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000185416250-0x0000000185416340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001854169E0-0x0000000185416A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000185415E00-0x0000000185415EF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000185415C40-0x0000000185415CE0 0x0000000185415550-0x00000001854155F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong TargetWeaponGuid { get => default; set {} } // 0x00000001854165B0-0x0000000185416650 0x00000001854155F0-0x0000000185415690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TargetWeaponAwakenLevel { get => default; set {} } // 0x00000001854150B0-0x0000000185415150 0x0000000185415940-0x00000001854159E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> OldAffixLevelMap { get => default; } // 0x0000000185416750-0x00000001854167B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> CurAffixLevelMap { get => default; } // 0x0000000185416550-0x00000001854165B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong AvatarGuid { get => default; set {} } // 0x00000001854161B0-0x0000000185416250 0x0000000185415320-0x00000001854153C0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23688
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23689
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 631
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WeaponAwakenRsp() {} // 0x00000001854170B0-0x0000000185417160
	static WeaponAwakenRsp() {} // 0x0000000185416F20-0x00000001854170B0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WeaponAwakenRsp Clone() => default; // 0x0000000185416340-0x0000000185416430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WeaponAwakenRsp ShallowCopy() => default; // 0x0000000185415D60-0x0000000185415E00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001854153C0-0x0000000185415410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185416650-0x00000001854166A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001854166A0-0x00000001854166F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000185415410-0x0000000185415550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000185415870-0x0000000185415940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(WeaponAwakenRsp other) => default; // 0x0000000185415690-0x0000000185415870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000185415EF0-0x0000000185416120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000185416B20-0x0000000185416F20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001854167B0-0x00000001854169E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001854159E0-0x0000000185415C40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(WeaponAwakenRsp other) {} // 0x0000000185415150-0x0000000185415320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000185414E30-0x0000000185415050
}

