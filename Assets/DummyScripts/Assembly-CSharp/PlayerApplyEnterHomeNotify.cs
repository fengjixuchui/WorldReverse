/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerApplyEnterHomeNotify : MessageBase, IMessage<PlayerApplyEnterHomeNotify> // TypeDefIndex: 23369
{
	// Fields
	private static readonly MessageParser<PlayerApplyEnterHomeNotify> _parser; // 0x00
	public const int SrcPlayerInfoFieldNumber = 1; // Metadata: 0x00B03DEF
	private OnlinePlayerInfo srcPlayerInfo_; // 0x18
	public const int SrcAppIdFieldNumber = 2; // Metadata: 0x00B03DF3
	private uint srcAppId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerApplyEnterHomeNotify> Parser { get => default; } // 0x0000000183438EA0-0x0000000183438F30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183438B90-0x0000000183438C20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183438800-0x0000000183438880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183438020-0x0000000183438080 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183439330-0x0000000183439420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001834390C0-0x0000000183439120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183438C20-0x0000000183438D10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001834392E0-0x0000000183439330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183438920-0x0000000183438A10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OnlinePlayerInfo SrcPlayerInfo { get => default; set {} } // 0x0000000183439420-0x00000001834394C0 0x0000000183438080-0x0000000183438120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SrcAppId { get => default; set {} } // 0x0000000183438E00-0x0000000183438EA0 0x0000000183439120-0x00000001834391C0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23370
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23371
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4471
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerApplyEnterHomeNotify() {} // 0x0000000183439760-0x00000001834397C0
	static PlayerApplyEnterHomeNotify() {} // 0x00000001834396A0-0x0000000183439760

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerApplyEnterHomeNotify Clone() => default; // 0x0000000183438D10-0x0000000183438E00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerApplyEnterHomeNotify ShallowCopy() => default; // 0x0000000183438880-0x0000000183438920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001834382B0-0x0000000183438330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183438FC0-0x0000000183439040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183439040-0x00000001834390C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183438330-0x0000000183438460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183438590-0x0000000183438660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerApplyEnterHomeNotify other) => default; // 0x0000000183438460-0x0000000183438590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183438A10-0x0000000183438B90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001834394C0-0x00000001834396A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001834391C0-0x00000001834392E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183438660-0x0000000183438800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerApplyEnterHomeNotify other) {} // 0x0000000183438120-0x00000001834382B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183437EF0-0x0000000183438020
}

