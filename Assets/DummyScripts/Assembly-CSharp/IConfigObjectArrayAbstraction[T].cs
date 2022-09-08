/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using MoleMole.Config;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public interface IConfigObjectArrayAbstraction<T> // TypeDefIndex: 19359
{
	// Methods
	int GetIdFromInstance(T instance);
	T[] DeserializeArrayFromFile(ConfigMetaConfig.PathHash filePathHash);
}

