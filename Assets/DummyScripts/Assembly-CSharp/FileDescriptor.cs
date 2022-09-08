/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FileDescriptor : IDescriptor // TypeDefIndex: 26407
{
	// Fields
	internal readonly FileDescriptorProto Proto; // 0x10
	public readonly IList<MessageDescriptor> MessageTypes; // 0x18
	public readonly IList<EnumDescriptor> EnumTypes; // 0x20
	public readonly IList<ServiceDescriptor> Services; // 0x28
	public readonly IList<FileDescriptor> Dependencies; // 0x30
	public readonly IList<FileDescriptor> PublicDependencies; // 0x38
	public readonly ByteString SerializedData; // 0x40
	internal readonly DescriptorPool DescriptorPool; // 0x48

	// Properties
	string FullName { /* [XID] */ /* 0x0000000189B68450-0x0000000189B68470 */ get => default; } // 0x0000000182312890-0x0000000182312940 
	FileDescriptor File { /* [XID] */ /* 0x0000000189B6F790-0x0000000189B6F7B0 */ get => default; } // 0x00000001823127F0-0x0000000182312890 
	public string Name { /* [XID] */ /* 0x0000000189B594F0-0x0000000189B59510 */ get => default; } // 0x0000000182312740-0x00000001823127F0 
	public string Package { /* [XID] */ /* 0x0000000189B60D00-0x0000000189B60D20 */ get => default; } // 0x0000000182312470-0x0000000182312520 
	public static FileDescriptor DescriptorProtoFileDescriptor { /* [XID] */ /* 0x0000000189B947C0-0x0000000189B947E0 */ get => default; } // 0x0000000182312F40-0x0000000182313000 
	public CustomOptions CustomOptions { /* [XID] */ /* 0x0000000189B9BE70-0x0000000189B9BE90 */ get => default; } // 0x0000000182312190-0x00000001823122B0 

	// Constructors
	public FileDescriptor() {} // Dummy constructor
	private FileDescriptor(ByteString descriptorData, FileDescriptorProto proto, FileDescriptor[] dependencies, DescriptorPool pool, bool allowUnknownDependencies, GeneratedClrTypeInfo generatedCodeInfo) {} // 0x0000000182313450-0x0000000182313740

	// Methods
	// [XID] // 0x0000000189B4A4F0-0x0000000189B4A510
	internal string ComputeFullName(MessageDescriptor parent, string name) => default; // 0x00000001823122B0-0x0000000182312400
	// [XID] // 0x0000000189B51C90-0x0000000189B51CB0
	private static IList<FileDescriptor> DeterminePublicDependencies(FileDescriptor @this, FileDescriptorProto proto, FileDescriptor[] dependencies, bool allowUnknownDependencies) => default; // 0x0000000182312B90-0x0000000182312F40
	public T FindTypeByName<T>(string name)
		where T : class, IDescriptor => default;
	// [XID] // 0x0000000189B76E30-0x0000000189B76E50
	private static FileDescriptor BuildFrom(ByteString descriptorData, FileDescriptorProto proto, FileDescriptor[] dependencies, bool allowUnknownDependencies, GeneratedClrTypeInfo generatedCodeInfo) => default; // 0x0000000182312520-0x0000000182312740
	// [XID] // 0x0000000189B7E340-0x0000000189B7E360
	private void CrossLink() {} // 0x0000000182313000-0x0000000182313370
	// [XID] // 0x0000000189B85F80-0x0000000189B85FA0
	public static FileDescriptor FromGeneratedCode(byte[] descriptorData, FileDescriptor[] dependencies, GeneratedClrTypeInfo generatedCodeInfo) => default; // 0x0000000182312940-0x0000000182312B90
	// [XID] // 0x0000000189B8CFF0-0x0000000189B8D010
	public override string ToString() => default; // 0x0000000182313370-0x0000000182313450
}

