/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetPlayerMpModeAvailabilityReq : MessageBase, IMessage<GetPlayerMpModeAvailabilityReq> // TypeDefIndex: 24048
{
	// Fields
	private static readonly MessageParser<GetPlayerMpModeAvailabilityReq> _parser; // 0x00

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetPlayerMpModeAvailabilityReq> Parser { get => default; } // 0x0000000181C119B0-0x0000000181C11A40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181C11740-0x0000000181C117D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181C11490-0x0000000181C11510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181C11070-0x0000000181C110D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181C11CB0-0x0000000181C11DA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181C11B70-0x0000000181C11BD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181C117D0-0x0000000181C118C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181C11C60-0x0000000181C11CB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181C115B0-0x0000000181C116A0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24049
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24050
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 1809
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetPlayerMpModeAvailabilityReq() {} // 0x0000000181C11F30-0x0000000181C11F90
	static GetPlayerMpModeAvailabilityReq() {} // 0x0000000181C11E70-0x0000000181C11F30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetPlayerMpModeAvailabilityReq Clone() => default; // 0x0000000181C118C0-0x0000000181C119B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetPlayerMpModeAvailabilityReq ShallowCopy() => default; // 0x0000000181C11510-0x0000000181C115B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181C111B0-0x0000000181C11200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181C11AD0-0x0000000181C11B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181C11B20-0x0000000181C11B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181C11200-0x0000000181C11250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181C11320-0x0000000181C113F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetPlayerMpModeAvailabilityReq other) => default; // 0x0000000181C11250-0x0000000181C11320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181C116A0-0x0000000181C11740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181C11DA0-0x0000000181C11E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181C11BD0-0x0000000181C11C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181C113F0-0x0000000181C11490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetPlayerMpModeAvailabilityReq other) {} // 0x0000000181C110D0-0x0000000181C111B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181C10FA0-0x0000000181C11070
}

