/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MessageDescriptor : DescriptorBase // TypeDefIndex: 26413
{
	// Fields
	private static readonly HashSet<string> WellKnownTypeNames; // 0x00
	private readonly IList<FieldDescriptor> fieldsInDeclarationOrder; // 0x28
	private readonly IList<FieldDescriptor> fieldsInNumberOrder; // 0x30
	private readonly IDictionary<string, FieldDescriptor> jsonFieldMap; // 0x38
	internal readonly DescriptorProto Proto; // 0x40
	public readonly System.Type ClrType; // 0x48
	public readonly MessageParser Parser; // 0x50
	public readonly MessageDescriptor ContainingType; // 0x58
	public readonly FieldCollection Fields; // 0x60
	public readonly IList<MessageDescriptor> NestedTypes; // 0x68
	public readonly IList<EnumDescriptor> EnumTypes; // 0x70
	public readonly IList<OneofDescriptor> Oneofs; // 0x78

	// Properties
	public override string Name { /* [XID] */ /* 0x0000000189BC88D0-0x0000000189BC88F0 */ get => default; } // 0x0000000181F007E0-0x0000000181F00890 
	internal bool IsWellKnownType { /* [XID] */ /* 0x0000000189BD00F0-0x0000000189BD0110 */ get => default; } // 0x0000000181F00890-0x0000000181F00A10 
	internal bool IsWrapperType { /* [XID] */ /* 0x0000000189BD7730-0x0000000189BD7750 */ get => default; } // 0x0000000181F00590-0x0000000181F00700 
	public CustomOptions CustomOptions { /* [XID] */ /* 0x00000001895F3280-0x00000001895F32A0 */ get => default; } // 0x0000000181F00470-0x0000000181F00590 

	// Nested types
	public sealed class FieldCollection // TypeDefIndex: 26414
	{
		// Fields
		private readonly MessageDescriptor messageDescriptor; // 0x10

		// Properties
		public FieldDescriptor this[int number] { /* [XID] */ /* 0x00000001896277F0-0x0000000189627830 */ /* [IDTag] */ /* 0x00000001896277F0-0x0000000189627830 */ get => default; } // 0x0000000181EFFBE0-0x0000000181EFFCF0 
		public FieldDescriptor this[string name] { /* [IDTag] */ /* 0x0000000189632010-0x0000000189632050 */ /* [XID] */ /* 0x0000000189632010-0x0000000189632050 */ get => default; } // 0x0000000181EFFAD0-0x0000000181EFFBE0 

		// Constructors
		public FieldCollection() {} // Dummy constructor
		internal FieldCollection(MessageDescriptor messageDescriptor) {} // 0x0000000181EFFCF0-0x0000000181EFFD60

		// Methods
		// [XID] // 0x0000000189611520-0x0000000189611540
		public IList<FieldDescriptor> InDeclarationOrder() => default; // 0x0000000181EFFA20-0x0000000181EFFAD0
		// [XID] // 0x0000000189618E90-0x0000000189618EB0
		public IList<FieldDescriptor> InFieldNumberOrder() => default; // 0x0000000181EFF8C0-0x0000000181EFF970
		// [XID] // 0x0000000189620390-0x00000001896203B0
		internal IDictionary<string, FieldDescriptor> ByJsonName() => default; // 0x0000000181EFF970-0x0000000181EFFA20
	}

	// Constructors
	public MessageDescriptor() {} // Dummy constructor
	internal MessageDescriptor(DescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int typeIndex, GeneratedClrTypeInfo generatedCodeInfo) {} // 0x0000000181F015B0-0x0000000181F01A30
	static MessageDescriptor() {} // 0x0000000181F01440-0x0000000181F015B0

	// Methods
	// [XID] // 0x0000000189BC1100-0x0000000189BC1120
	private static ReadOnlyDictionary<string, FieldDescriptor> CreateJsonFieldMap(IList<FieldDescriptor> fields) => default; // 0x0000000181F01140-0x0000000181F013D0
	// [XID] // 0x0000000189BDF230-0x0000000189BDF250
	public FieldDescriptor FindFieldByName(string name) => default; // 0x0000000181F00A10-0x0000000181F00B50
	// [XID] // 0x00000001895EBE80-0x00000001895EBEA0
	public FieldDescriptor FindFieldByNumber(int number) => default; // 0x0000000181F00700-0x0000000181F007E0
	public T FindDescriptor<T>(string name)
		where T : class, IDescriptor => default;
	// [XID] // 0x00000001895FAB50-0x00000001895FAB70
	internal void CrossLink() {} // 0x0000000181F00B50-0x0000000181F01140
}

