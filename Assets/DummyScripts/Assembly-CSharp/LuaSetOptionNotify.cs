/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LuaSetOptionNotify : MessageBase, IMessage<LuaSetOptionNotify> // TypeDefIndex: 23146
{
	// Fields
	private static readonly MessageParser<LuaSetOptionNotify> _parser; // 0x00
	public const int OptionTypeFieldNumber = 1; // Metadata: 0x00B034C3
	private Types.LuaOptionType optionType_; // 0x18
	public const int LuaSetParamFieldNumber = 2; // Metadata: 0x00B034C7
	private string luaSetParam_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<LuaSetOptionNotify> Parser { get => default; } // 0x0000000183D1CC10-0x0000000183D1CCA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183D1C900-0x0000000183D1C990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183D1C580-0x0000000183D1C600 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183D1BE50-0x0000000183D1BEB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183D1D070-0x0000000183D1D160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183D1CDD0-0x0000000183D1CE30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183D1CA30-0x0000000183D1CB20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183D1D020-0x0000000183D1D070 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183D1C6A0-0x0000000183D1C790 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.LuaOptionType OptionType { get => default; set {} } // 0x0000000183D1C990-0x0000000183D1CA30 0x0000000183D1C4E0-0x0000000183D1C580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string LuaSetParam { get => default; set {} } // 0x0000000183D1BEB0-0x0000000183D1BF50 0x0000000183D1CE30-0x0000000183D1CEE0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23147
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23148
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 355
		}

		public enum LuaOptionType // TypeDefIndex: 23149
		{
			LuaOptionNone = 0,
			LuaOptionPlayerInput = 1
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public LuaSetOptionNotify() {} // 0x0000000183D1D400-0x0000000183D1D480
	static LuaSetOptionNotify() {} // 0x0000000183D1D340-0x0000000183D1D400

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public LuaSetOptionNotify Clone() => default; // 0x0000000183D1CB20-0x0000000183D1CC10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public LuaSetOptionNotify ShallowCopy() => default; // 0x0000000183D1C600-0x0000000183D1C6A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183D1C0A0-0x0000000183D1C0F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183D1CD30-0x0000000183D1CD80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183D1CD80-0x0000000183D1CDD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183D1C0F0-0x0000000183D1C170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183D1C2C0-0x0000000183D1C390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(LuaSetOptionNotify other) => default; // 0x0000000183D1C170-0x0000000183D1C2C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183D1C790-0x0000000183D1C900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183D1D160-0x0000000183D1D340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183D1CEE0-0x0000000183D1D020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183D1C390-0x0000000183D1C4E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(LuaSetOptionNotify other) {} // 0x0000000183D1BF50-0x0000000183D1C0A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183D1BD60-0x0000000183D1BE50
}

