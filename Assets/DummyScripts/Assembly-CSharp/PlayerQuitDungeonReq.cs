/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerQuitDungeonReq : MessageBase, IMessage<PlayerQuitDungeonReq> // TypeDefIndex: 22816
{
	// Fields
	private static readonly MessageParser<PlayerQuitDungeonReq> _parser; // 0x00
	public const int PointIdFieldNumber = 1; // Metadata: 0x00B02717
	private uint pointId_; // 0x18
	public const int IsQuitImmediatelyFieldNumber = 2; // Metadata: 0x00B0271B
	private bool isQuitImmediately_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerQuitDungeonReq> Parser { get => default; } // 0x00000001836CC100-0x00000001836CC190 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001836CBCB0-0x00000001836CBD40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001836CB990-0x00000001836CBA10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001836CB3B0-0x00000001836CB410 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001836CC490-0x00000001836CC580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001836CC2C0-0x00000001836CC320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001836CBE80-0x00000001836CBF70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001836CC440-0x00000001836CC490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001836CBAB0-0x00000001836CBBA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PointId { get => default; set {} } // 0x00000001836CBD40-0x00000001836CBDE0 0x00000001836CB600-0x00000001836CB6A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsQuitImmediately { get => default; set {} } // 0x00000001836CC060-0x00000001836CC100 0x00000001836CBDE0-0x00000001836CBE80

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22817
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22818
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 905
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerQuitDungeonReq() {} // 0x00000001836CC840-0x00000001836CC8A0
	static PlayerQuitDungeonReq() {} // 0x00000001836CC780-0x00000001836CC840

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerQuitDungeonReq Clone() => default; // 0x00000001836CBF70-0x00000001836CC060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerQuitDungeonReq ShallowCopy() => default; // 0x00000001836CBA10-0x00000001836CBAB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001836CB540-0x00000001836CB590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001836CC220-0x00000001836CC270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001836CC270-0x00000001836CC2C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001836CB590-0x00000001836CB600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001836CB7C0-0x00000001836CB890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerQuitDungeonReq other) => default; // 0x00000001836CB6A0-0x00000001836CB7C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001836CBBA0-0x00000001836CBCB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001836CC580-0x00000001836CC780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001836CC320-0x00000001836CC440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001836CB890-0x00000001836CB990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerQuitDungeonReq other) {} // 0x00000001836CB410-0x00000001836CB540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001836CB2B0-0x00000001836CB3B0
}

