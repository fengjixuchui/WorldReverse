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

public abstract class ConfigObjectArrayAbstraction<T> : IConfigObjectArrayAbstraction<T> // TypeDefIndex: 19362
{
	// Constructors
	protected ConfigObjectArrayAbstraction() {}

	// Methods
	public abstract int GetIdFromInstance(T instance);
	public T[] DeserializeArrayFromFile(ConfigMetaConfig.PathHash filePathHash) => default;
	protected abstract void ListFromBinary(ByteArray bytes, out T[] array);
	protected abstract void ListFromJson(JSONNode json, out T[] array);
	protected virtual T[] ListFromBinary(ByteArray bytes) => default;
	protected virtual T[] ListFromJson(JSONNode json) => default;
}

