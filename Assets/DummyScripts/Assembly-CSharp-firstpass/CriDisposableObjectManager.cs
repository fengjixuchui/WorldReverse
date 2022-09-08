/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public static class CriDisposableObjectManager // TypeDefIndex: 7243
{
	// Fields
	private static List<ObjectRef> refList; // 0x00

	// Nested types
	public enum ModuleType // TypeDefIndex: 7244
	{
		Atom = 0,
		AtomMic = 1,
		Fs = 2,
		FsWeb = 3,
		Mana = 4,
		Lips = 5,
		Vip = 6
	}

	public struct ObjectRef // TypeDefIndex: 7245
	{
		// Fields
		public Guid guid; // 0x00
		public ModuleType type; // 0x10
		public CriDisposable disposable; // 0x18

		// Constructors
		public ObjectRef(Guid _guid, CriDisposable _disposable, ModuleType _type) {
			guid = default;
			type = default;
			disposable = default;
		} // 0x0000000187A3B150-0x0000000187A3B200
	}

	// Constructors
	static CriDisposableObjectManager() {} // 0x0000000187A2B890-0x0000000187A2B920

	// Methods
	private static int SearchForDisposable(CriDisposable disposable) => default; // 0x0000000187A2B490-0x0000000187A2B6F0
	public static void Register(CriDisposable disposable, ModuleType type) {} // 0x0000000187A2B250-0x0000000187A2B490
	public static bool Unregister(CriDisposable disposable) => default; // 0x0000000187A2B6F0-0x0000000187A2B890
	public static bool IsDisposed(CriDisposable disposable) => default; // 0x0000000187A2B1C0-0x0000000187A2B250
	public static void CallOnModuleFinalization(ModuleType type) {} // 0x0000000187A2ACE0-0x0000000187A2AD60
	private static int GetNextWithType(ModuleType type) => default; // 0x0000000187A2B0A0-0x0000000187A2B1C0
	public static void DisposeAll(ModuleType type) {} // 0x0000000187A2AD60-0x0000000187A2B0A0
}

