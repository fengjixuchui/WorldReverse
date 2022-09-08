/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using MiHoYo.SDK.Protobuf.Reflection;

// Image 46: MiHoYo.SDK.Protobuf.dll - Assembly: MiHoYo.SDK.Protobuf, Version=3.0.0.0, Culture=neutral, PublicKeyToken=a7d26565bac4d604 - Types 5068-5227

namespace MiHoYo.SDK.Protobuf
{
	public interface IMessage // TypeDefIndex: 5082
	{
		// Properties
		MiHoYo.SDK.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
	
		// Methods
		void MergeFrom(CodedInputStream input);
		void WriteTo(CodedOutputStream output);
		int CalculateSize();
	}
}
