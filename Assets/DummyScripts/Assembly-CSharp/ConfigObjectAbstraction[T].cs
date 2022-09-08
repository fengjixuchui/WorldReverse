/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using MoleMole.Config;
using SimpleJSON;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class ConfigObjectAbstraction<T> : IConfigObjectAbstraction<T> // TypeDefIndex: 19361
{
	// Constructors
	protected ConfigObjectAbstraction() {}

	// Methods
	public virtual T DeserializeFromFile(ConfigMetaConfig.PathHash filePathHash) => default;
	protected abstract T CreateInstance();
	protected abstract bool FromBinary(T instance, ByteArray bytes);
	protected abstract bool FromJson(T instance, JSONNode json);
}

