/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class SimpleObjectPool<PoolObjectType> : ISimplePool // TypeDefIndex: 14446
	where PoolObjectType : class, ISimplePoolObject, new()
{
	// Fields
	private ObjectPoolInstanceNonGenericOld _pool;

	// Constructors
	protected SimpleObjectPool() {}

	// Methods
	public static SimpleObjectPool<PoolObjectInnerType> Create<PoolObjectInnerType>()
		where PoolObjectInnerType : class, ISimplePoolObject, new() => default;
	public void ClearPool() {}
	public PoolObjectType Get() => default;
	public void Release(PoolObjectType obj) {}
}

