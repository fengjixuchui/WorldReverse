/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.Audio.Music.Miiha
{
	public class GameParamStorage : IGameParamLookup<MusicGameParam> // TypeDefIndex: 11351
	{
		// Fields
		private readonly Dictionary<MusicGameParam, GameParamValue> _gameParams; // 0x10
	
		// Constructors
		public GameParamStorage() {} // 0x0000000186724B10-0x0000000186724EB0
	
		// Methods
		public bool GetParam<TValue>(MusicGameParam gameParam, out TValue value) {
			value = default;
			return default;
		}
		public void SetParam<TValue>(MusicGameParam gameParam, TValue value) {}
		public void AddToParams<TValue>(MusicGameParam gameParam, TValue value)
			where TValue : struct {}
		public void RemoveFromParams<TValue>(MusicGameParam gameParam, TValue value)
			where TValue : struct {}
		private GameParamValue<T> GetParamValue<T>(MusicGameParam gameParam) => default;
	}
}
