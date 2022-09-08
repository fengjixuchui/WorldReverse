/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DragonSpineCoinChangeNotify : MessageBase, IMessage<DragonSpineCoinChangeNotify> // TypeDefIndex: 22056
{
	// Fields
	private static readonly MessageParser<DragonSpineCoinChangeNotify> _parser; // 0x00
	public const int ScheduleIdFieldNumber = 1; // Metadata: 0x00B00ADF
	private uint scheduleId_; // 0x18
	public const int ShimmeringEssenceFieldNumber = 2; // Metadata: 0x00B00AE3
	private uint shimmeringEssence_; // 0x1C
	public const int WarmEssenceFieldNumber = 3; // Metadata: 0x00B00AE7
	private uint warmEssence_; // 0x20
	public const int WondrousEssenceFieldNumber = 4; // Metadata: 0x00B00AEB
	private uint wondrousEssence_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DragonSpineCoinChangeNotify> Parser { get => default; } // 0x00000001831A5B80-0x00000001831A5C10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001831A57D0-0x00000001831A5860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001831A5460-0x00000001831A54E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001831A4A90-0x00000001831A4AF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001831A6030-0x00000001831A6120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001831A5D40-0x00000001831A5DA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001831A5900-0x00000001831A59F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001831A5FE0-0x00000001831A6030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001831A5580-0x00000001831A5670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ScheduleId { get => default; set {} } // 0x00000001831A4DF0-0x00000001831A4E90 0x00000001831A5DA0-0x00000001831A5E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ShimmeringEssence { get => default; set {} } // 0x00000001831A53C0-0x00000001831A5460 0x00000001831A5AE0-0x00000001831A5B80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint WarmEssence { get => default; set {} } // 0x00000001831A4E90-0x00000001831A4F30 0x00000001831A5860-0x00000001831A5900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint WondrousEssence { get => default; set {} } // 0x00000001831A5320-0x00000001831A53C0 0x00000001831A4C70-0x00000001831A4D10

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22057
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22058
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2084
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DragonSpineCoinChangeNotify() {} // 0x00000001831A6500-0x00000001831A6560
	static DragonSpineCoinChangeNotify() {} // 0x00000001831A6440-0x00000001831A6500

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DragonSpineCoinChangeNotify Clone() => default; // 0x00000001831A59F0-0x00000001831A5AE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DragonSpineCoinChangeNotify ShallowCopy() => default; // 0x00000001831A54E0-0x00000001831A5580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001831A4D10-0x00000001831A4D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001831A5CA0-0x00000001831A5CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001831A5CF0-0x00000001831A5D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001831A4D60-0x00000001831A4DF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001831A5080-0x00000001831A5150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DragonSpineCoinChangeNotify other) => default; // 0x00000001831A4F30-0x00000001831A5080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001831A5670-0x00000001831A57D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001831A6120-0x00000001831A6440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001831A5E40-0x00000001831A5FE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001831A5150-0x00000001831A5320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DragonSpineCoinChangeNotify other) {} // 0x00000001831A4AF0-0x00000001831A4C70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001831A4960-0x00000001831A4A90
}

