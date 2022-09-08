/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class ReusedAudioReport : AudioReport, IReusable // TypeDefIndex: 10999
{
	// Constructors
	protected ReusedAudioReport() {} // 0x00000001842E7BB0-0x00000001842E7C10

	// Methods
	public static TReport New<TReport, TSpawner>()
		where TReport : ReusedAudioReport
		where TSpawner : class, ISpawner<TReport>, new() => default;
	public static TReport New<TReport, T1, TSpawner, TPolisher>(T1 param1)
		where TReport : ReusedAudioReport
		where TSpawner : class, ISpawner<TReport, T1>, new()
		where TPolisher : class, IPolisher<TReport, T1>, new() => default;
	public static TReport New<TReport, T1, T2, TSpawner, TPolisher>(T1 param1, T2 param2)
		where TReport : ReusedAudioReport
		where TSpawner : class, ISpawner<TReport, T1, T2>, new()
		where TPolisher : class, IPolisher<TReport, T1, T2>, new() => default;
	public static TReport New<TReport, T1, T2, T3, TSpawner, TPolisher>(T1 param1, T2 param2, T3 param3)
		where TReport : ReusedAudioReport
		where TSpawner : class, ISpawner<TReport, T1, T2, T3>, new()
		where TPolisher : class, IPolisher<TReport, T1, T2, T3>, new() => default;
	public static TReport New<TReport, T1, T2, T3, T4, TSpawner, TPolisher>(T1 param1, T2 param2, T3 param3, T4 param4)
		where TReport : ReusedAudioReport
		where TSpawner : class, ISpawner<TReport, T1, T2, T3, T4>, new()
		where TPolisher : class, IPolisher<TReport, T1, T2, T3, T4>, new() => default;
	public static TReport New<TReport, T1, T2, T3, T4, T5, TSpawner, TPolisher>(T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
		where TReport : ReusedAudioReport
		where TSpawner : class, ISpawner<TReport, T1, T2, T3, T4, T5>, new()
		where TPolisher : class, IPolisher<TReport, T1, T2, T3, T4, T5>, new() => default;
	public abstract void BeforeRecycle();
	public abstract void Recycle();
	protected static void Recycle<TReport>(TReport report)
		where TReport : ReusedAudioReport {}
}

