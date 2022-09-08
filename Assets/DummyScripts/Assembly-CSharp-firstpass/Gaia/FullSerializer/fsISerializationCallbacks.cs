/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Gaia.FullSerializer
{
	public interface fsISerializationCallbacks // TypeDefIndex: 9251
	{
		// Methods
		void OnBeforeSerialize(System.Type storageType);
		void OnAfterSerialize(System.Type storageType, ref fsData data);
		void OnBeforeDeserialize(System.Type storageType, ref fsData data);
		void OnAfterDeserialize(System.Type storageType);
	}
}
