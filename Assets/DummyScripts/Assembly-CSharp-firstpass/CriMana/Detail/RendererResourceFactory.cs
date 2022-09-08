/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using CriMana;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace CriMana.Detail
{
	public abstract class RendererResourceFactory : IDisposable // TypeDefIndex: 7166
	{
		// Fields
		private static SortedList<int, RendererResourceFactory> factoryList; // 0x00
		private bool disposed; // 0x10
	
		// Constructors
		protected RendererResourceFactory() {} // 0x0000000187A46150-0x0000000187A461C0
		static RendererResourceFactory() {} // 0x0000000187A460C0-0x0000000187A46150
	
		// Methods
		// [XID] // 0x00000001897E0840-0x00000001897E0860
		public static void RegisterFactory(RendererResourceFactory factory, int priority) {} // 0x0000000187A45FC0-0x0000000187A460C0
		// [XID] // 0x00000001897E7ED0-0x00000001897E7EF0
		public static void DisposeAllFactories() {} // 0x0000000187A45AF0-0x0000000187A45D80
		// [XID] // 0x00000001897EFB40-0x00000001897EFB60
		public static RendererResource DispatchAndCreate(int playerId, MovieInfo movieInfo, bool additive, Shader userShader) => default; // 0x0000000187A457E0-0x0000000187A45AF0
		~RendererResourceFactory() {} // 0x0000000187A45F10-0x0000000187A45FC0
		// [IDTag] // 0x00000001897F7260-0x00000001897F72A0
		// [XID] // 0x00000001897F7260-0x00000001897F72A0
		public void Dispose() {} // 0x0000000187A45E60-0x0000000187A45F10
		// [IDTag] // 0x0000000189801C00-0x0000000189801C40
		// [XID] // 0x0000000189801C00-0x0000000189801C40
		private void Dispose(bool disposing) {} // 0x0000000187A45D80-0x0000000187A45E60
		protected abstract void OnDisposeManaged();
		protected abstract void OnDisposeUnmanaged();
		public abstract RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive, Shader userShader);
	}
}
