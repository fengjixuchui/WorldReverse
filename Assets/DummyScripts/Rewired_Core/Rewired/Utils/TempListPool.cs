/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Utils.Classes.Data;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Utils
{
	[CustomClassObfuscation] // 0x0000000189699A10-0x0000000189699A60
	[CustomObfuscation] // 0x0000000189699A10-0x0000000189699A60
	internal static class TempListPool // TypeDefIndex: 4369
	{
		// Fields
		private static ADictionary<System.Type, List<IList>> GlHXISOwULkhoAuMeVCqPMYrjfA; // 0x00
	
		// Properties
		private static ADictionary<System.Type, List<IList>> lists { get; } // 0x00000001862F88A0-0x00000001862F8940 
	
		// Nested types
		private static class IoTDbBaedtuNVutRxBPsdXpMhnhG // TypeDefIndex: 4370
		{
			// Fields
			private static ADictionary<System.Type, List<object>> EEjZBqDCqeLbqANlnWSJTeXudZPe; // 0x00
	
			// Properties
			private static ADictionary<System.Type, List<object>> SjfDzCWfxyrbFeWzrMeogGPWvyq { get; } // 0x00000001862E49B0-0x00000001862E4A50 
	
			// Methods
			public static TList<T> DSaFdqDaHtazMxrEgzJvIYlkcFrb<T>(List<T> param_00009149) => default;
			public static void uFWhGisiuQhxPuXVQLWsVdhrJMi<T>(TList<T> param_0000914a) {}
		}
	
		[CustomClassObfuscation] // 0x0000000189967760-0x00000001899677B0
		[CustomObfuscation] // 0x0000000189967760-0x00000001899677B0
		internal interface ITListSetter<T> // TypeDefIndex: 4371
		{
			// Methods
			void SetList(List<T> list);
		}
	
		[CustomClassObfuscation] // 0x0000000189967760-0x00000001899677B0
		[CustomObfuscation] // 0x0000000189967760-0x00000001899677B0
		internal sealed class TList<T> : IDisposable, ITListSetter<T> // TypeDefIndex: 4372
		{
			// Fields
			private List<T> WHeApkgLGAZTtUIEfvfXHvQYCck;
			private bool vsurYtRlepcrpAzAENwjqjJEZPT;
	
			// Properties
			public List<T> list { get => default; }
	
			// Constructors
			private TList() {}
	
			// Methods
			public static TList<T> Create() => default;
			public void Dispose() {}
			private void uFWhGisiuQhxPuXVQLWsVdhrJMi() {}
			void Rewired.Utils.TempListPool.ITListSetter<T>.SetList(List<T> param_0000914c) {}
			private static void jViguIyFIJVqrKtnyIzyqbNafsmi() {}
		}
	
		// Methods
		public static TList<T> GetTList<T>() => default;
		public static TList<T> GetTList<T>(int capacity) => default;
		public static List<T> Get<T>() => default;
		public static List<T> Get<T>(int capacity) => default;
		public static void Return<T>(List<T> list) {}
	}
}
