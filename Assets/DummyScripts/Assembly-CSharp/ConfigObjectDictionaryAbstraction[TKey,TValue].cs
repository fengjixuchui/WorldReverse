/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using MoleMole.Config;
using SimpleJSON;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class ConfigObjectDictionaryAbstraction<TKey, TValue> : IConfigObjectDictionaryAbstraction<TKey, TValue> // TypeDefIndex: 19363
{
	// Constructors
	protected ConfigObjectDictionaryAbstraction() {}

	// Methods
	public Dictionary<TKey, TValue> DeserializeDictionaryFromFile(ConfigMetaConfig.PathHash filePathHash) => default;
	protected abstract void DictionaryFromBinary(ByteArray bytes, out Dictionary<TKey, TValue> dictionary);
	protected abstract void DictionaryFromJson(JSONNode json, out Dictionary<TKey, TValue> dictionary);
	protected virtual Dictionary<TKey, TValue> DictionaryFromBinary(ByteArray bytes) => default;
	protected virtual Dictionary<TKey, TValue> DictionaryFromJson(JSONNode json) => default;
}

