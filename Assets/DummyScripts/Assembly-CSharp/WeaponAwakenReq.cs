/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WeaponAwakenReq : MessageBase, IMessage<WeaponAwakenReq> // TypeDefIndex: 23684
{
	// Fields
	private static readonly MessageParser<WeaponAwakenReq> _parser; // 0x00
	public const int TargetWeaponGuidFieldNumber = 1; // Metadata: 0x00B0497B
	private ulong targetWeaponGuid_; // 0x18
	public const int ItemGuidFieldNumber = 2; // Metadata: 0x00B0497F
	private ulong itemGuid_; // 0x20
	public const int AffixLevelMapFieldNumber = 3; // Metadata: 0x00B04983
	private static readonly MapField<uint, uint> _map_affixLevelMap_codec; // 0x08
	private readonly MapField<uint, uint> affixLevelMap_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<WeaponAwakenReq> Parser { get => default; } // 0x00000001821FC580-0x00000001821FC610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001821FC310-0x00000001821FC3A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001821FBF90-0x00000001821FC010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001821FB700-0x00000001821FB760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001821FCA70-0x00000001821FCB60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001821FC840-0x00000001821FC8A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001821FC3A0-0x00000001821FC490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001821FCA20-0x00000001821FCA70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001821FC0B0-0x00000001821FC1A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong TargetWeaponGuid { get => default; set {} } // 0x00000001821FC6A0-0x00000001821FC740 0x00000001821FBB20-0x00000001821FBBC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong ItemGuid { get => default; set {} } // 0x00000001821FB910-0x00000001821FB9B0 0x00000001821FB9B0-0x00000001821FBA50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> AffixLevelMap { get => default; } // 0x00000001821FC7E0-0x00000001821FC840 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23685
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23686
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 630
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WeaponAwakenReq() {} // 0x00000001821FCF00-0x00000001821FCF90
	static WeaponAwakenReq() {} // 0x00000001821FCDD0-0x00000001821FCF00

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WeaponAwakenReq Clone() => default; // 0x00000001821FC490-0x00000001821FC580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WeaponAwakenReq ShallowCopy() => default; // 0x00000001821FC010-0x00000001821FC0B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001821FB8C0-0x00000001821FB910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001821FC740-0x00000001821FC790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001821FC790-0x00000001821FC7E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001821FBA50-0x00000001821FBB20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001821FBBC0-0x00000001821FBC90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(WeaponAwakenReq other) => default; // 0x00000001821FBC90-0x00000001821FBDF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001821FC1A0-0x00000001821FC310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001821FCB60-0x00000001821FCDD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001821FC8A0-0x00000001821FCA20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001821FBDF0-0x00000001821FBF90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(WeaponAwakenReq other) {} // 0x00000001821FB760-0x00000001821FB8C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001821FB580-0x00000001821FB700
}

