/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerCompoundMaterialRsp : MessageBase, IMessage<PlayerCompoundMaterialRsp> // TypeDefIndex: 24401
{
	// Fields
	private static readonly MessageParser<PlayerCompoundMaterialRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B065B7
	private int retcode_; // 0x18
	public const int CompoundQueDataFieldNumber = 2; // Metadata: 0x00B065BB
	private CompoundQueueData compoundQueData_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerCompoundMaterialRsp> Parser { get => default; } // 0x00000001823FFE70-0x00000001823FFF00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001823FFB60-0x00000001823FFBF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001823FF7D0-0x00000001823FF850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001823FEF60-0x00000001823FEFC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182400260-0x0000000182400350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182400090-0x00000001824000F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001823FFC90-0x00000001823FFD80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182400210-0x0000000182400260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001823FF8F0-0x00000001823FF9E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001823FF730-0x00000001823FF7D0 0x00000001823FF2F0-0x00000001823FF390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CompoundQueueData CompoundQueData { get => default; set {} } // 0x00000001823FFBF0-0x00000001823FFC90 0x0000000182400350-0x00000001824003F0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24402
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24403
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 134
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerCompoundMaterialRsp() {} // 0x0000000182400690-0x00000001824006F0
	static PlayerCompoundMaterialRsp() {} // 0x00000001824005D0-0x0000000182400690

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerCompoundMaterialRsp Clone() => default; // 0x00000001823FFD80-0x00000001823FFE70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerCompoundMaterialRsp ShallowCopy() => default; // 0x00000001823FF850-0x00000001823FF8F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001823FF140-0x00000001823FF1C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001823FFF90-0x0000000182400010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182400010-0x0000000182400090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001823FF1C0-0x00000001823FF2F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001823FF4C0-0x00000001823FF590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerCompoundMaterialRsp other) => default; // 0x00000001823FF390-0x00000001823FF4C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001823FF9E0-0x00000001823FFB60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001824003F0-0x00000001824005D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001824000F0-0x0000000182400210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001823FF590-0x00000001823FF730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerCompoundMaterialRsp other) {} // 0x00000001823FEFC0-0x00000001823FF140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001823FEE20-0x00000001823FEF60
}

