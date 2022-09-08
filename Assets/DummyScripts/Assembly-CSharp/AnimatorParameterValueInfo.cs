/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AnimatorParameterValueInfo : MessageBase, IMessage<AnimatorParameterValueInfo> // TypeDefIndex: 26043
{
	// Fields
	private static readonly MessageParser<AnimatorParameterValueInfo> _parser; // 0x00
	public const int ParaTypeFieldNumber = 1; // Metadata: 0x00B0ADD3
	private uint paraType_; // 0x18
	public const int IntValFieldNumber = 2; // Metadata: 0x00B0ADD7
	public const int FloatValFieldNumber = 3; // Metadata: 0x00B0ADDB
	public const int BoolValFieldNumber = 4; // Metadata: 0x00B0ADDF
	private object paraVal_; // 0x20
	private ParaValOneofCase paraValCase_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AnimatorParameterValueInfo> Parser { get => default; } // 0x0000000181F91D10-0x0000000181F91DA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181F917D0-0x0000000181F91860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181F91350-0x0000000181F913D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181F90980-0x0000000181F909E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181F92110-0x0000000181F92200 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181F91ED0-0x0000000181F91F30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181F91900-0x0000000181F919F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181F920C0-0x0000000181F92110 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181F91470-0x0000000181F91560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ParaType { get => default; set {} } // 0x0000000181F91860-0x0000000181F91900 0x0000000181F91C70-0x0000000181F91D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int IntVal { get => default; set {} } // 0x0000000181F91BA0-0x0000000181F91C70 0x0000000181F90AC0-0x0000000181F90B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float FloatVal { get => default; set {} } // 0x0000000181F90D30-0x0000000181F90E10 0x0000000181F91AE0-0x0000000181F91BA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool BoolVal { get => default; set {} } // 0x0000000181F909E0-0x0000000181F90AC0 0x0000000181F91710-0x0000000181F917D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ParaValOneofCase ParaValCase { get => default; } // 0x0000000181F912F0-0x0000000181F91350 

	// Nested types
	public enum ParaValOneofCase // TypeDefIndex: 26044
	{
		None = 0,
		IntVal = 2,
		FloatVal = 3,
		BoolVal = 4
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AnimatorParameterValueInfo() {} // 0x0000000181F92600-0x0000000181F92670
	static AnimatorParameterValueInfo() {} // 0x0000000181F92540-0x0000000181F92600

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AnimatorParameterValueInfo Clone() => default; // 0x0000000181F919F0-0x0000000181F91AE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AnimatorParameterValueInfo ShallowCopy() => default; // 0x0000000181F913D0-0x0000000181F91470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181F90E10-0x0000000181F90E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181F91E30-0x0000000181F91E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181F91E80-0x0000000181F91ED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181F90E60-0x0000000181F90ED0
	public void resetParaVal() {} // 0x0000000181F90ED0-0x0000000181F90F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void ClearParaVal() {} // 0x0000000181F916B0-0x0000000181F91710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181F90F50-0x0000000181F91020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AnimatorParameterValueInfo other) => default; // 0x0000000181F91020-0x0000000181F911A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181F91560-0x0000000181F916B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181F92200-0x0000000181F92540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181F91F30-0x0000000181F920C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181F911A0-0x0000000181F912F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AnimatorParameterValueInfo other) {} // 0x0000000181F90B70-0x0000000181F90D30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181F90830-0x0000000181F90980
}

