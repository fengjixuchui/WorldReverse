/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public interface IResourceExistenceCallbackHandler : IReusable // TypeDefIndex: 11403
{
	// Methods
	void Invoke(HashSet<uint> bankResults, HashSet<string> externalFileResults);
	void Recycle();
}

