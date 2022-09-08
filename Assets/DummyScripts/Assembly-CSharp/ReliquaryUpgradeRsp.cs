/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ReliquaryUpgradeRsp : MessageBase, IMessage<ReliquaryUpgradeRsp> // TypeDefIndex: 23666
{
	// Fields
	private static readonly MessageParser<ReliquaryUpgradeRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B048C3
	private int retcode_; // 0x18
	public const int TargetReliquaryGuidFieldNumber = 2; // Metadata: 0x00B048C7
	private ulong targetReliquaryGuid_; // 0x20
	public const int OldLevelFieldNumber = 3; // Metadata: 0x00B048CB
	private uint oldLevel_; // 0x28
	public const int CurLevelFieldNumber = 4; // Metadata: 0x00B048CF
	private uint curLevel_; // 0x2C
	public const int PowerUpRateFieldNumber = 5; // Metadata: 0x00B048D3
	private uint powerUpRate_; // 0x30
	public const int OldAppendPropListFieldNumber = 6; // Metadata: 0x00B048D7
	private static readonly FieldCodec<uint> _repeated_oldAppendPropList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> oldAppendPropList_; // 0x38
	public const int CurAppendPropListFieldNumber = 7; // Metadata: 0x00B048DB
	private static readonly FieldCodec<uint> _repeated_curAppendPropList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> curAppendPropList_; // 0x40

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ReliquaryUpgradeRsp> Parser { get => default; } // 0x0000000183E4FB50-0x0000000183E4FBE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183E4F7A0-0x0000000183E4F830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183E4F3A0-0x0000000183E4F420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183E4E820-0x0000000183E4E880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183E50170-0x0000000183E50260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183E4FD10-0x0000000183E4FD70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183E4F830-0x0000000183E4F920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183E50120-0x0000000183E50170 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183E4F4C0-0x0000000183E4F5B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000183E4F300-0x0000000183E4F3A0 0x0000000183E4EC80-0x0000000183E4ED20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong TargetReliquaryGuid { get => default; set {} } // 0x0000000183E50300-0x0000000183E503A0 0x0000000183E4FD70-0x0000000183E4FE10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint OldLevel { get => default; set {} } // 0x0000000183E4FAB0-0x0000000183E4FB50 0x0000000183E4FA10-0x0000000183E4FAB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurLevel { get => default; set {} } // 0x0000000183E4E780-0x0000000183E4E820 0x0000000183E4FE10-0x0000000183E4FEB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PowerUpRate { get => default; set {} } // 0x0000000183E50260-0x0000000183E50300 0x0000000183E4ED20-0x0000000183E4EDC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> OldAppendPropList { get => default; } // 0x0000000183E4EA70-0x0000000183E4EAD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> CurAppendPropList { get => default; } // 0x0000000183E4E720-0x0000000183E4E780 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23667
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23668
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 624
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReliquaryUpgradeRsp() {} // 0x0000000183E50930-0x0000000183E509E0
	static ReliquaryUpgradeRsp() {} // 0x0000000183E50830-0x0000000183E50930

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReliquaryUpgradeRsp Clone() => default; // 0x0000000183E4F920-0x0000000183E4FA10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReliquaryUpgradeRsp ShallowCopy() => default; // 0x0000000183E4F420-0x0000000183E4F4C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183E4EAD0-0x0000000183E4EB20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183E4FC70-0x0000000183E4FCC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183E4FCC0-0x0000000183E4FD10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183E4EB20-0x0000000183E4EC80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183E4EDC0-0x0000000183E4EE90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ReliquaryUpgradeRsp other) => default; // 0x0000000183E4EE90-0x0000000183E4F060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183E4F5B0-0x0000000183E4F7A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183E503A0-0x0000000183E50830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183E4FEB0-0x0000000183E50120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183E4F060-0x0000000183E4F300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ReliquaryUpgradeRsp other) {} // 0x0000000183E4E880-0x0000000183E4EA70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183E4E4C0-0x0000000183E4E720
}

