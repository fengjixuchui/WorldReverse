/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class ReusedAudioCmd : AudioCmd, IReusable // TypeDefIndex: 10937
{
	// Constructors
	protected ReusedAudioCmd() {} // 0x0000000181ED81C0-0x0000000181ED8220

	// Methods
	public static TCmd New<TCmd, TSpawner>()
		where TCmd : ReusedAudioCmd
		where TSpawner : class, ISpawner<TCmd>, new() => default;
	public static TCmd New<TCmd, T1, TSpawner, TPolisher>(T1 param1)
		where TCmd : ReusedAudioCmd
		where TSpawner : class, ISpawner<TCmd, T1>, new()
		where TPolisher : class, IPolisher<TCmd, T1>, new() => default;
	public static TCmd New<TCmd, T1, T2, TSpawner, TPolisher>(T1 param1, T2 param2)
		where TCmd : ReusedAudioCmd
		where TSpawner : class, ISpawner<TCmd, T1, T2>, new()
		where TPolisher : class, IPolisher<TCmd, T1, T2>, new() => default;
	public static TCmd New<TCmd, T1, T2, T3, TSpawner, TPolisher>(T1 param1, T2 param2, T3 param3)
		where TCmd : ReusedAudioCmd
		where TSpawner : class, ISpawner<TCmd, T1, T2, T3>, new()
		where TPolisher : class, IPolisher<TCmd, T1, T2, T3>, new() => default;
	public static TCmd New<TCmd, T1, T2, T3, T4, TSpawner, TPolisher>(T1 param1, T2 param2, T3 param3, T4 param4)
		where TCmd : ReusedAudioCmd
		where TSpawner : class, ISpawner<TCmd, T1, T2, T3, T4>, new()
		where TPolisher : class, IPolisher<TCmd, T1, T2, T3, T4>, new() => default;
	public static TCmd New<TCmd, T1, T2, T3, T4, T5, TSpawner, TPolisher>(T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
		where TCmd : ReusedAudioCmd
		where TSpawner : class, ISpawner<TCmd, T1, T2, T3, T4, T5>, new()
		where TPolisher : class, IPolisher<TCmd, T1, T2, T3, T4, T5>, new() => default;
	public abstract void BeforeRecycle();
	public abstract void Recycle();
	protected static void Recycle<TCmd>(TCmd cmd)
		where TCmd : ReusedAudioCmd {}
}

